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
        /// 
        /// </summary>
        public List<EventData> eventList = new List<EventData>();

        //---------------Variables to hold eventy data 
        public string EventName { get; set; }
        public string EventCategory { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventTime { get; set; }

        public ViewEvents()
        {
            InitializeComponent();  // Ensure form components are initialized
        }


        public ViewEvents(List<EventData> eventList)
        {
            InitializeComponent();
            this.eventList = eventList;
            LoadEvents(eventList);  // Load the events into the sorted dictionary
           // DisplayEvents();        // Display them in the panel
        }

        /// <summary>
        /// 
        /// </summary>
        private SortedDictionary<DateTime, List<EventData>> sortedEvents = new SortedDictionary<DateTime, List<EventData>>();

        /// <summary>
        /// constructor.
        /// </summary>
        //public ViewEvents(List<EventData> eventList)
        //{
        //    InitializeComponent();
        //    LoadEvents(eventList);
        //    DisplayEvents();
        //}


        /// <summary>
        /// method to load events into a sorted dictionary for efficient retrieval.
        /// </summary>
        private void LoadEvents(List<EventData> eventsList)
        {
            foreach (var ev in eventList)
            {
                if (!sortedEvents.ContainsKey(ev.Time.Date))
                {
                    sortedEvents[ev.Time.Date] = new List<EventData>();
                }
                sortedEvents[ev.Time.Date].Add(ev);
            }
        }//_________________________________________________________________________________________________


        

        private void ViewEvents_Load(object sender, EventArgs e)
        {
            //DisplayEvents();
        }
    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________

