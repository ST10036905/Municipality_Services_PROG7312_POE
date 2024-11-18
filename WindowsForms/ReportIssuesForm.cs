using Municipality_Services_PROG7321_POE.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
// Mayra Selemane
// ST10036905
// PROG7312 POE
// Class used to manipulate the report issues form

namespace Municipality_Services_PROG7321_POE
{
    public partial class ReportIssuesForm : Form
    {
        private List<ReportData> reportList = new List<ReportData>();
        Form1 mainForm;
        ReportData newReport;
        ServiceRequestForm requestForm;

        private Dictionary<string, string> estimatedTimes = new Dictionary<string, string>()
        {
            { "Sanitation", "1-2 days" },
            { "Utilities", "3-5 days" },
            { "Road Maintenance", "5-7 days" },
            { "Public Safety", "Immediate attention" }
        };

        public ReportIssuesForm()
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            reportList = new List<ReportData>();
        }

        private void mediaBtn_Click_1(object sender, EventArgs e)
        {
            List<string> selectedFiles = new List<string>();

            openFileDialog1.Filter = "Document Files|*.docx;*.pdf;*.txt|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            openFileDialog1.Title = "Select media to be attached";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFiles = openFileDialog1.FileNames.ToList();
                filePathTxt.Text = string.Join(", ", selectedFiles);

                string firstFile = selectedFiles.FirstOrDefault(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".png"));
                if (firstFile != null)
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(firstFile);
                    }
                    catch
                    {
                        MessageBox.Show("Error loading image preview.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                ProgressBarUpdate();
            }
        }

        private bool validateInput()
        {
            if (string.IsNullOrEmpty(locationTxtBox.Text) ||
                categoryListBox.SelectedIndex == -1 ||
                string.IsNullOrEmpty(issuesRichTxtBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(filePathTxt.Text))
            {
                DialogResult result = MessageBox.Show("No media attached. Do you wish to proceed without media?", "Media Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return result == DialogResult.Yes;
            }

            return true;
        }

        private string GetPersonalizedMessage(string category)
        {
            return estimatedTimes.ContainsKey(category)
                ? $"Thank you for reporting an issue in the {category} category. {estimatedTimes[category]}"
                : "Thank you for reporting your issue. It will be addressed promptly.";
        }

        private void ProgressBarUpdate()
        {
            int fieldCount = 0;
            int totalFields = 4;

            if (!string.IsNullOrEmpty(locationTxtBox.Text)) fieldCount++;
            if (categoryListBox.SelectedIndex != -1) fieldCount++;
            if (!string.IsNullOrEmpty(issuesRichTxtBox.Text)) fieldCount++;
            if (!string.IsNullOrEmpty(filePathTxt.Text)) fieldCount++;

            int totalProgress = (fieldCount * 100) / totalFields;
            progressBar.Value = totalProgress;
        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateInput()) return;

                string selectedCategory = categoryListBox.SelectedItem?.ToString() ?? string.Empty;
                string personalizedMessage = GetPersonalizedMessage(selectedCategory);
                string uniqueID = Guid.NewGuid().ToString().Substring(0, 3);

                MessageBox.Show(personalizedMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                newReport = new ReportData
                {
                    RequestID = uniqueID,
                    Location = locationTxtBox.Text,
                    Category = selectedCategory,
                    Description = issuesRichTxtBox.Text,
                    Media = filePathTxt.Text,
                    SubmissionDate = DateTime.Now,
                    Status = "Pending"
                };

                reportList.Add(newReport);

                MessageBox.Show($"Report submitted successfully! Your Request ID is: {uniqueID}\n" +
                    "Copy it to clipboard for tracking purposes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            DialogResult result = MessageBox.Show("Clear all fields?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                locationTxtBox.Clear();
                categoryListBox.SelectedIndex = -1;
                issuesRichTxtBox.Clear();
                filePathTxt.Clear();
                pictureBox.Image = null;
                progressBar.Value = 0;
            }
        }

        private void locationTxtBox_TextChanged(object sender, EventArgs e) => ProgressBarUpdate();

        private void categoryListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
            if (categoryListBox.SelectedItem != null)
            {
                string selectedCategory = categoryListBox.SelectedItem.ToString();
                estimatedResolutionTime.Text = estimatedTimes.ContainsKey(selectedCategory)
                    ? $"Estimated Time of Resolution: {estimatedTimes[selectedCategory]}"
                    : "Estimated Time of Resolution: Not available";
            }
        }

        private void issuesRichTxtBox_TextChanged_1(object sender, EventArgs e) => ProgressBarUpdate();

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) this.Close();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (requestForm == null || requestForm.IsDisposed)
                {
                    requestForm = new ServiceRequestForm(reportList);
                }

                requestForm.FormClosed += (s, args) => this.Show();
                this.Hide();
                requestForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
