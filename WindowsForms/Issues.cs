using Municipality_Services_PROG7321_POE.Classes;
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
//PROG7321 POE PART 1
//Class to manipulate the issues placed and display


namespace Municipality_Services_PROG7321_POE.WindowsForms
{
    public partial class Issues : Form
    {
        /// <summary>
        /// declaring data structure to store reports issue.
        /// </summary>
        private List<ReportData> reportList;


        public Issues(List<ReportData> reports)
        {
            InitializeComponent();
            reportList = reports;
            DisplayIssues();
        }


        /// <summary>
        /// method to display reports in a DataGridView using a foreach loop
        /// </summary>
        private void DisplayIssues()
        {
            dataGridView.Rows.Clear(); 
            foreach (var report in reportList)
            {
                dataGridView.Rows.Add(report.Location, report.Category, report.Description, report.Media);
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button user clicks to go back to application form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            //displaying a message box so user confirms if they want to go back
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back? Any unsaved data will be lost.",
                "Confirm Back",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // If the user clicks "Yes", proceeds to go back
            if (result == DialogResult.Yes)
            {
                Reporting reportForm = new Reporting(); 
                this.Hide();
                reportForm.Show();
            }
        }//____________________________________________________________________________________________________________

       
    }//_________________________________________________oooooEND OF FILEooooooo___________________________________________
}//_____________________________________________________________________________________________________________________________
