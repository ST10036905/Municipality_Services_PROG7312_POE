using Municipality_Services_PROG7321_POE.WindowsForms;
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
//PROG7321 POE PART 
//Class used to add events

namespace Municipality_Services_PROG7321_POE
{
    public partial class AddEventForm : Form
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
        /// 
        /// </summary>
        private Form1 mainFormWindow;

        /// <summary>
        /// sortedDictionary to organize events by date
        /// </summary>
        private SortedDictionary<DateTime, List<EventData>> eventDictionary = new SortedDictionary<DateTime, List<EventData>>();

        /// <summary>
        /// dictionary used to count for the searches.
        /// </summary>
        private Dictionary<string, int> searchCounts = new Dictionary<string, int>();

        /// <summary>
        /// defining a HashSet to store unique categories.
        /// </summary>
        private HashSet<string> uniqueCategories = new HashSet<string>();

        /// <summary>
        /// defining a stack to store search history.
        /// </summary>
        private Stack<string> searchHistoryStack = new Stack<string>();
        private Form1 form1;

        public AddEventForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// constructor for AddEvent class.
        /// </summary>
        public AddEventForm(Form1 mainForm, List<EventData> events)
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            mainFormWindow = mainForm;
            eventList = events;
        }//__________________________________________________________________________________________________________

       
        /// <summary>
        /// method used to validate user input.
        /// </summary>
        /// <returns>true if the validation passes, otherwise false</returns>
        private bool validateInput()
        {
            // validating empty fields, including ListBox selection
            if (string.IsNullOrEmpty(nameTxtBox.Text) ||
                categoryListBox.SelectedIndex == -1 ||
                string.IsNullOrEmpty(descriptionRichTxtBox.Text) ||
                locationListBox.SelectedIndex == -1 ||
                    dateTimePicker.Value == null)
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

            // incrementing fieldCount if each respective field is filled
            if (!string.IsNullOrEmpty(nameTxtBox.Text)) fieldCount++;
            if (categoryListBox.SelectedIndex != -1) fieldCount++;
            if (!string.IsNullOrEmpty(descriptionRichTxtBox.Text)) fieldCount++;
            if (locationListBox.SelectedIndex != -1) fieldCount++;
            if (pictureBox != null) fieldCount++;

            // calculating the total progress percentage
            int totalProgress = (fieldCount * 100) / totalFields;

            // updating the progress bar value
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
        /// button user clicks to submit events/announcement details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // validating input
                bool isValid = validateInput();
                if (!isValid)
                {
                    return;
                }

                // getting the selected user category
                string selectedCategory = categoryListBox.SelectedItem?.ToString() ?? string.Empty;

                // getting user selected location
                string selectedLocation = locationListBox.SelectedItem?.ToString() ?? string.Empty;

                // creating a new EventData object and populate its fields
                EventData newEvent = new EventData
                {
                    Name = nameTxtBox.Text,
                    Category = selectedCategory,
                    Description = descriptionRichTxtBox.Text,
                    Time = dateTimePicker.Value,
                    Media = pictureBox.Image,
                    Location = selectedLocation
                };

                // adding the new event object to the eventList
                eventList.Add(newEvent);

                // displaying details of the last event added to the list
                MessageBox.Show($"Location: {newEvent.Location}\n" +
                                $"Category: {newEvent.Category}\n" +
                                $"Description: {newEvent.Description}\n" +
                                $"Media: {newEvent.Media}\n" +
                                $"Time: {newEvent.Time}",
                                "Submitted Event Details",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // clearing the form after submission
                nameTxtBox.Clear();
                categoryListBox.SelectedIndex = -1;
                descriptionRichTxtBox.Clear();
                dateTimePicker.Value = DateTime.Now;
                mediaBtn.Image = null;
                locationListBox.SelectedIndex = -1;

                DisplayEvents();  // Re-displaying events, including the new one
            }
            catch (Exception ex)
            {
                // handling any errors during submission
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
            // confirming if the user wants to go back
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
        /// method to display the events in the panel using a SORTED DICTIONARY.
        /// </summary>
        private void DisplayEvents()
        {
            // clearing the event dictionary before adding new events
            eventDictionary.Clear();

            // organizing events into the SortedDictionary by date by looping through the eventsList
            foreach (var eventItem in eventList)
            {
                if (!eventDictionary.ContainsKey(eventItem.Time))
                {
                    eventDictionary[eventItem.Time] = new List<EventData>();
                }
                eventDictionary[eventItem.Time].Add(eventItem);
            }

            // checking if there are any events in the dictionary and returning a message
            if (eventDictionary.Count == 0)
            {
                MessageBox.Show("No events to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // clearing any existing controls in the panel to avoid duplicating events.
            //part 3 flowLayoutPanel1.Controls.Clear();

            // iterating over the sorted event dictionary by date
            foreach (var dateEntry in eventDictionary)
            {
                // For each date, there can be multiple events, so iterate through the list
                foreach (var eventItem in dateEntry.Value)
                {
                    // creating an event control for each event and display it in the panel
                    EventsUserControl eventControl = new EventsUserControl
                    {
                        EventName = eventItem.Name,
                        EventCategory = eventItem.Category,
                        EventDescription = eventItem.Description,
                        EventLocation = eventItem.Location,
                        EventTime = eventItem.Time,
                        EventImage = eventItem.Media
                    };
                    // adding event control to the panel to display in the UI
                    // part 3 flowLayoutPanel1.Controls.Add(eventControl);
                }
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to show recommendations based on the most searched categories.
        /// </summary>
        /// <summary>
        private void ShowRecommendations()
        {
            // checking if there are any searches to base recommendations on
            if (!searchCounts.Any())
            {
                MessageBox.Show("No recommended events found based on your searches.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // getting the top searched categories
            var topCategories = searchCounts
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => kvp.Key)
                .ToList();

            // getting recommended events based on top searched categories
            List<EventData> recommendedEvents = GetRecommendedEvents(topCategories);

            // returning information if no recommendation found
            if (!recommendedEvents.Any())
            {
                MessageBox.Show("No recommended events found based on your searches.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // creating a message to display recommended events
            var recommendationsMessage = new StringBuilder();
            recommendationsMessage.AppendLine("Here are some recommended events based on your searches:");

            // looping through recommended events to build the message
            foreach (var recommendedEvent in recommendedEvents)
            {
                recommendationsMessage.AppendLine($"- {recommendedEvent.Name} at {recommendedEvent.Location} on {recommendedEvent.FormattedTime}");
            }

            // displaying recommendations in a message box
            MessageBox.Show(recommendationsMessage.ToString(), "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to get recommended events based on searched categories.
        /// </summary>
        /// <param name="topCategories">List of top searched categories.</param>
        /// <returns>List of recommended events.</returns>
        private List<EventData> GetRecommendedEvents(List<string> topCategories)
        {
            // normalizing the category names to lower case for comparison
            var lowerTopCategories = topCategories.Select(c => c.ToLower()).ToList();

            // filtering events based on the top searched categories
            var recommendedEvents = eventList
                .Where(e => lowerTopCategories.Contains(e.Category.ToLower()))
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
            // showing recommendations after displaying events
            ShowRecommendations();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method used to filter based on category of event/announcement.
        /// </summary>
        /// <summary>
        //private void FilterCategory()
        //{

        //        string categoryInput = categorySearchComboBox.SelectedItem?.ToString().ToLower();

        //        // updating the search count if a valid category is selected
        //        if (!string.IsNullOrEmpty(categoryInput))
        //        {
        //            if (searchCounts.ContainsKey(categoryInput))
        //            {
        //                searchCounts[categoryInput]++;
        //            }
        //            else
        //            {
        //                searchCounts[categoryInput] = 1;
        //            }
        //        }

        //        // filtering events based on selected category
        //        var filteredEvents = eventList.Where(x =>
        //            (string.IsNullOrEmpty(categoryInput) || x.Category.ToLower() == categoryInput)).ToList();

        //        DisplayFilteredEvents(filteredEvents);
        //}//__________________________________________________________________________________________________________


        /// <summary>
        /// method to display the filtered results.
        /// </summary>
        /// <param name="filteredEvents">List of filtered events to display.</param>
        //private void DisplayFilteredEvents(List<EventData> filteredEvents)
        //{
        //    // clearing the current displayed events before showing filtered results
        //    //part 3 flowLayoutPanel1.Controls.Clear();

        //    if (!filteredEvents.Any())
        //    {
        //        MessageBox.Show("No events found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    // looping through the filtered events and add them to the panel
        //    foreach (var eventItem in filteredEvents)
        //    {
        //        EventsUserControl eventControl = new EventsUserControl
        //        {
        //            EventName = eventItem.Name,
        //            EventCategory = eventItem.Category,
        //            EventDescription = eventItem.Description,
        //            EventLocation = eventItem.Location,
        //            EventTime = eventItem.Time,
        //            EventImage = eventItem.Media
        //        };
        //        flowLayoutPanel1.Controls.Add(eventControl);
        //    }
        //}//________________________________________________________________________________________________________

        /// <summary>
        /// method to populate unique categories from event data.
        /// </summary>
        private void PopulateUniqueCategories()
        {
            // clearing the set to avoid duplicates from previous operations
            uniqueCategories.Clear();

            // iterating through the event list and add unique categories to the set
            foreach (var eventItem in eventList)
            {
                uniqueCategories.Add(eventItem.Category.ToLower());
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to display unique categories in the combo box.
        /// </summary>
        private void DisplayUniqueCategories()
        {
            // populating unique categories first
            PopulateUniqueCategories();

            // clearing existing items in the category combo box
            // part 3 categorySearchComboBox.Items.Clear();

            // adding unique categories from the HashSet to the combo box
            foreach (var category in uniqueCategories)
            {
                //part 3 categorySearchComboBox.Items.Add(category);
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method to handle the category search and store the history.
        /// </summary>
        //private void SearchCategory()
        //{
        //    //part 3 string categoryInput = categorySearchComboBox.SelectedItem?.ToString().ToLower();

        //    // pushing the search term onto the stack
        //    if (!string.IsNullOrEmpty(categoryInput))
        //    {
        //        searchHistoryStack.Push(categoryInput);
        //    }

        //    // filtering events based on the selected category
        //    var filteredEvents = eventList.Where(x =>
        //        (string.IsNullOrEmpty(categoryInput) || x.Category.ToLower() == categoryInput)).ToList();

        //    DisplayFilteredEvents(filteredEvents);
        //}//__________________________________________________________________________________________________________


        /// <summary>
        /// method to undo the last search.
        /// </summary>
        //private void UndoLastSearch()
        //{
        //    // checking if the stack is not empty
        //    if (searchHistoryStack.Count > 0)
        //    {
        //        // poping the last search term from the stack
        //        searchHistoryStack.Pop();

        //        // getting the previous search term, if any
        //        string previousSearch = searchHistoryStack.Count > 0 ? searchHistoryStack.Peek() : string.Empty;

        //        // filtering events based on the previous search
        //        var filteredEvents = eventList.Where(x =>
        //            (string.IsNullOrEmpty(previousSearch) || x.Category.ToLower() == previousSearch)).ToList();

        //        DisplayFilteredEvents(filteredEvents);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No previous search to undo.", "Undo Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}//__________________________________________________________________________________________________________


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

        ///// <summary>
        ///// calling method that filters based on combo box.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void CategorySearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    FilterCategory();
        //}//__________________________________________________________________________________________________________


        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewEvents viewEventsForm = new ViewEvents(mainFormWindow, eventList);
            viewEventsForm.MdiParent = mainFormWindow; // Set the main form as the MDI parent
            viewEventsForm.Dock = DockStyle.Fill; // Make the child form fill the parent container
            viewEventsForm.FormBorderStyle = FormBorderStyle.Sizable; // Ensure the form is sizable
            viewEventsForm.WindowState = FormWindowState.Maximized; // Maximize the child form
            this.Close();
            viewEventsForm.Show();
        }


    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________

