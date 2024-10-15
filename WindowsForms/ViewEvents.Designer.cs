namespace Municipality_Services_PROG7321_POE.WindowsForms
{
    partial class ViewEvents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.eventsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsUserControl1 = new Municipality_Services_PROG7321_POE.EventsUserControl();
            this.panel1.SuspendLayout();
            this.eventsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 39);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(272, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(483, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "Our community updates on events";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // eventsPanel
            // 
            this.eventsPanel.AutoScroll = true;
            this.eventsPanel.Controls.Add(this.eventsUserControl1);
            this.eventsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventsPanel.Location = new System.Drawing.Point(0, 93);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(1049, 547);
            this.eventsPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtSearchInput);
            this.panel2.Controls.Add(this.searchListBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 58);
            this.panel2.TabIndex = 2;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(135, 26);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(224, 22);
            this.txtSearchInput.TabIndex = 5;
            // 
            // searchListBox
            // 
            this.searchListBox.AllowDrop = true;
            this.searchListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 28;
            this.searchListBox.Items.AddRange(new object[] {
            "Community meetings",
            "Festival",
            "Workshop",
            "Health and wellness",
            "Arts and culture",
            "Volunteer opportunities",
            "Holiday celebration",
            "Government Service",
            "Alerts"});
            this.searchListBox.Location = new System.Drawing.Point(659, 16);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(282, 32);
            this.searchListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // eventsUserControl1
            // 
            this.eventsUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsUserControl1.BackColor = System.Drawing.Color.White;
            this.eventsUserControl1.EventCategory = null;
            this.eventsUserControl1.EventDescription = null;
            this.eventsUserControl1.EventLocation = null;
            this.eventsUserControl1.EventName = null;
            this.eventsUserControl1.EventTime = new System.DateTime(((long)(0)));
            this.eventsUserControl1.Location = new System.Drawing.Point(3, 3);
            this.eventsUserControl1.Name = "eventsUserControl1";
            this.eventsUserControl1.Size = new System.Drawing.Size(1046, 287);
            this.eventsUserControl1.TabIndex = 0;
            // 
            // ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEvents";
            this.Load += new System.EventHandler(this.ViewEvents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.eventsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel eventsPanel;
        private EventsUserControl eventsUserControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchInput;
    }
}