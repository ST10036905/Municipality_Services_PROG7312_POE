namespace Municipality_Services_PROG7321_POE
{
    partial class AddEventForm
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
            this.addEventPanel = new System.Windows.Forms.Panel();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.mediaBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.eventsUserControl1 = new Municipality_Services_PROG7321_POE.EventsUserControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRecommendation = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.vbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.btnUpCommingEvents = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEventPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEventPanel
            // 
            this.addEventPanel.Controls.Add(this.flowLayoutPanel1);
            this.addEventPanel.Controls.Add(this.informationPanel);
            this.addEventPanel.Controls.Add(this.filePathTxt);
            this.addEventPanel.Controls.Add(this.progressBar);
            this.addEventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEventPanel.Location = new System.Drawing.Point(0, 0);
            this.addEventPanel.Name = "addEventPanel";
            this.addEventPanel.Size = new System.Drawing.Size(1321, 750);
            this.addEventPanel.TabIndex = 0;
            // 
            // filePathTxt
            // 
            this.filePathTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filePathTxt.BackColor = System.Drawing.Color.White;
            this.filePathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTxt.ForeColor = System.Drawing.Color.Black;
            this.filePathTxt.Location = new System.Drawing.Point(1002, 492);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(331, 33);
            this.filePathTxt.TabIndex = 38;
            // 
            // viewBtn
            // 
            this.viewBtn.AutoSize = true;
            this.viewBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(478, 404);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(167, 47);
            this.viewBtn.TabIndex = 37;
            this.viewBtn.Text = "View events";
            this.toolTip1.SetToolTip(this.viewBtn, "View added event");
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(676, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.toolTip1.SetToolTip(this.button1, "Go back to main window");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backBtn1_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(291, 403);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(165, 48);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.toolTip1.SetToolTip(this.Submit, "Submit the event");
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1321, 10);
            this.progressBar.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.informationPanel.Controls.Add(this.panel1);
            this.informationPanel.Controls.Add(this.button1);
            this.informationPanel.Controls.Add(this.viewBtn);
            this.informationPanel.Controls.Add(this.label8);
            this.informationPanel.Controls.Add(this.pictureBox);
            this.informationPanel.Controls.Add(this.Submit);
            this.informationPanel.Controls.Add(this.locationListBox);
            this.informationPanel.Controls.Add(this.mediaBtn);
            this.informationPanel.Controls.Add(this.dateTimePicker);
            this.informationPanel.Controls.Add(this.descriptionRichTxtBox);
            this.informationPanel.Controls.Add(this.categoryListBox);
            this.informationPanel.Controls.Add(this.nameTxtBox);
            this.informationPanel.Controls.Add(this.label6);
            this.informationPanel.Controls.Add(this.label7);
            this.informationPanel.Controls.Add(this.label5);
            this.informationPanel.Controls.Add(this.label4);
            this.informationPanel.Controls.Add(this.label3);
            this.informationPanel.Controls.Add(this.label2);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationPanel.Location = new System.Drawing.Point(0, 10);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(1321, 461);
            this.informationPanel.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(359, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(391, 47);
            this.label8.TabIndex = 52;
            this.label8.Text = "Municipality Events";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(875, 113);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(349, 312);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 51;
            this.pictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox, "Event media will show here");
            // 
            // locationListBox
            // 
            this.locationListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 28;
            this.locationListBox.Items.AddRange(new object[] {
            "All provinces",
            "Gauteng",
            "Western Cape",
            "Eastern Cape",
            "Free State",
            "Kwazulu-Natal",
            "Limpopo",
            "Northern Cape",
            "North West",
            "Mpumalanga"});
            this.locationListBox.Location = new System.Drawing.Point(292, 268);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(519, 32);
            this.locationListBox.TabIndex = 50;
            this.toolTip1.SetToolTip(this.locationListBox, "Select a location for event");
            // 
            // mediaBtn
            // 
            this.mediaBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBtn.Location = new System.Drawing.Point(292, 313);
            this.mediaBtn.Name = "mediaBtn";
            this.mediaBtn.Size = new System.Drawing.Size(519, 32);
            this.mediaBtn.TabIndex = 49;
            this.toolTip1.SetToolTip(this.mediaBtn, "Attach a media for the event");
            this.mediaBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(292, 224);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(519, 22);
            this.dateTimePicker.TabIndex = 48;
            this.toolTip1.SetToolTip(this.dateTimePicker, "Select date and time");
            // 
            // descriptionRichTxtBox
            // 
            this.descriptionRichTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionRichTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionRichTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTxtBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionRichTxtBox.Location = new System.Drawing.Point(292, 359);
            this.descriptionRichTxtBox.Name = "descriptionRichTxtBox";
            this.descriptionRichTxtBox.Size = new System.Drawing.Size(519, 39);
            this.descriptionRichTxtBox.TabIndex = 47;
            this.descriptionRichTxtBox.Text = "";
            this.toolTip1.SetToolTip(this.descriptionRichTxtBox, "Enter description of event");
            // 
            // categoryListBox
            // 
            this.categoryListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 28;
            this.categoryListBox.Items.AddRange(new object[] {
            "Community meetings",
            "Festival",
            "Workshop",
            "Health and wellness",
            "Arts and culture",
            "Volunteer opportunities",
            "Holiday celebration",
            "Government Service",
            "Alerts"});
            this.categoryListBox.Location = new System.Drawing.Point(292, 164);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(519, 32);
            this.categoryListBox.TabIndex = 46;
            this.toolTip1.SetToolTip(this.categoryListBox, "Select the category that event falls in to");
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(292, 114);
            this.nameTxtBox.Multiline = true;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(519, 30);
            this.nameTxtBox.TabIndex = 45;
            this.toolTip1.SetToolTip(this.nameTxtBox, "Enter the name of event or announcement");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "Location : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "Event media : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Date/ time of event : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "Category of event :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Linen;
            this.flowLayoutPanel1.Controls.Add(this.eventsUserControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 477);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1321, 273);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // eventsUserControl1
            // 
            this.eventsUserControl1.BackColor = System.Drawing.Color.White;
            this.eventsUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventsUserControl1.EventCategory = null;
            this.eventsUserControl1.EventDescription = null;
            this.eventsUserControl1.EventImage = null;
            this.eventsUserControl1.EventLocation = null;
            this.eventsUserControl1.EventName = null;
            this.eventsUserControl1.EventTime = new System.DateTime(((long)(0)));
            this.eventsUserControl1.Location = new System.Drawing.Point(3, 3);
            this.eventsUserControl1.Name = "eventsUserControl1";
            this.eventsUserControl1.Size = new System.Drawing.Size(1318, 249);
            this.eventsUserControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnUpCommingEvents);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRecommendation);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 66);
            this.panel1.TabIndex = 53;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInput.Location = new System.Drawing.Point(4, 14);
            this.txtSearchInput.Multiline = true;
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(237, 37);
            this.txtSearchInput.TabIndex = 0;
            this.txtSearchInput.Text = "\r\n";
            this.toolTip1.SetToolTip(this.txtSearchInput, "Enter a text to search for event");
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(245, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRecommendation
            // 
            this.btnRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommendation.Location = new System.Drawing.Point(352, 14);
            this.btnRecommendation.Name = "btnRecommendation";
            this.btnRecommendation.Size = new System.Drawing.Size(185, 37);
            this.btnRecommendation.TabIndex = 2;
            this.btnRecommendation.Text = "Recommendation";
            this.btnRecommendation.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1009, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // vbFilter
            // 
            this.vbFilter.FormattingEnabled = true;
            this.vbFilter.Items.AddRange(new object[] {
            "Community meetings",
            "Festival",
            "Workshop",
            "Health and wellness",
            "Arts and culture",
            "Volunteer opportunities",
            "Holiday celebration",
            "Government Service",
            "Alerts"});
            this.vbFilter.Location = new System.Drawing.Point(58, 19);
            this.vbFilter.Name = "vbFilter";
            this.vbFilter.Size = new System.Drawing.Size(169, 24);
            this.vbFilter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter";
            // 
            // dateFilter
            // 
            this.dateFilter.Location = new System.Drawing.Point(231, 20);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(225, 22);
            this.dateFilter.TabIndex = 54;
            this.toolTip1.SetToolTip(this.dateFilter, "Select date and time");
            // 
            // btnUpCommingEvents
            // 
            this.btnUpCommingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpCommingEvents.Location = new System.Drawing.Point(1111, 15);
            this.btnUpCommingEvents.Name = "btnUpCommingEvents";
            this.btnUpCommingEvents.Size = new System.Drawing.Size(241, 37);
            this.btnUpCommingEvents.TabIndex = 55;
            this.btnUpCommingEvents.Text = "Upcoming Events";
            this.btnUpCommingEvents.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Controls.Add(this.dateFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.vbFilter);
            this.panel2.Location = new System.Drawing.Point(538, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 85);
            this.panel2.TabIndex = 55;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 750);
            this.Controls.Add(this.addEventPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.addEventPanel.ResumeLayout(false);
            this.addEventPanel.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addEventPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Button mediaBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTxtBox;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private EventsUserControl eventsUserControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRecommendation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vbFilter;
        private System.Windows.Forms.Button btnUpCommingEvents;
        private System.Windows.Forms.Panel panel2;
    }
}