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
//PROG7321 POE PART 2
//Class used to manipulate the main form

namespace Municipality_Services_PROG7321_POE
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// declaring an object to represent report form.
        /// </summary>
        ReportIssues reportForm;

        /// <summary>
        /// declaring an object from issues form.
        /// </summary>
        Issues issuesForm;

        /// <summary>
        /// declaring an object from add events form. 
        /// </summary>
        AddEvent eventForm;


        /// <summary>
        /// declaring and initializing user control.
        /// </summary>
        InformativeUserControl informative = new InformativeUserControl();

        /// <summary>
        /// default constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            informative.Dock = DockStyle.Fill;
            this.Controls.Add(informative);
            informative.Show();
        }


        /// <summary>
        /// method that redirects user to report an issue/issues form.
        /// using a report form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            // Close or hide the informative user control
            informative.Hide(); 

            if (reportForm == null)
            {
                reportForm = new ReportIssues();
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

        private void ReportIssues_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm = null;
        }

        /// <summary>
        /// method that redirects user to announcement form.
        /// using an event form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void announcementsBtn_Click(object sender, EventArgs e)
        {
            // Close or hide the informative user control
            informative.Hide();

            if (eventForm == null)
            {
                eventForm = new AddEvent();
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
            // Close or hide the informative user control
            informative.Hide();

            if (eventForm == null)
            {
                eventForm = new AddEvent();
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
            if (eventForm == null)
            {
                eventForm = new AddEvent();
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

        private void announcements_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventForm = null;
        }

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
                eventForm = new AddEvent();
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
            this.Close();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to report issues form.
        /// using an report issues object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportForm = new ReportIssues();
            reportForm.Show();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to create event form.
        /// using an event form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventForm = new AddEvent();
            eventForm.Show();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// about information of the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displaying message
            MessageBox.Show("Application developed by Mayra Selemane: version 1.0 ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________

        /// <summary>
        /// button for service requests. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void requestsBtn_Click(object sender, EventArgs e)
        {
            //Displaying message
            MessageBox.Show("Maintanace mode. We will be back soon . ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________

    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________
