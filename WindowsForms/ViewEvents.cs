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
//PROG7321 POE PART 2
//Class used to manipulate the event data

namespace Municipality_Services_PROG7321_POE.WindowsForms
{
    public partial class ViewEvents : Form
    {

        /// <summary>
        /// declaring and instantiating a data structure(list) to store event data.
        /// </summary>
        public List<EventData> eventList = new List<EventData>();

        private Form1 mainFormWindow;

        public ViewEvents(Form1 mainForm, List<EventData> eventList)
        {
            InitializeComponent();
            mainFormWindow = mainForm;
            MdiParent = mainFormWindow; // Set the main form as the MDI parent
        }


        public ViewEvents(List<EventData> eventList, Form1 mainForm) 
        {
            this.eventList = eventList; // Assign the list passed in
            SampleEvents(); // Create sample events
            DisplayEvents(); // Display the events
        }



        /// <summary>
        /// method to create mock events to be displayed in form.
        /// </summary>
        private void SampleEvents()
        {

            // creating mock events based on the provided categories
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
            // For each date, there can be multiple events, so iterate through the list
            foreach (var eventItem in eventList)
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
                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }//__________________________________________________________________________________________________________


    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________

