using Municipality_Services_PROG7321_POE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

//Mayra Selemane
//ST10036905
//PROG7321 POE PART 
//Class used to manipulate service request

namespace Municipality_Services_PROG7321_POE
{
    public partial class ServiceRequestForm : Form
    {
        /// <summary>
        /// Declaring dictionary to fetch report data.
        /// </summary>
        private Dictionary<string, ReportData> requestDictionary;

        /// <summary>
        /// Declaring a dictionary to predefine progress values.
        /// </summary>
        private Dictionary<string, string> predefinedProgress = new Dictionary<string, string>()
        {
            { "Sanitation", "In Progress" },
            { "Utilities", "Pending" },
            { "Road Maintenance", "Pending" },
            { "Public Safety", "Immediate Attention" }
        };

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ServiceRequestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="reports"></param>
        public ServiceRequestForm(List<ReportData> reports)
        {
            InitializeComponent();

            // Check if the reports list is null or empty
            if (reports == null || reports.Count == 0)
            {
                MessageBox.Show("No reports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize and populate the dictionary
            requestDictionary = reports.ToDictionary(x => x.RequestID, x => x);

            // Update status of reports (if necessary)
            UpdateRequestStatus();

            // Load the data into the grid view
            serviceRequestsGridView.DataSource = new BindingList<ReportData>(reports);
        }

        /// <summary>
        /// Button user clicks to search for a specific request id.
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string requestId = searchId.Text.Trim();

            if (string.IsNullOrEmpty(requestId))
            {
                MessageBox.Show("Please enter a Request ID to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the report by Request ID
            var foundReport = requestDictionary.FirstOrDefault(r => r.Key == requestId).Value;

            if (foundReport != null)
            {
                // If found, show the report details in the DataGridView
                var foundReportsList = new List<ReportData> { foundReport };
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(foundReportsList);
            }
            else
            {
                MessageBox.Show("Report not found. Please check the Request ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to update the status of service requests.
        /// </summary>
        private void UpdateRequestStatus()
        {
            foreach (var key in requestDictionary.Keys.ToList())
            {
                var report = requestDictionary[key];
                if (predefinedProgress.ContainsKey(report.Category))
                {
                    report.Status = predefinedProgress[report.Category];
                }
            }
            serviceRequestsGridView.DataSource = new BindingList<ReportData>(requestDictionary.Values.ToList());
        }

        /// <summary>
        /// Method to generate dummy reports with categories and statuses.
        /// </summary>
        private List<ReportData> GenerateDummyReports()
        {
            List<ReportData> reports = new List<ReportData>();

            // Sanitation Reports
            reports.Add(new ReportData { RequestID = "R001", Category = "Sanitation", Description = "Blocked drain at Main Street", Status = "Pending" });
            reports.Add(new ReportData { RequestID = "R002", Category = "Sanitation", Description = "Overflowing bin at Park", Status = "Pending" });

            // Utilities Reports
            reports.Add(new ReportData { RequestID = "R003", Category = "Utilities", Description = "No water supply in Sector 7", Status = "Pending" });
            reports.Add(new ReportData { RequestID = "R004", Category = "Utilities", Description = "Electrical outage in Block 5", Status = "Pending" });

            // Road Maintenance Reports
            reports.Add(new ReportData { RequestID = "R005", Category = "Road Maintenance", Description = "Potholes on Elm Street", Status = "Pending" });

            // Public Safety Reports
            reports.Add(new ReportData { RequestID = "R006", Category = "Public Safety", Description = "Broken streetlight on Oak Avenue", Status = "Immediate Attention" });

            return reports;
        }

        /// <summary>
        /// Method to build a tree-like structure of services and requests.
        /// </summary>
        private void BuildServiceTree()
        {
            var rootNode = new TreeNode("Municipality Services");

            // Create subcategories
            var sanitationNode = new TreeNode("Sanitation");
            sanitationNode.Nodes.Add("R001: Blocked drain at Main Street");
            sanitationNode.Nodes.Add("R002: Overflowing bin at Park");

            var utilitiesNode = new TreeNode("Utilities");
            utilitiesNode.Nodes.Add("R003: No water supply in Sector 7");
            utilitiesNode.Nodes.Add("R004: Electrical outage in Block 5");

            var roadMaintenanceNode = new TreeNode("Road Maintenance");
            roadMaintenanceNode.Nodes.Add("R005: Potholes on Elm Street");

            var publicSafetyNode = new TreeNode("Public Safety");
            publicSafetyNode.Nodes.Add("R006: Broken streetlight on Oak Avenue");

            // Add subcategories to root
            rootNode.Nodes.Add(sanitationNode);
            rootNode.Nodes.Add(utilitiesNode);
            rootNode.Nodes.Add(roadMaintenanceNode);
            rootNode.Nodes.Add(publicSafetyNode);

            // Add the root node to the TreeView control
            serviceTreeView.Nodes.Add(rootNode);

            // Log the result to ensure the tree is populated
            Console.WriteLine("TreeView populated with dummy data.");
        }

        /// <summary>
        /// This method is called when the form loads to initialize the TreeView with dummy data.
        /// </summary>
        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            List<ReportData> dummyReports = GenerateDummyReports();
            requestDictionary = dummyReports.ToDictionary(r => r.RequestID, r => r);

            // Populate the TreeView with the service categories and requests
            BuildServiceTree();

            // Optionally update the grid view as well
            serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports);

            // Log to confirm the data is being passed correctly
            Console.WriteLine($"Generated {dummyReports.Count} dummy reports and populated the TreeView.");
        }

        private void serviceTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
