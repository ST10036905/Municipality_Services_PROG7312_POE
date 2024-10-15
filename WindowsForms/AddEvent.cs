using Municipality_Services_PROG7321_POE.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//Mayra Selemane
//ST10036905
//PROG7321 POE PART 2
//Class used to add an event

namespace Municipality_Services_PROG7321_POE
{
    public partial class AddEvent : Form
    {
        /// <summary>
        /// declaring an object from eventData class.
        /// </summary>
        EventData newEvent;

        /// <summary>
        /// declaring and instantiating a data structure(list) to store event data.
        /// </summary>
        public List<EventData> eventList = new List<EventData>();

        /// <summary>
        /// declaring an object from view events class.
        /// </summary>
        ViewEvents eventWindow;

        /// <summary>
        /// constructor for AddEvent class
        /// </summary>
        public AddEvent(List<EventData> events)
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            eventList = events;
        }//__________________________________________________________________________________________________________

        public AddEvent()
        {
            InitializeComponent();
            SampleEvents();
            DisplayEvents();
        }


        /// <summary>
        /// method used to validate user input.
        /// </summary>
        /// <returns>true if the validation passes, otherwise false</returns>
        private bool validateInput()
        {
            // Validate empty fields, including ListBox selection
            if (string.IsNullOrEmpty(nameTxtBox.Text) ||
                categoryListBox.SelectedIndex == -1 ||
                string.IsNullOrEmpty(descriptionRichTxtBox.Text) ||
                locationListBox.SelectedIndex == -1 ||
                    dateTimePicker.Value ==  null)
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button user clicks to submit events/announcement details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                bool isValid = validateInput();
                if (!isValid)
                {
                    return;
                }

                // Get the selected user category
                string selectedCategory = categoryListBox.SelectedItem?.ToString() ?? string.Empty;

                //Get user selected location
                string selectedLocation = locationListBox.SelectedItem?.ToString() ?? string.Empty;

                // Create a new EventData object and populate its fields
                EventData newEvent = new EventData
                {
                    Name = nameTxtBox.Text,
                    Category = selectedCategory,
                    Description = descriptionRichTxtBox.Text,
                    Time = dateTimePicker.Value,
                    Media = pictureBox.Image,
                    Location = selectedLocation
                };

                // Add the new event object to the eventList
                eventList.Add(newEvent);

                // Displaying details of the last event added to the list
                MessageBox.Show($"Location: {newEvent.Location}\n" +
                                $"Category: {newEvent.Category}\n" +
                                $"Description: {newEvent.Description}\n" +
                                $"Media: {newEvent.Media}\n" +
                                $"Time: {newEvent.Time}",
                                "Submitted Event Details",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Clear the form after submission
                nameTxtBox.Clear();
                categoryListBox.SelectedIndex = -1;
                descriptionRichTxtBox.Clear();
                dateTimePicker.Value = DateTime.Now;
                mediaBtn.Text = "";
                locationListBox.SelectedIndex = -1;

                DisplayEvents();  // Re-display events, including the new one
            }
            catch (Exception ex)
            {
                // Handling any errors during submission
                MessageBox.Show($"Error during submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }//__________________________________________________________________________________________________________


        /// <summary>
        /// button that redirects user to go back to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn1_Click(object sender, EventArgs e)
        {
            // Confirm if the user wants to go back
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

        private void SampleEvents()
        {

            // Create mock events for testing
            eventList = new List<EventData>
             {
                new EventData
                {
                    Name = "Music Festival",
                    Category = "Entertainment",
                    Description = "A fun-filled music festival with live bands.",
                    Location = "City Park",
                    Time = DateTime.Now.AddDays(1) // Tomorrow
                },
                new EventData
                {
                    Name = "Community Meeting",
                    Category = "Public",
                    Description = "A meeting to discuss local issues with the council.",
                    Location = "Town Hall",
                    Time = DateTime.Now.AddDays(2) // Day after tomorrow
                },
                new EventData
                {
                    Name = "Charity Run",
                    Category = "Charity",
                    Description = "A marathon to raise funds for local charities.",
                    Location = "Riverside",
                    Time = DateTime.Now.AddDays(3) // In three days
                }
             };
           // DisplayEvents();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to display the events in the panel.
        /// </summary>
        private void DisplayEvents()
        {

            foreach (var eventItem in eventList)
            {
                EventsUserControl eventControl = new EventsUserControl
                {
                    EventName = eventItem.Name,
                    EventCategory = eventItem.Category,
                    EventDescription = eventItem.Description,
                    EventLocation = eventItem.Location,
                    EventTime = eventItem.Time,
                    EventImage = eventItem.Media
                };

                eventControl.Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that updates the progress bar percentage based on field count.
        /// </summary>
        private void ProgressBarUpdate()
        {
            int fieldCount = 0;
            int totalFields = 5; 

            // Increment fieldCount if each respective field is filled
            if (!string.IsNullOrEmpty(nameTxtBox.Text)) fieldCount++;
            if (categoryListBox.SelectedIndex != -1) fieldCount++;
            if (!string.IsNullOrEmpty(descriptionRichTxtBox.Text)) fieldCount++;
            if (locationListBox.SelectedIndex != -1) fieldCount++;
            if (pictureBox !=null ) fieldCount++;

            // Calculate the total progress percentage
            int totalProgress = (fieldCount * 100) / totalFields;

            // Update the progress bar value
            progressBar.Value = Math.Min(totalProgress, 100);
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that stores and displays media.
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


    private void eventWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventWindow = null;
        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }

        private void descriptionRichTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }

        private void categoryListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }

        private void nameTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }

        private void filePathTxt_TextChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }


    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________
