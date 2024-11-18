using System;
using System.Windows.Forms;

//Mayra Selemane
//ST10036905
//PROG7312 POE
//Class used to manipulate the dashboard

namespace Municipality_Services_PROG7321_POE
{
    public partial class Dashboard : Form
    {

        /// <summary>
        /// default constructor.
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();
            progressBar.Value = 0;
        }

        /// <summary>
        /// method to handle the feedback message
        /// </summary>
        private void feedbackMessage()
        {
            if (btnSatisfaction.Checked)
            {
                // Set progress bar to 100%  (filled)
                progressBar.Value = 100;

                MessageBox.Show("Thank you for your feedback! We're glad you're satisfied.", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// handler for when the "Neutral" radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neutralRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (neutralRadioBtn.Checked)
            {
                // Set progress bar to 50% (half filled)
                progressBar.Value = 50;

                MessageBox.Show("Thank you for your feedback! We appreciate your neutrality.", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// handler for when the "Unhappy" radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unhappyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (unhappyRadioBtn.Checked)
            {
                // Set progress bar to 0% (empty)
                progressBar.Value = 0;

                MessageBox.Show("Sorry to hear you're unhappy. We'll work to improve.", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        /// <summary>
        /// method to handle the feedback message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSatisfaction_CheckedChanged(object sender, EventArgs e)
        {
            feedbackMessage();
        }


    }//________________________________________________________End of File___________________________________________________________________________________
}//___________________________________________________________________________________________________________________________________________________________
