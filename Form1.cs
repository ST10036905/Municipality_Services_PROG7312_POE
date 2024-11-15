using Municipality_Services_PROG7321_POE.Classes;
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
//PROG7321 POE 
//Class used to manipulate the main form

namespace Municipality_Services_PROG7321_POE
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// declaring an object to represent report form.
        /// </summary>
        ReportIssuesForm reportForm;

        /// <summary>
        /// declaring an object from issues form.
        /// </summary>
        Issues issuesForm;

        /// <summary>
        /// declaring an object from add events form. 
        /// </summary>
        AddEventForm eventForm;

        /// <summary>
        /// declaring an object from add events form. 
        /// </summary>
        ServiceRequestForm requestForm;

        /// <summary>
        /// default constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }


        /// <summary>
        /// method that redirects user to report an issue/issues form.
        /// using a report form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            // closing the informative user control
            //informative.Hide();

            if (reportForm == null)
            {
                reportForm = new ReportIssuesForm();
                reportForm.FormClosed += ReportIssues_FormClosed;

                reportForm.MdiParent = this;
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
        }

       

        /// <summary>
        /// method that redirects user to announcement form.
        /// using an event form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void announcementsBtn_Click(object sender, EventArgs e)
        {
            // closing the informative user control
            //informative.Hide();

            if (eventForm == null)
            {
                eventForm = new AddEventForm();
                eventForm.FormClosed += announcements_FormClosed;

                eventForm.MdiParent = this;
                eventForm.Dock = DockStyle.Fill;
                eventForm.Show();
            }
            else
            {
                eventForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button used for users to view events. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            // closing the informative user control
            //informative.Hide();

            if (eventForm == null)
            {
                eventForm = new AddEventForm();
                eventForm.FormClosed += announcements_FormClosed;

                eventForm.MdiParent = this;
                eventForm.Dock = DockStyle.Fill;
                eventForm.Show();
            }
            else
            {
                eventForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to announcement form.
        /// using an event form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localEventsBtn_Click_1(object sender, EventArgs e)
        {
            // closing the informative user control
            //informative.Hide();

            if (eventForm == null)
            {
                eventForm = new AddEventForm();
                eventForm.FormClosed += announcements_FormClosed;

                eventForm.MdiParent = this;
                eventForm.Dock = DockStyle.Fill;
                eventForm.Show();
            }
            else
            {
                eventForm.Activate();
            }
        }//__________________________________________________________________________________________________________



        /// <summary>
        /// method that redirects user to view latest event form.
        /// using an event form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void latestEventMenuStrip_Click(object sender, EventArgs e)
        {

            if (eventForm == null)
            {
                eventForm = new AddEventForm();
                eventForm.FormClosed += announcements_FormClosed;

                eventForm.MdiParent = this;
                eventForm.Dock = DockStyle.Fill;
                eventForm.Show();
            }
            else
            {
                eventForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to report issues form.
        /// using an report issues object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // closing the informative user control
            //informative.Hide();

            if (reportForm == null)
            {
                reportForm = new ReportIssuesForm();
                reportForm.FormClosed += ReportIssues_FormClosed;

                reportForm.MdiParent = this;
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to create event form.
        /// using an event form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventForm == null)
            {
                eventForm = new AddEventForm();
                eventForm.FormClosed += announcements_FormClosed;

                eventForm.MdiParent = this;
                eventForm.Dock = DockStyle.Fill;
                eventForm.Show();
            }
            else
            {
                eventForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to close form and application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// closing form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportIssues_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm = null;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// closing form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void announcements_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventForm = null;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// about information of the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displaying message
            MessageBox.Show("Application developed by Mayra Selemane: POE PART #3", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button for service requests. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void requestsBtn_Click(object sender, EventArgs e)
        {
            if (requestForm == null)
            {
                requestForm = new ServiceRequestForm();
                requestForm.FormClosed += serviceRequest_FormClosed;

                requestForm.MdiParent = this;
                requestForm.Dock = DockStyle.Fill;
                requestForm.Show();
            }
            else
            {
                requestForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        private void serviceRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            requestForm = null;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// toolstrip for service request. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (requestForm == null)
            {
                requestForm = new ServiceRequestForm();
                requestForm.FormClosed += serviceRequest_FormClosed;

                requestForm.MdiParent = this;
                requestForm.Dock = DockStyle.Fill;
                requestForm.Show();
            }
            else
            {
                requestForm.Activate();
            }
        }//__________________________________________________________________________________________________________

    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________
