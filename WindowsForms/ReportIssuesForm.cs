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
        /// <summary>
        /// declaring a list to store the reports submitted by users.
        /// </summary>
        private List<ReportData> reportList = new List<ReportData>();

        /// <summary>
        /// declaring an instance if reportdata class.
        /// </summary>
        ReportData newReport;

        /// <summary>
        /// generating resolution times for each category of service using a dictionary.
        /// </summary>
        private Dictionary<string, string> estimatedTimes = new Dictionary<string, string>()
        {
            { "Sanitation", "1-2 days" },
            { "Utilities", "3-5 days" },
            { "Road Maintenance", "5-7 days" },
            { "Public Safety", "Immediate attention" }
        };

        /// <summary>
        /// Initializes the ReportIssuesForm, setting up the progress bar and report list.
        /// </summary>
        public ReportIssuesForm()
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            reportList = new List<ReportData>();
        }

        /// <summary>
        /// Handles media file selection for the issue report.
        /// Allows multiple file selections and displays a preview of the first image.
        /// </summary>
        private void mediaBtn_Click_1(object sender, EventArgs e)
        {
            try
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
                            pictureBox.Image = Image.FromFile(firstFile); // Display the image
                        }
                        catch
                        {
                            MessageBox.Show("Error loading image preview.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    ProgressBarUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while selecting media: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates the input fields to ensure that required fields are completed.
        /// Displays a warning if any required field is missing.
        /// </summary>
        /// <returns>True if input is valid, false otherwise.</returns>
        private bool validateInput()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in validation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Generates a personalized message based on the selected issue category.
        /// </summary>
        /// <param name="category">The category of the issue.</param>
        /// <returns>A personalized message based on the category.</returns>
        private string GetPersonalizedMessage(string category)
        {
            return estimatedTimes.ContainsKey(category)
                ? $"Thank you for reporting an issue in the {category} category. {estimatedTimes[category]}"
                : "Thank you for reporting your issue. It will be addressed promptly.";
        }

        /// <summary>
        /// Updates the progress bar based on the completion of input fields.
        /// </summary>
        private void ProgressBarUpdate()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating progress: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the submission of the issue report.
        /// Validates input, generates a request ID, and stores the report data.
        /// </summary>
        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateInput()) return;

                string selectedCategory = categoryListBox.SelectedItem?.ToString() ?? string.Empty;

                string personalizedMessage = GetPersonalizedMessage(selectedCategory);

                string uniqueID = Guid.NewGuid().ToString().Substring(0, 3);

                MessageBox.Show(personalizedMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Creating the new report data
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

                // Add the report to the list
                reportList.Add(newReport);

                // Displaying what was entered
                string enteredDetails = $"Location: {newReport.Location}\n" +
                                        $"Category: {newReport.Category}\n" +
                                        $"Description: {newReport.Description}\n" +
                                        $"Media: {newReport.Media}\n" +
                                        $"Request ID: {newReport.RequestID}";

                MessageBox.Show(enteredDetails, "Entered Report Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show($"Report submitted successfully! Your Request ID is: {uniqueID}\n" +
                                "Copy it to clipboard for tracking purposes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears the form after submitting a report.
        /// Prompts the user for confirmation before clearing the fields.
        /// </summary>
        private void ClearForm()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error while clearing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for when the location text box changes.
        /// Updates the progress bar accordingly.
        /// </summary>
        private void locationTxtBox_TextChanged(object sender, EventArgs e) => ProgressBarUpdate();

        /// <summary>
        /// Event handler for when the category selection changes.
        /// Updates the progress bar accordingly.
        /// </summary>
        private void categoryListBox_SelectedIndexChanged_1(object sender, EventArgs e) => ProgressBarUpdate();

        /// <summary>
        /// Event handler for when the issue description text box changes.
        /// Updates the progress bar accordingly.
        /// </summary>
        private void issuesRichTxtBox_TextChanged_1(object sender, EventArgs e) => ProgressBarUpdate();

        /// <summary>
        /// Event handler for the back button.
        /// Asks the user for confirmation before closing the form.
        /// </summary>
        private void backBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while going back: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }//________________________________________________________End of File___________________________________________________________________________________
}//___________________________________________________________________________________________________________________________________________________________

