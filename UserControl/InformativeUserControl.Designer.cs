namespace Municipality_Services_PROG7321_POE
{
    partial class InformativeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.callBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "The most efficient service portal delievered to you. ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report Issues: Quickly report any concerns like water outages,road \r\nrepairs, or " +
    "sanitation problems, and track the status of your request in real-time.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Requests: \r\nRequest municipal services with ease, from trash collection t" +
    "o utility assistance.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(815, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local Events Announcements: Stay informed about upcoming community events, \r\nanno" +
    "uncements, and important updates from your local government.";
            // 
            // callBtn
            // 
            this.callBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.callBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.callBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callBtn.ForeColor = System.Drawing.Color.White;
            this.callBtn.Location = new System.Drawing.Point(517, 356);
            this.callBtn.Name = "callBtn";
            this.callBtn.Size = new System.Drawing.Size(318, 56);
            this.callBtn.TabIndex = 4;
            this.callBtn.Text = "Call for action ";
            this.callBtn.UseVisualStyleBackColor = false;
            this.callBtn.Click += new System.EventHandler(this.callBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.callBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 466);
            this.panel1.TabIndex = 5;
            // 
            // InformativeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "InformativeUserControl";
            this.Size = new System.Drawing.Size(924, 466);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button callBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
