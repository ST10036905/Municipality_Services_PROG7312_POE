namespace Municipality_Services_PROG7321_POE.WindowsForms
{
    partial class Reporting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mediaBtn = new System.Windows.Forms.Button();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.issuesRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estimatedResolutionTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.55026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.44974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.13609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.86391F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(328, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Municipality Report Issues";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(463, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Application form";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate.Location = new System.Drawing.Point(1099, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 31);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date :  ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.8254F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.1746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.locationTxtBox, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 148);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1191, 82);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(332, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location : ";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationTxtBox.BackColor = System.Drawing.Color.Silver;
            this.locationTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxtBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.locationTxtBox.Location = new System.Drawing.Point(332, 44);
            this.locationTxtBox.Multiline = true;
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(560, 35);
            this.locationTxtBox.TabIndex = 7;
            this.locationTxtBox.TextChanged += new System.EventHandler(this.locationTxtBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 765);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1195, 32);
            this.progressBar.TabIndex = 18;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.Tan;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backBtn.Location = new System.Drawing.Point(927, 429);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(230, 35);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.viewBtn.AutoSize = true;
            this.viewBtn.BackColor = System.Drawing.Color.Tan;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewBtn.Location = new System.Drawing.Point(33, 429);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(263, 35);
            this.viewBtn.TabIndex = 17;
            this.viewBtn.Text = "View applications";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox.Location = new System.Drawing.Point(967, 322);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 74);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.85969F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.14031F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.categoryListBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.issuesRichTxtBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.viewBtn, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.submitBtn, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.backBtn, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.filePathTxt, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.mediaBtn, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.estimatedResolutionTime, 1, 8);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.61468F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.38532F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1190, 499);
            this.tableLayoutPanel3.TabIndex = 2;
          
            // 
            // mediaBtn
            // 
            this.mediaBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mediaBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.mediaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBtn.ForeColor = System.Drawing.Color.Gray;
            this.mediaBtn.Location = new System.Drawing.Point(333, 259);
            this.mediaBtn.Name = "mediaBtn";
            this.mediaBtn.Size = new System.Drawing.Size(559, 38);
            this.mediaBtn.TabIndex = 12;
            this.mediaBtn.Text = "Click here to attach media (optional)";
            this.mediaBtn.UseVisualStyleBackColor = false;
            this.mediaBtn.Click += new System.EventHandler(this.mediaBtn_Click_1);
            // 
            // filePathTxt
            // 
            this.filePathTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.filePathTxt.BackColor = System.Drawing.Color.SlateGray;
            this.filePathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.filePathTxt.Location = new System.Drawing.Point(390, 356);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(445, 54);
            this.filePathTxt.TabIndex = 20;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitBtn.AutoSize = true;
            this.submitBtn.BackColor = System.Drawing.Color.Tan;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitBtn.Location = new System.Drawing.Point(497, 429);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(230, 35);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(333, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attach media : ";
            // 
            // issuesRichTxtBox
            // 
            this.issuesRichTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.issuesRichTxtBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.issuesRichTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesRichTxtBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.issuesRichTxtBox.Location = new System.Drawing.Point(333, 146);
            this.issuesRichTxtBox.Name = "issuesRichTxtBox";
            this.issuesRichTxtBox.Size = new System.Drawing.Size(559, 42);
            this.issuesRichTxtBox.TabIndex = 10;
            this.issuesRichTxtBox.Text = "";
            this.issuesRichTxtBox.TextChanged += new System.EventHandler(this.issuesRichTxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(333, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description of issue:";
            // 
            // categoryListBox
            // 
            this.categoryListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.categoryListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 28;
            this.categoryListBox.Items.AddRange(new object[] {
            "Sanitation",
            "Utilities",
            "Road Maintenance",
            "Public safety",
            "Others..."});
            this.categoryListBox.Location = new System.Drawing.Point(333, 37);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(559, 32);
            this.categoryListBox.TabIndex = 8;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.categoryListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(333, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Report category : ";
            // 
            // estimatedResolutionTime
            // 
            this.estimatedResolutionTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.estimatedResolutionTime.AutoSize = true;
            this.estimatedResolutionTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedResolutionTime.ForeColor = System.Drawing.SystemColors.Window;
            this.estimatedResolutionTime.Location = new System.Drawing.Point(612, 471);
            this.estimatedResolutionTime.Name = "estimatedResolutionTime";
            this.estimatedResolutionTime.Size = new System.Drawing.Size(0, 28);
            this.estimatedResolutionTime.TabIndex = 21;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1195, 797);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reporting";
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.Reporting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox issuesRichTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button mediaBtn;
        private System.Windows.Forms.Label estimatedResolutionTime;
    }
}