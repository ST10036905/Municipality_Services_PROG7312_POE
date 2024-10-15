using Municipality_Services_PROG7321_POE.WindowsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
        /// sortedDictionary to organize events by date
        /// </summary>
        private SortedDictionary<DateTime, List<EventData>> eventDictionary = new SortedDictionary<DateTime, List<EventData>>();

        /// <summary>
        /// dictionary used to count for the searches.
        /// </summary>
        private Dictionary<string, int> searchCounts = new Dictionary<string, int>();


        /// <summary>
        /// constructor for AddEvent class.
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

       
        /// <summary>
        /// constructor holding parameters.
        /// </summary>
        public AddEvent()
        {
            InitializeComponent();
            SampleEvents();
            DisplayEvents();
            // Attach event handler for dropdown selection change
            categorySearchComboBox.SelectedIndexChanged += new EventHandler(CategorySearchComboBox_SelectedIndexChanged);
        }//__________________________________________________________________________________________________________



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
            if (pictureBox != null) fieldCount++;

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
        private void mediaBtn_Click(object sender, EventArgs e)
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
        /// method user clicks to go back to close menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method user clicks to close main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventWindow = null;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button user clicks to submit events/announcement details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
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
                mediaBtn.Image = null;
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


        /// <summary>
        /// method to create mock events to be displayed in form.
        /// </summary>
        private void SampleEvents()
        {

            // Create mock events based on the provided categories
            eventList = new List<EventData>

            {
                new EventData(
                    name: "Community Town Hall Meeting",
                    category: "Community Meetings",
                    description: "Discuss upcoming infrastructure projects with local council.",
                    time: DateTime.Now.AddDays(-1),
                    media: null,
                    location: "Town Hall",
                    formattedTime: DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy hh:mm tt")
                ),
                new EventData(
                    name: "Annual Music and Food Festival",
                    category: "Festival",
                    description: "Experience local bands, food stalls in Rosebank.",
                    time: DateTime.Now.AddDays(-5),
                    media: null,
                    location: "Gauteng",
                    formattedTime: DateTime.Now.AddDays(-5).ToString("dd/MM/yyyy hh:mm tt")
                ),
                new EventData(
                    name: "Career Development Workshop",
                    category: "Workshop",
                    description: "A workshop on building professional skills and networking.",
                    time: DateTime.Now.AddDays(-3),
                    media: null,
                    location: "Community Center",
                    formattedTime: DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy hh:mm tt")
                ),
                new EventData(
                    name: "Beach Clean-Up Volunteer Event",
                    category: "Volunteer Opportunities",
                    description: "Join the community in cleaning up the local beach Muizenburg.",
                    time: DateTime.Now.AddDays(-4),
                    media: null,
                    location: "Western Cape",
                    formattedTime: DateTime.Now.AddDays(-4).ToString("dd/MM/yyyy hh:mm tt")
                ),
                new EventData(
                    name: "Christmas Holiday Parade",
                    category: "Holiday Celebration",
                    description: "Enjoy the festive parade with floats and performers.",
                    time: DateTime.Now.AddDays(-10),
                    media: null,
                    location: "All provinces",
                    formattedTime: DateTime.Now.AddDays(-10).ToString("dd/MM/yyyy hh:mm tt")
                )
            };

        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to display the events in the panel using a SORTED DICTIONARY.
        /// </summary>
        private void DisplayEvents()
        {
            // Clear the event dictionary before adding new events
            eventDictionary.Clear();

            //Organizing events into the SortedDictionary by date by looping through the eventsList
            foreach (var eventItem in eventList)
            {
                if (!eventDictionary.ContainsKey(eventItem.Time))
                {
                    eventDictionary[eventItem.Time] = new List<EventData>();
                }
                eventDictionary[eventItem.Time].Add(eventItem);
            }

            // Check if there are any events in the dictionary and returning a message
            if (eventDictionary.Count == 0)
            {
                MessageBox.Show("No events to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear any existing controls in the panel to avoid duplicating events.
            flowLayoutPanel1.Controls.Clear();

            // Iterate over the sorted event dictionary by date
            foreach (var dateEntry in eventDictionary)
            {
                // For each date, there can be multiple events, so iterate through the list
                foreach (var eventItem in dateEntry.Value)
                {
                    // Creating an event control for each event and display it in the panel
                    EventsUserControl eventControl = new EventsUserControl
                    {
                        EventName = eventItem.Name,
                        EventCategory = eventItem.Category,
                        EventDescription = eventItem.Description,
                        EventLocation = eventItem.Location,
                        EventTime = eventItem.Time,
                        EventImage = eventItem.Media
                    };
                    // Adding event control to the panel to display in the UI
                    flowLayoutPanel1.Controls.Add(eventControl);
                }
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to show recommendations based on the most searched categories.
        /// </summary>
        private void ShowRecommendations()
        {
            // Check if there are any searches to base recommendations on
            if (!searchCounts.Any())
            {
                MessageBox.Show("No recommended events found based on your searches.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the top searched category
            var topCategories = searchCounts
                .OrderByDescending(kvp => kvp.Value)
                .Take(1)
                .Select(kvp => kvp.Key)
                .ToList();

            // Get recommended events based on top searched categories
            List<EventData> recommendedEvents = GetRecommendedEvents(topCategories);

            // If no recommended events found, return
            if (!recommendedEvents.Any())
            {
                MessageBox.Show("No recommended events found based on your searches.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a message to display recommended events
            var recommendationsMessage = new StringBuilder();
            recommendationsMessage.AppendLine("Here are some recommended events based on your searches:");

            // Loop through recommended events to build the message
            foreach (var recommendedEvent in recommendedEvents)
            {
                recommendationsMessage.AppendLine($"- {recommendedEvent.Name} at {recommendedEvent.Location} on {recommendedEvent.Time}");
            }

            // Display recommendations in a message box
            MessageBox.Show(recommendationsMessage.ToString(), "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to get recommended events based on searched categories.
        /// </summary>
        /// <param name="topCategories">List of top searched categories.</param>
        /// <returns>List of recommended events.</returns>
        private List<EventData> GetRecommendedEvents(List<string> topCategories)
        {
            // Normalize the category names to lower case for comparison
            var lowerTopCategories = topCategories.Select(c => c.ToLower()).ToList();

            // Filter events based on the top searched categories
            var recommendedEvents = eventList
                .Where(e => lowerTopCategories.Contains(e.Category.ToLower())) // Normalize event categories as well
                .ToList();

            return recommendedEvents;
    }//__________________________________________________________________________________________________________


        /// <summary>
        /// button used for user to view their recommendation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recommendation_Click(object sender, EventArgs e)
        {
                // Show recommendations after displaying events
                ShowRecommendations();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method used to filter based on category of event/announcement.
        /// </summary>
        private void FilterCategory()
        {
            string categoryInput = categorySearchComboBox.SelectedItem?.ToString().ToLower();

            // Update the search count if a valid category is selected
            if (!string.IsNullOrEmpty(categoryInput))
            {
                if (searchCounts.ContainsKey(categoryInput))
                {
                    searchCounts[categoryInput]++;
                }
                else
                {
                    searchCounts[categoryInput] = 1;
                }
            }

            // Filter events based on selected category
            var filteredEvents = eventList.Where(x =>
                (string.IsNullOrEmpty(categoryInput) || x.Category.ToLower() == categoryInput)).ToList();

            DisplayFilteredEvents(filteredEvents);
        
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method used to display the filtered results.
        /// </summary>
        /// <param name="filteredEvents"></param>
        private void DisplayFilteredEvents(List<EventData> filteredEvents)
        {
            // Clear the current displayed events before showing filtered results
            flowLayoutPanel1.Controls.Clear();

            if (!filteredEvents.Any())
            {
                MessageBox.Show("No events found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Loop through the filtered events and add them to the panel
            foreach (var eventItem in filteredEvents)
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
                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }//__________________________________________________________________________________________________________

        
        /// <summary>
        /// updating progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locationListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// updating progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// updating progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descriptionRichTxtBox_TextChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// updating progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// updating progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// updating progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filePathTxt_TextChanged(object sender, EventArgs e)
        {
            ProgressBarUpdate();
        }//__________________________________________________________________________________________________________

        /// <summary>
        /// calling method that filters based on combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategorySearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCategory();
        }//__________________________________________________________________________________________________________

    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________
