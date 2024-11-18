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
        private Dictionary<string, ReportData> requestDictionary;

        private Dictionary<string, string> predefinedProgress = new Dictionary<string, string>()
        {
            { "Sanitation", "In Progress" },
            { "Utilities", "Pending" },
            { "Road Maintenance", "Pending" },
            { "Public Safety", "Immediate Attention" }
        };

        public ServiceRequestForm()
        {
            InitializeComponent();
            // Generate dummy reports
            List<ReportData> dummyReports = GenerateDummyReports();

            // Populate the dictionary
            requestDictionary = dummyReports.ToDictionary(r => r.RequestID, r => r);

            // Update statuses for predefined progress
            UpdateRequestStatus();

            // Bind data to the DataGridView
            serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports);

            // Build the TreeView with categorized data
            BuildServiceTree();

            // Debugging log to ensure loading is happening as expected
            Console.WriteLine($"Loaded {dummyReports.Count} dummy reports.");

        }

        public ServiceRequestForm(List<ReportData> reports)
        {
            InitializeComponent();

            if (reports == null || reports.Count == 0)
            {
                MessageBox.Show("No reports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            requestDictionary = reports.ToDictionary(x => x.RequestID, x => x);
            UpdateRequestStatus();
            serviceRequestsGridView.DataSource = new BindingList<ReportData>(reports);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string requestId = searchId.Text.Trim();

            if (string.IsNullOrEmpty(requestId))
            {
                MessageBox.Show("Please enter a Request ID to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundReport = requestDictionary.FirstOrDefault(r => r.Key == requestId).Value;

            if (foundReport != null)
            {
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(new List<ReportData> { foundReport });
            }
            else
            {
                MessageBox.Show("Report not found. Displaying all data.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(requestDictionary.Values.ToList());
            }
        }

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

        private List<ReportData> GenerateDummyReports()
        {
            return new List<ReportData>
            {
                new ReportData { RequestID = Guid.NewGuid().ToString().Substring(0,4), Category = "Sanitation", Description = "Blocked drain at Main Street", Status = "Pending" },
                new ReportData { RequestID = Guid.NewGuid().ToString().Substring(0,4), Category = "Sanitation", Description = "Overflowing bin at Park", Status = "Pending" },
                new ReportData { RequestID = Guid.NewGuid().ToString().Substring(0, 4), Category = "Utilities", Description = "No water supply in Sector 7", Status = "Pending" },
                new ReportData { RequestID = Guid.NewGuid().ToString().Substring(0, 4), Category = "Utilities", Description = "Electrical outage in Block 5", Status = "Pending" },
                new ReportData { RequestID = Guid.NewGuid().ToString().Substring(0, 4), Category = "Road Maintenance", Description = "Potholes on Elm Street", Status = "Pending" },
                new ReportData { RequestID = Guid.NewGuid().ToString().Substring(0, 4), Category = "Public Safety", Description = "Broken streetlight on Oak Avenue", Status = "Immediate Attention" }
            };
        }


        private void BuildServiceTree()
        {
            var rootNode = new TreeNode("Municipality Services");

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

            rootNode.Nodes.Add(sanitationNode);
            rootNode.Nodes.Add(utilitiesNode);
            rootNode.Nodes.Add(roadMaintenanceNode);
            rootNode.Nodes.Add(publicSafetyNode);

            serviceTreeView.Nodes.Add(rootNode);
        }

        private void serviceTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Level == 0) return;

            var selectedText = e.Node.Text.Split(':')[0].Trim();
            if (requestDictionary.TryGetValue(selectedText, out var selectedReport))
            {
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(new List<ReportData> { selectedReport });
            }
        }
    }
}