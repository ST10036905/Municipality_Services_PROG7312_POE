using Municipality_Services_PROG7321_POE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

// Mayra Selemane
// ST10036905
// PROG7312 POE PART
// Class used to manipulate service requests

namespace Municipality_Services_PROG7321_POE
{
    public partial class ServiceRequestForm : Form
    {
        /// <summary>
        /// Dictionary to hold service requests, using RequestID as the key
        /// </summary>
        private Dictionary<string, ReportData> requestDictionary;

        /// <summary>
        /// Declaring an instance of binary search tree class.
        /// </summary>
        private BinarySearchTree bst;

        /// <summary>
        /// Predefined progress statuses based on service category
        /// </summary>
        private Dictionary<string, string> predefinedProgress = new Dictionary<string, string>()
        {
            { "Sanitation", "In Progress" },
            { "Utilities", "Pending" },
            { "Road Maintenance", "Pending" },
            { "Public Safety", "Immediate Attention" }
        };

        /// <summary>
        /// Constructor that generates dummy reports and initializes the form
        /// </summary>
        public ServiceRequestForm()
        {
            try
            {
                InitializeComponent();

                // Initializing the binary search tree
                bst = new BinarySearchTree();

                // Generate dummy reports
                Queue<ReportData> dummyReports = GenerateDummyReports();

                // Insert the dummy reports into the binary search tree
                foreach (var report in dummyReports)
                {
                    bst.Insert(report);
                }

                // Populate the dictionary with the dummy reports, using RequestID as the key
                requestDictionary = dummyReports.ToDictionary(r => r.RequestID, r => r);

                // Update the statuses of the reports based on predefined progress
                UpdateRequestStatus();

                // Bind the dummy reports to the DataGridView for display
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports.ToList());

                // Build the TreeView with categorized data (Sanitation, Utilities, etc.)
                BuildServiceTree();

                // Debugging log to check how many dummy reports are loaded
                Console.WriteLine($"Loaded {dummyReports.Count} dummy reports.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Constructor that accepts a list of reports and initializes the form
        /// </summary>
        /// <param name="reports"></param>
        public ServiceRequestForm(List<ReportData> reports)
        {
            try
            {
                InitializeComponent();

                // If no reports are provided, show an error message and return
                if (reports == null || reports.Count == 0)
                {
                    MessageBox.Show("No reports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Populate the dictionary with the provided reports, using RequestID as the key
                requestDictionary = reports.ToDictionary(x => x.RequestID, x => x);

                // Update the statuses of the reports based on predefined progress
                UpdateRequestStatus();

                // Bind the provided reports to the DataGridView for display
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(reports);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the form with provided reports: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to update the status of each request based on predefined progress
        /// </summary>
        private void UpdateRequestStatus()
        {
            try
            {
                foreach (var key in requestDictionary.Keys.ToList())
                {
                    var report = requestDictionary[key];
                    if (predefinedProgress.ContainsKey(report.Category))
                    {
                        report.Status = predefinedProgress[report.Category];
                    }
                }

                // Rebind the data to reflect the updated statuses
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(requestDictionary.Values.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the request statuses: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to generate a queue of dummy service reports for testing
        /// </summary>
        /// <returns></returns>
        private Queue<ReportData> GenerateDummyReports()
        {
            try
            {
                return new Queue<ReportData>(new List<ReportData>
                {
                    new ReportData
                    {
                        RequestID = "R001",
                        Location = "Vilakazi Street, Soweto",
                        Category = "Sanitation",
                        Description = "Blocked drain on Vilakazi Street, Soweto",
                        SubmissionDate = DateTime.Now.AddDays(10),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R002",
                        Location = "Greenmarket Square, Cape Town",
                        Category = "Sanitation",
                        Description = "Overflowing bin in Greenmarket Square, Cape Town",
                        SubmissionDate = DateTime.Now.AddDays(-9),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R003",
                        Location = "Umlazi Township, Durban",
                        Category = "Utilities",
                        Description = "No water supply in Umlazi Township, Durban",
                        SubmissionDate = DateTime.Now.AddDays(-2),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R004",
                        Location = "Khayelitsha, Cape Town",
                        Category = "Utilities",
                        Description = "Frequent power cuts in Khayelitsha, Cape Town",
                        SubmissionDate = DateTime.Now.AddDays(-3),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R005",
                        Location = "N1 Highway near Johannesburg",
                        Category = "Road Maintenance",
                        Description = "Large potholes on the N1 Highway near Johannesburg",
                        SubmissionDate = DateTime.Now.AddDays(-7),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R006",
                        Location = "Rondebosch Main Road intersection, Cape Town",
                        Category = "Road Maintenance",
                        Description = "Broken traffic light at the Rondebosch Main Road intersection, Cape Town",
                        SubmissionDate = DateTime.Now.AddDays(-5),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R007",
                        Location = "Alexandra Township, Johannesburg",
                        Category = "Public Safety",
                        Description = "Broken streetlights in Alexandra Township, Johannesburg",
                        SubmissionDate = DateTime.Now.AddDays(-1),
                        Status = "Immediate Attention"
                    },
                    new ReportData
                    {
                        RequestID = "R008",
                        Location = "Bryanston, Johannesburg",
                        Category = "Public Safety",
                        Description = "Tree blocking road in Bryanston, Johannesburg",
                        SubmissionDate = DateTime.Now.AddDays(-18),
                        Status = "Immediate Attention"
                    },
                    new ReportData
                    {
                        RequestID = "R009",
                        Location = "Durban beachfront",
                        Category = "Sanitation",
                        Description = "Uncollected trash near the Durban beachfront",
                        Media = "null",
                        SubmissionDate = DateTime.Now.AddDays(-10),
                        Status = "Pending"
                    },
                    new ReportData
                    {
                        RequestID = "R010",
                        Location = "Centurion, Pretoria",
                        Category = "Utilities",
                        Description = "Low water pressure in Centurion, Pretoria",
                        SubmissionDate = DateTime.Now.AddDays(-15),
                        Status = "Pending"
                    }
                });
         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating dummy reports: {ex.Message}", "Report Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Queue<ReportData>();
            }
        }

        /// <summary>
        /// Method to build the service request TreeView with categorized data
        /// </summary>
        private void BuildServiceTree()
        {
            try
            {
                var rootNode = new TreeNode("Municipality Services");

                // Creating child nodes for different categories
                var sanitationNode = new TreeNode("Sanitation");
                sanitationNode.Nodes.Add("R001: Blocked drain on Vilakazi Street, Soweto");
                sanitationNode.Nodes.Add("R002: Overflowing bin in Greenmarket Square, Cape Town");
                sanitationNode.Nodes.Add("R009: Uncollected trash near the Durban beachfront");

                var utilitiesNode = new TreeNode("Utilities");
                utilitiesNode.Nodes.Add("R003: No water supply in Umlazi Township, Durban");
                utilitiesNode.Nodes.Add("R004: Frequent power cuts in Khayelitsha, Cape Town");
                utilitiesNode.Nodes.Add("R010: Low water pressure in Centurion, Pretoria");

                var roadMaintenanceNode = new TreeNode("Road Maintenance");
                roadMaintenanceNode.Nodes.Add("R005: Large potholes on the N1 Highway near Johannesburg");
                roadMaintenanceNode.Nodes.Add("R006: Broken traffic light at the Rondebosch Main Road intersection, Cape Town");

                var publicSafetyNode = new TreeNode("Public Safety");
                publicSafetyNode.Nodes.Add("R007: Broken streetlights in Alexandra Township, Johannesburg");
                publicSafetyNode.Nodes.Add("R008: Tree blocking road in Bryanston, Johannesburg");

                // Add all nodes to the root node
                rootNode.Nodes.Add(sanitationNode);
                rootNode.Nodes.Add(utilitiesNode);
                rootNode.Nodes.Add(roadMaintenanceNode);
                rootNode.Nodes.Add(publicSafetyNode);

                // Set the TreeView's root node
                serviceTreeView.Nodes.Add(rootNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while building the service tree: {ex.Message}", "Tree Construction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for TreeView node selection
        /// </summary>
        private void serviceTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Level > 0)
                {
                    string selectedRequest = e.Node.Text.Split(':')[0].Trim();

                    // Find the report based on the Request ID selected from the TreeView
                    var report = requestDictionary[selectedRequest];

                    // Display the details of the selected report
                    MessageBox.Show($"Report ID: {report.RequestID}\nLocation: {report.Location}\nCategory: {report.Category}\nDescription: {report.Description}\nStatus: {report.Status}", "Report Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying the report details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for search button click
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string requestId = searchId.Text.Trim();
                string category = categoryComboBox.SelectedItem?.ToString();
                string status = statusComboBox.SelectedItem?.ToString();
                DateTime? startDate = startDatePicker.Value;
                DateTime? endDate = endDatePicker.Value;

                // Filter the reports using BST or LINQ
                List<ReportData> filteredReports = bst.InOrderTraversal()
                    .Where(r =>
                        (string.IsNullOrEmpty(requestId) || r.RequestID.Contains(requestId)) &&
                        (string.IsNullOrEmpty(category) || r.Category.Contains(category)) &&
                        (string.IsNullOrEmpty(status) || r.Status.Contains(status)) &&
                        (!startDate.HasValue || r.SubmissionDate >= startDate.Value) &&
                        (!endDate.HasValue || r.SubmissionDate <= endDate.Value))
                    .ToList();

                // Bind the filtered reports to the DataGridView
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(filteredReports);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handler for button that user clicks to reset the service requests search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the search filters (e.g., text boxes, combo boxes)
                searchId.Text = "";
                categoryComboBox.SelectedIndex = -1;
                statusComboBox.SelectedIndex = -1;
                startDatePicker.Value = DateTime.Now;
                endDatePicker.Value = DateTime.Now;

                // Reset the Binary Search Tree (instead of setting to null)
                bst = new BinarySearchTree();

                // Reinsert the dummy reports (if needed)
                Queue<ReportData> dummyReports = GenerateDummyReports();
                foreach (var report in dummyReports)
                {
                    bst.Insert(report);
                }

                // Clear the DataGridView by setting DataSource to null
                serviceRequestsGridView.DataSource = null;

                // Optionally, you may re-bind the DataGridView if necessary
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports.ToList());

                // Reset any other UI elements if necessary
                BuildServiceTree(); // Rebuild the tree view if needed
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resetting the search: {ex.Message}", "Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }//________________________________________________________End of File___________________________________________________________________________________
}//___________________________________________________________________________________________________________________________________________________________

