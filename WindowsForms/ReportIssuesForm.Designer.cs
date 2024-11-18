namespace Municipality_Services_PROG7321_POE
{
    partial class ReportIssuesForm
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
            this.reportIssuesPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.estimatedResolutionTime = new System.Windows.Forms.TextBox();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mediaBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.issuesRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reportIssuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportIssuesPanel
            // 
            this.reportIssuesPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.reportIssuesPanel.Controls.Add(this.progressBar);
            this.reportIssuesPanel.Controls.Add(this.estimatedResolutionTime);
            this.reportIssuesPanel.Controls.Add(this.filePathTxt);
            this.reportIssuesPanel.Controls.Add(this.pictureBox);
            this.reportIssuesPanel.Controls.Add(this.mediaBtn);
            this.reportIssuesPanel.Controls.Add(this.label5);
            this.reportIssuesPanel.Controls.Add(this.issuesRichTxtBox);
            this.reportIssuesPanel.Controls.Add(this.label4);
            this.reportIssuesPanel.Controls.Add(this.categoryListBox);
            this.reportIssuesPanel.Controls.Add(this.label3);
            this.reportIssuesPanel.Controls.Add(this.locationTxtBox);
            this.reportIssuesPanel.Controls.Add(this.label2);
            this.reportIssuesPanel.Controls.Add(this.label6);
            this.reportIssuesPanel.Controls.Add(this.label1);
            this.reportIssuesPanel.Controls.Add(this.buttonPanel);
            this.reportIssuesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportIssuesPanel.Location = new System.Drawing.Point(0, 0);
            this.reportIssuesPanel.Name = "reportIssuesPanel";
            this.reportIssuesPanel.Size = new System.Drawing.Size(1308, 754);
            this.reportIssuesPanel.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1308, 10);
            this.progressBar.TabIndex = 32;
            // 
            // estimatedResolutionTime
            // 
            this.estimatedResolutionTime.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.estimatedResolutionTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estimatedResolutionTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedResolutionTime.ForeColor = System.Drawing.Color.Crimson;
            this.estimatedResolutionTime.Location = new System.Drawing.Point(82, 503);
            this.estimatedResolutionTime.Name = "estimatedResolutionTime";
            this.estimatedResolutionTime.Size = new System.Drawing.Size(665, 25);
            this.estimatedResolutionTime.TabIndex = 30;
            // 
            // filePathTxt
            // 
            this.filePathTxt.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.filePathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTxt.ForeColor = System.Drawing.Color.Black;
            this.filePathTxt.Location = new System.Drawing.Point(796, 434);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(331, 75);
            this.filePathTxt.TabIndex = 25;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(812, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(385, 347);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox, "Media will be shown here");
            // 
            // mediaBtn
            // 
            this.mediaBtn.BackColor = System.Drawing.Color.White;
            this.mediaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBtn.ForeColor = System.Drawing.Color.Black;
            this.mediaBtn.Location = new System.Drawing.Point(317, 390);
            this.mediaBtn.Name = "mediaBtn";
            this.mediaBtn.Size = new System.Drawing.Size(431, 45);
            this.mediaBtn.TabIndex = 23;
            this.mediaBtn.Text = "Click here to attach media (optional)";
            this.mediaBtn.UseVisualStyleBackColor = false;
            this.mediaBtn.Click += new System.EventHandler(this.mediaBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Attach media : ";
            // 
            // issuesRichTxtBox
            // 
            this.issuesRichTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issuesRichTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issuesRichTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesRichTxtBox.ForeColor = System.Drawing.Color.Black;
            this.issuesRichTxtBox.Location = new System.Drawing.Point(316, 317);
            this.issuesRichTxtBox.Name = "issuesRichTxtBox";
            this.issuesRichTxtBox.Size = new System.Drawing.Size(431, 42);
            this.issuesRichTxtBox.TabIndex = 21;
            this.issuesRichTxtBox.Text = "";
            this.toolTip1.SetToolTip(this.issuesRichTxtBox, "Provide a description for the issue");
            this.issuesRichTxtBox.TextChanged += new System.EventHandler(this.issuesRichTxtBox_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description of issue:";
            // 
            // categoryListBox
            // 
            this.categoryListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.categoryListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListBox.ForeColor = System.Drawing.Color.Black;
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 28;
            this.categoryListBox.Items.AddRange(new object[] {
            "Sanitation",
            "Utilities",
            "Road Maintenance",
            "Public safety",
            "Others..."});
            this.categoryListBox.Location = new System.Drawing.Point(316, 242);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(431, 32);
            this.categoryListBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.categoryListBox, "Select a category where issue falls in");
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.categoryListBox_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Report category : ";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.BackColor = System.Drawing.Color.White;
            this.locationTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxtBox.ForeColor = System.Drawing.Color.Black;
            this.locationTxtBox.Location = new System.Drawing.Point(317, 167);
            this.locationTxtBox.Multiline = true;
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(431, 34);
            this.locationTxtBox.TabIndex = 17;
            this.toolTip1.SetToolTip(this.locationTxtBox, "Enter location that issue occured");
            this.locationTxtBox.TextChanged += new System.EventHandler(this.locationTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Location : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(524, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Application form";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(396, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Municipality Report Issues";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.backBtn);
            this.buttonPanel.Controls.Add(this.submitBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 689);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1308, 65);
            this.buttonPanel.TabIndex = 31;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backBtn.Location = new System.Drawing.Point(1095, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(182, 60);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.toolTip1.SetToolTip(this.backBtn, "Back to main window");
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitBtn.AutoSize = true;
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitBtn.Location = new System.Drawing.Point(29, 3);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(206, 60);
            this.submitBtn.TabIndex = 26;
            this.submitBtn.Text = "Submit";
            this.toolTip1.SetToolTip(this.submitBtn, "Submit your issue ");
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 754);
            this.Controls.Add(this.reportIssuesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportIssuesForm";
            this.ShowInTaskbar = false;
            this.Text = "ReportIssuesForm";
            this.reportIssuesPanel.ResumeLayout(false);
            this.reportIssuesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportIssuesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox issuesRichTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mediaBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox estimatedResolutionTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.TextBox locationTxtBox;
    }
}