using System;
using System.Windows.Forms;

//Mayra Selemane
//ST10036905
//PROG7312 POE
//Main window form that serves as the entry point of the application.

namespace Municipality_Services_PROG7321_POE
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form instances for various functionalities
        /// </summary>
        private ReportIssuesForm reportForm;                     
        private AddEventForm eventForm;            
        private ServiceRequestForm requestForm;
        private Dashboard dashboard;

        /// <summary>
        /// Constructor - Initializes the main form and sets it as an MDI container.
        /// </summary>
        public Form1()
        {
            try
            {
                InitializeComponent();
                IsMdiContainer = true; // Enable Multiple Document Interface (MDI) functionality
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Opens the "Report Issues" form or reactivates it if already open.
        /// </summary>
        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reportForm == null)
                {
                    reportForm = new ReportIssuesForm
                    {
                        MdiParent = this,  // Set this form as the parent
                        Dock = DockStyle.Fill // Fill the parent container
                    };
                    reportForm.FormClosed += ReportIssues_FormClosed; // Reset reference on closure
                    reportForm.Show();
                }
                else
                {
                    reportForm.Activate(); // Bring the form to focus if already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Report Issues form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets the "Report Issues" form reference when the form is closed.
        /// </summary>
        private void ReportIssues_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm = null;
        }


        /// <summary>
        /// Opens the "Latest Event" form via menu strip.
        /// </summary>
        private void latestEventMenuStrip_Click(object sender, EventArgs e)
        {
            OpenEventForm();
        }

        /// <summary>
        /// Opens the "Add Event" form or reactivates it if already open.
        /// </summary>
        private void OpenEventForm()
        {
            try
            {
                if (eventForm == null)
                {
                    eventForm = new AddEventForm
                    {
                        MdiParent = this,  // Set this form as the parent
                        Dock = DockStyle.Fill // Fill the parent container
                    };
                    eventForm.FormClosed += Announcements_FormClosed; // Reset reference on closure
                    eventForm.Show();
                }
                else
                {
                    eventForm.Activate(); // Bring the form to focus if already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Event form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets the "Add Event" form reference when the form is closed.
        /// </summary>
        private void Announcements_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventForm = null;
        }

        /// <summary>
        /// Opens the "Service Request" form or reactivates it if already open.
        /// </summary>
        private void requestsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (requestForm == null)
                {
                    requestForm = new ServiceRequestForm
                    {
                        MdiParent = this,  // Set this form as the parent
                        Dock = DockStyle.Fill // Fill the parent container
                    };
                    requestForm.FormClosed += ServiceRequest_FormClosed; // Reset reference on closure
                    requestForm.Show();
                }
                else
                {
                    requestForm.Activate(); // Bring the form to focus if already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Service Request form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets the "Service Request" form reference when the form is closed.
        /// </summary>
        private void ServiceRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            requestForm = null;
        }

        /// <summary>
        /// Displays application information via a message box.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Application developed by Mayra Selemane: PROG7321 POE PART #3", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying the About information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Closes the application safely.
        /// </summary>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Thank you for using the application. Goodbye!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while closing the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles menu strip actions for reporting issues, checking service request status, and exiting.
        /// </summary>
        private void submitANewIssueToolStripMenuItem_Click(object sender, EventArgs e) => reportIssuesBtn_Click(sender, e);
        private void serviceRequestStatusToolStripMenuItem_Click(object sender, EventArgs e) => requestsBtn_Click(sender, e);
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) => exitBtn_Click(sender, e);

        /// <summary>
        /// calling method to open local events form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localEventsBtn_Click(object sender, EventArgs e)
        {
            OpenEventForm();
        }

        /// <summary>
        /// method that redirects user to dashboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dashboard == null)
                {
                    dashboard = new Dashboard
                    {
                        MdiParent = this,  // Set this form as the parent
                        Dock = DockStyle.Fill // Fill the parent container
                    };
                    dashboard.FormClosed += Dashboard_FormClosed; // Reset reference on closure
                    dashboard.Show();
                }
                else
                {
                    dashboard.Activate(); // Bring the form to focus if already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Report Issues form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// method that resets the dashboard reference when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

    }//________________________________________________________End of File___________________________________________________________________________________
}//___________________________________________________________________________________________________________________________________________________________
