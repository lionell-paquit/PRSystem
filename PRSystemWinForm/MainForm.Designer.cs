namespace PRSystemWinForm
{
    partial class MainForm
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
            this.lstRegion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewProp = new System.Windows.Forms.Button();
            this.btnEnquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRegion
            // 
            this.lstRegion.FormattingEnabled = true;
            this.lstRegion.ItemHeight = 16;
            this.lstRegion.Location = new System.Drawing.Point(32, 52);
            this.lstRegion.Name = "lstRegion";
            this.lstRegion.Size = new System.Drawing.Size(259, 260);
            this.lstRegion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Region List";
            // 
            // btnViewProp
            // 
            this.btnViewProp.Location = new System.Drawing.Point(312, 143);
            this.btnViewProp.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewProp.Name = "btnViewProp";
            this.btnViewProp.Size = new System.Drawing.Size(107, 39);
            this.btnViewProp.TabIndex = 10;
            this.btnViewProp.Text = "View Property";
            this.btnViewProp.Click += new System.EventHandler(this.btnViewProp_Click);
            // 
            // btnEnquiry
            // 
            this.btnEnquiry.Location = new System.Drawing.Point(312, 336);
            this.btnEnquiry.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnquiry.Name = "btnEnquiry";
            this.btnEnquiry.Size = new System.Drawing.Size(107, 39);
            this.btnEnquiry.TabIndex = 11;
            this.btnEnquiry.Text = "Enquiry List";
            this.btnEnquiry.Click += new System.EventHandler(this.btnEnquiry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 404);
            this.Controls.Add(this.btnEnquiry);
            this.Controls.Add(this.btnViewProp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRegion);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRegion;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnViewProp;
        internal System.Windows.Forms.Button btnEnquiry;
    }
}

