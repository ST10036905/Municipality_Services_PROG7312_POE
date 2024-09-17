using Municipality_Services_PROG7321_POE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Mayra Selemane
//ST10036905
//PROG7321 POE PART 1
//Class to manipulate report issues form

namespace Municipality_Services_PROG7321_POE.WindowsForms
{
    public partial class Reporting : Form
    {
        /// <summary>
        ///  declaring and instantiating a data structure(list) to store report issues data.
        /// </summary>
        private List<ReportData> reportList = new List<ReportData>();

        /// <summary>
        /// declaring an instance for the main form.
        /// </summary>
        Form1 mainForm;

        /// <summary>
        /// declaring and instantiating an object from report data class.
        /// </summary>
        ReportData newReport;


        /// <summary>
        /// default constructor used to initialize components and the progress bar (user engagement feature).
        /// </summary>
        public Reporting()
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            reportList = new List<ReportData>();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// form load to display date the current date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reporting_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// declaring a dictionary (data structure) to store estimated times for the resolution of different categories.
        /// user engagement feature as dates for resolution are personalized.
        /// </summary>
        private Dictionary<string, string> estimatedTimes = new Dictionary<string, string>()
        {
            { "Sanitation", "1-2 days" },
            { "Utilities", "3-5 days" },
            { "Road Maintenance", "5-7 days" },
            { "Public Safety", "Immediate attention" }
        };//__________________________________________________________________________________________________________


        /// <summary>
        /// method that stores and displays media in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaBtn_Click_1(object sender, EventArgs e)
        {
            //using a generic list (data structure) that stores the different medias attached
            List<string> selectedFiles = new List<string>();

            //setting up the file dialog to allow for different formats and image types.
            openFileDialog1.Filter = "Document Files|*.docx;*.pdf;*.txt|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            openFileDialog1.Title = "Select media to be attached";

            // allowing the selection of multiple files
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //storing the selected files in a list
                selectedFiles = openFileDialog1.FileNames.ToList();

                //displaying selected files in a TextBox or ListBox
                filePathTxt.Text = string.Join(", ", selectedFiles);

                // Preview first image if an image file is selected
                string firstFile = selectedFiles.FirstOrDefault(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".png"));
                if (firstFile != null)
                {
                    pictureBox.Image = Image.FromFile(firstFile);
                }
                ProgressBarUpdate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that validates user input.
        /// </summary>
        /// <returns> true if the validation passes, otherwise false </returns>
        private bool validateInput()
            {
            // Validate empty fields, including ListBox selection
            if (string.IsNullOrEmpty(locationTxtBox.Text) ||
                categoryListBox.SelectedIndex == -1 ||
                string.IsNullOrEmpty(issuesRichTxtBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that determines a personalized message based on the selected category (user engagement) feature.
        /// </summary>
        /// <param name="category">The selected category from the ListBox.</param>
        /// <returns>A personalized message string.</returns>
        private string GetPersonalizedMessage(string category)
        {
            switch (category)
            {
                case "Sanitation":
                    return "Thank you for reporting a sanitation issue. We are committed to keeping our community clean.";
                case "Utilities":
                    return "Your utilities report is important to us. Our team will address this issue as soon as possible.";
                case "Road Maintenance":
                    return "Road maintenance issues can cause major disruptions. We will work to resolve this promptly.";
                case "Public Safety":
                    return "Your safety is our priority. We will investigate this issue immediately.";
                default:
                    return "Thank you for your report. We will address the issue as soon as possible.";
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that updates the progress bar percentage based on field count.
        /// </summary>
        private void ProgressBarUpdate()
        {
            int fieldCount = 0;
            int totalFields = 4;

            // Checking if each field is filled and update fieldCount
            if (!string.IsNullOrEmpty(locationTxtBox.Text))
                fieldCount++;
            if (categoryListBox.SelectedIndex != -1)
                fieldCount++;
            if (!string.IsNullOrEmpty(issuesRichTxtBox.Text))
                fieldCount++;
            if (!string.IsNullOrEmpty(filePathTxt.Text))
                fieldCount++;

            // Calculating the total progress as a percentage
            int totalProgress = (fieldCount * 100) / totalFields;

            // Update the progress bar value
            progressBar.Value = totalProgress;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button user clicks to submit reporting details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Calling the method that validates input
                bool isValid = validateInput();

                if (!isValid)
                {
                    // While input is not valid, return early and do not proceed with submission
                    return;
                }

                // Getting the selected user category
                string selectedCategory = categoryListBox.SelectedItem?.ToString() ?? string.Empty;

                // Retrieving the personalized message (user engagement feature)
                string personalizedMessage = GetPersonalizedMessage(selectedCategory);

                // Displaying success message
                MessageBox.Show(personalizedMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                newReport = new ReportData
                {
                    Location = locationTxtBox.Text,
                    Category = selectedCategory,
                    Description = issuesRichTxtBox.Text,
                    Media = filePathTxt.Text
                };

                // Adding the new report object to the reportList (data structure)
                reportList.Add(newReport);

                // Displaying the details of the last report added to the list
                MessageBox.Show($"Location: {newReport.Location}\n" +
                        $"Category: {newReport.Category}\n" +
                        $"Description: {newReport.Description}\n" +
                        $"Media: {newReport.Media}\n" +
                        $"Time : {DateTime.Now}",
                        "Submitted Report Details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // Clearing the form after submission
                locationTxtBox.Clear();
                categoryListBox.SelectedIndex = -1;
                issuesRichTxtBox.Clear();
                filePathTxt.Clear();
                pictureBox.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button that views all the applications.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewBtn_Click_1(object sender, EventArgs e)
        {
            // creating an instance of the Issues form and passing the report list.
            Issues issuesForm = new Issues(reportList);

            // setting the Issues form as an MDI child.
            issuesForm.MdiParent = this.MdiParent; 

            // docking the form to fill the MDI container.
            issuesForm.Dock = DockStyle.Fill;

            this.Close();

            issuesForm.Show();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// calling the method to update progress bar whenever content changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locationTxtBox_TextChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// calling method to update progress bar and displaying estimated resolution time using a data dictionary(data structure).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
           
            // Check if an item is selected before accessing its value
            if (categoryListBox.SelectedItem != null)
            {
                string selectedCategory = categoryListBox.SelectedItem.ToString();

                // Check if the selected category exists in the dictionary
                if (estimatedTimes.ContainsKey(selectedCategory))
                {
                    estimatedResolutionTime.Text = $"Estimated Time of Resolution: {estimatedTimes[selectedCategory]}";
                }
                else
                {
                    estimatedResolutionTime.Text = "Estimated Time of Resolution: Not available";
                }
            }
            else
            {
                // No category selected, clear the label or set a default message
                estimatedResolutionTime.Text = "Please select a category for your issue.";
            }
        }//__________________________________________________________________________________________________________

       
        /// <summary>
        /// calling method to update progress bar whenever contents change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void issuesRichTxtBox_TextChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button that redirects user to go back to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click_1(object sender, EventArgs e)
        {
            //displaying a message box so user confirms if they want to go back
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back?",
                "Confirm Back",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }//__________________________________________________________________________________________________________

        
    }//_________________________________________________oooooEND OF FILEooooooo___________________________________________
}//_____________________________________________________________________________________________________________________________
