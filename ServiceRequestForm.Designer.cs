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
            this.serviceRequestPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.dateTimeFilter = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.searchId = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.serviceRequestPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceRequestPanel
            // 
            this.serviceRequestPanel.Controls.Add(this.statusPanel);
            this.serviceRequestPanel.Controls.Add(this.buttonPanel);
            this.serviceRequestPanel.Controls.Add(this.categoryComboBox);
            this.serviceRequestPanel.Controls.Add(this.categoryLbl);
            this.serviceRequestPanel.Controls.Add(this.dateTimeFilter);
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
            // statusPanel
            // 
            this.statusPanel.Location = new System.Drawing.Point(0, 255);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1300, 393);
            this.statusPanel.TabIndex = 64;
            // 
            // buttonPanel
            // 
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
            this.searchBtn.Location = new System.Drawing.Point(508, 8);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(279, 57);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Complete",
            "Pending",
            "In progress"});
            this.categoryComboBox.Location = new System.Drawing.Point(1116, 153);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(172, 24);
            this.categoryComboBox.TabIndex = 62;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(1004, 151);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(120, 23);
            this.categoryLbl.TabIndex = 61;
            this.categoryLbl.Text = "Category : ";
            // 
            // dateTimeFilter
            // 
            this.dateTimeFilter.Location = new System.Drawing.Point(789, 151);
            this.dateTimeFilter.Name = "dateTimeFilter";
            this.dateTimeFilter.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFilter.TabIndex = 60;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(719, 148);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(68, 23);
            this.dateLbl.TabIndex = 59;
            this.dateLbl.Text = "Date :";
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
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel serviceRequestPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchId;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.DateTimePicker dateTimeFilter;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel statusPanel;
    }
}