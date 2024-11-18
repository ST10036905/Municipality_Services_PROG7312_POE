namespace Municipality_Services_PROG7321_POE
{
    partial class ServiceRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestForm));
            this.serviceRequestPanel = new System.Windows.Forms.Panel();
            this.serviceTreeView = new System.Windows.Forms.TreeView();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.serviceRequestsGridView = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.searchId = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.serviceRequestPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestsGridView)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceRequestPanel
            // 
            this.serviceRequestPanel.Controls.Add(this.endDatePicker);
            this.serviceRequestPanel.Controls.Add(this.label1);
            this.serviceRequestPanel.Controls.Add(this.serviceTreeView);
            this.serviceRequestPanel.Controls.Add(this.statusPanel);
            this.serviceRequestPanel.Controls.Add(this.buttonPanel);
            this.serviceRequestPanel.Controls.Add(this.categoryComboBox);
            this.serviceRequestPanel.Controls.Add(this.categoryLbl);
            this.serviceRequestPanel.Controls.Add(this.startDatePicker);
            this.serviceRequestPanel.Controls.Add(this.dateLbl);
            this.serviceRequestPanel.Controls.Add(this.statusComboBox);
            this.serviceRequestPanel.Controls.Add(this.filterLbl);
            this.serviceRequestPanel.Controls.Add(this.searchId);
            this.serviceRequestPanel.Controls.Add(this.searchLbl);
            this.serviceRequestPanel.Controls.Add(this.description);
            this.serviceRequestPanel.Controls.Add(this.Title);
            this.serviceRequestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceRequestPanel.Location = new System.Drawing.Point(0, 0);
            this.serviceRequestPanel.Name = "serviceRequestPanel";
            this.serviceRequestPanel.Size = new System.Drawing.Size(1300, 741);
            this.serviceRequestPanel.TabIndex = 0;
            // 
            // serviceTreeView
            // 
            this.serviceTreeView.Location = new System.Drawing.Point(740, 227);
            this.serviceTreeView.Name = "serviceTreeView";
            this.serviceTreeView.Size = new System.Drawing.Size(525, 369);
            this.serviceTreeView.TabIndex = 65;
            this.toolTip1.SetToolTip(this.serviceTreeView, "Displays a tree with the issues");
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.serviceRequestsGridView);
            this.statusPanel.Location = new System.Drawing.Point(0, 214);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(681, 393);
            this.statusPanel.TabIndex = 64;
            // 
            // serviceRequestsGridView
            // 
            this.serviceRequestsGridView.BackgroundColor = System.Drawing.Color.Tan;
            this.serviceRequestsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceRequestsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceRequestsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.serviceRequestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceRequestsGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.serviceRequestsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceRequestsGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.serviceRequestsGridView.Location = new System.Drawing.Point(0, 0);
            this.serviceRequestsGridView.Name = "serviceRequestsGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceRequestsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.serviceRequestsGridView.RowHeadersWidth = 100;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.serviceRequestsGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.serviceRequestsGridView.RowTemplate.Height = 24;
            this.serviceRequestsGridView.Size = new System.Drawing.Size(681, 393);
            this.serviceRequestsGridView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.serviceRequestsGridView, "Data grid view with the service requests and their status in abinary search tree");
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.resetBtn);
            this.buttonPanel.Controls.Add(this.pictureBox2);
            this.buttonPanel.Controls.Add(this.searchBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 669);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1300, 72);
            this.buttonPanel.TabIndex = 63;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(953, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(245, 57);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.searchBtn, "Search and filter");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Utilities",
            "Sanitation",
            "Public Safety",
            "Others"});
            this.categoryComboBox.Location = new System.Drawing.Point(830, 154);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(172, 24);
            this.categoryComboBox.TabIndex = 62;
            this.toolTip1.SetToolTip(this.categoryComboBox, "Select category of issue");
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(704, 151);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(120, 23);
            this.categoryLbl.TabIndex = 61;
            this.categoryLbl.Text = "Category : ";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(1148, 117);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(125, 22);
            this.startDatePicker.TabIndex = 60;
            this.toolTip1.SetToolTip(this.startDatePicker, "Select date that request was issued");
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(1026, 117);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(114, 23);
            this.dateLbl.TabIndex = 59;
            this.dateLbl.Text = "Start date :";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Complete",
            "Pending",
            "In progress"});
            this.statusComboBox.Location = new System.Drawing.Point(437, 147);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(261, 24);
            this.statusComboBox.TabIndex = 58;
            this.toolTip1.SetToolTip(this.statusComboBox, "Select a status for your search");
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.Location = new System.Drawing.Point(358, 147);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(78, 23);
            this.filterLbl.TabIndex = 57;
            this.filterLbl.Text = "Status :";
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(129, 149);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(216, 22);
            this.searchId.TabIndex = 56;
            this.toolTip1.SetToolTip(this.searchId, "Search using a specific ID");
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(15, 145);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(115, 23);
            this.searchLbl.TabIndex = 55;
            this.searchLbl.Text = "Search ID :";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(407, 56);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(476, 50);
            this.description.TabIndex = 54;
            this.description.Text = "Users can be able to view the status of their requests, \r\nsearch using ID and fil" +
    "ter by date. ";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.Title.Location = new System.Drawing.Point(413, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(454, 47);
            this.Title.TabIndex = 53;
            this.Title.Text = "Service Request Status";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1028, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "End date :";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(1148, 156);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(125, 22);
            this.endDatePicker.TabIndex = 67;
            this.toolTip1.SetToolTip(this.endDatePicker, "Select date that request was issued");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1124, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(629, 19);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(238, 48);
            this.resetBtn.TabIndex = 60;
            this.resetBtn.Text = "Reset";
            this.toolTip1.SetToolTip(this.resetBtn, "Clear the filter and search criteria");
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1300, 741);
            this.Controls.Add(this.serviceRequestPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceRequestForm";
            this.Text = "ServiceRequestForm";
            this.serviceRequestPanel.ResumeLayout(false);
            this.serviceRequestPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestsGridView)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel serviceRequestPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchId;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.DataGridView serviceRequestsGridView;
        private System.Windows.Forms.TreeView serviceTreeView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button resetBtn;
    }
}