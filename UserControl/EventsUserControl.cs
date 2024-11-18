using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
//Mayra Selemane
//ST10036905
//PROG7312 POE
//Class used to manipulate event data

namespace Municipality_Services_PROG7321_POE
{
    public partial class EventsUserControl : UserControl
    { 
        /// <summary>
        /// default constructor.
        /// </summary>
        public EventsUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Variables for event properties
        /// </summary>
        private string _eventName;
        private string _eventCategory;
        private string _eventLocation;
        private string _eventDescription;
        private DateTime _eventTime;
        private Image _eventImage;

        // Property for Event Name
        [Category("Custom Props")]
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; nameLbl.Text = value; }
        }

        // Property for Event Category
        [Category("Custom Props")]
        public string EventCategory
        {
            get { return _eventCategory; }
            set { _eventCategory = value; categoryLbl.Text = value; }
        }

        // Property for Event Location
        [Category("Custom Props")]
        public string EventLocation
        {
            get { return _eventLocation; }
            set { _eventLocation = value; locationLbl.Text = value; }
        }

        // Property for Event Description
        [Category("Custom Props")]
        public string EventDescription
        {
            get { return _eventDescription; }
            set { _eventDescription = value; descriptionLbl.Text = value; }
        }

        // Property for Event Time
        [Category("Custom Props")]
        public DateTime EventTime
        {
            get { return _eventTime; }
            set { _eventTime = value; timeLbl.Text = value.ToString("dd/MM/yyyy hh:mm tt"); }  
        }

        // Property for Event Image
        [Category("Custom Props")]
        public Image EventImage
        {
            get { return _eventImage; }
            set
            {
                _eventImage = value;
                pictureBoxDisplay.Image = value; 
            }
        }

    }//________________________________________________________End of File___________________________________________________________________________________
}//___________________________________________________________________________________________________________________________________________________________
