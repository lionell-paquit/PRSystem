namespace PRSystemWinForm
{
    partial class EnquiryForm
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
            this.Label1 = new System.Windows.Forms.Label();
            this.lstEnquire = new System.Windows.Forms.ListBox();
            this.btnDelEnquiry = new System.Windows.Forms.Button();
            this.btnViewEnquiry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(25, 24);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Enquiry List";
            this.Label1.UseWaitCursor = true;
            // 
            // lstEnquire
            // 
            this.lstEnquire.FormattingEnabled = true;
            this.lstEnquire.ItemHeight = 16;
            this.lstEnquire.Location = new System.Drawing.Point(28, 82);
            this.lstEnquire.Name = "lstEnquire";
            this.lstEnquire.Size = new System.Drawing.Size(635, 212);
            this.lstEnquire.TabIndex = 28;
            this.lstEnquire.UseWaitCursor = true;
            // 
            // btnDelEnquiry
            // 
            this.btnDelEnquiry.Location = new System.Drawing.Point(385, 318);
            this.btnDelEnquiry.Name = "btnDelEnquiry";
            this.btnDelEnquiry.Size = new System.Drawing.Size(85, 40);
            this.btnDelEnquiry.TabIndex = 31;
            this.btnDelEnquiry.Text = "Delete";
            this.btnDelEnquiry.UseVisualStyleBackColor = true;
            this.btnDelEnquiry.UseWaitCursor = true;
            // 
            // btnViewEnquiry
            // 
            this.btnViewEnquiry.Location = new System.Drawing.Point(235, 318);
            this.btnViewEnquiry.Name = "btnViewEnquiry";
            this.btnViewEnquiry.Size = new System.Drawing.Size(85, 40);
            this.btnViewEnquiry.TabIndex = 30;
            this.btnViewEnquiry.Text = "View";
            this.btnViewEnquiry.UseVisualStyleBackColor = true;
            this.btnViewEnquiry.UseWaitCursor = true;
            this.btnViewEnquiry.Click += new System.EventHandler(this.btnViewEnquiry_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(235, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Address";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name";
            this.label3.UseWaitCursor = true;
            // 
            // EnquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelEnquiry);
            this.Controls.Add(this.btnViewEnquiry);
            this.Controls.Add(this.lstEnquire);
            this.Controls.Add(this.Label1);
            this.Name = "EnquiryForm";
            this.Text = "Enquire Form";
            this.Load += new System.EventHandler(this.EnquiryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox lstEnquire;
        private System.Windows.Forms.Button btnDelEnquiry;
        private System.Windows.Forms.Button btnViewEnquiry;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
    }
}