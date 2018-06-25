namespace PRSystemWinForm
{
    partial class EnquiryViewForm
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
            this.lblContactPh = new System.Windows.Forms.Label();
            this.lblPropAddress = new System.Windows.Forms.Label();
            this.lblEnquireName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblEnquireDate = new System.Windows.Forms.Label();
            this.lblEnquirePrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContactPh
            // 
            this.lblContactPh.Location = new System.Drawing.Point(186, 122);
            this.lblContactPh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactPh.Name = "lblContactPh";
            this.lblContactPh.Size = new System.Drawing.Size(85, 20);
            this.lblContactPh.TabIndex = 34;
            this.lblContactPh.Text = "Contact Ph";
            // 
            // lblPropAddress
            // 
            this.lblPropAddress.Location = new System.Drawing.Point(186, 82);
            this.lblPropAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropAddress.Name = "lblPropAddress";
            this.lblPropAddress.Size = new System.Drawing.Size(85, 20);
            this.lblPropAddress.TabIndex = 32;
            this.lblPropAddress.Text = "Address";
            // 
            // lblEnquireName
            // 
            this.lblEnquireName.Location = new System.Drawing.Point(186, 42);
            this.lblEnquireName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnquireName.Name = "lblEnquireName";
            this.lblEnquireName.Size = new System.Drawing.Size(85, 20);
            this.lblEnquireName.TabIndex = 31;
            this.lblEnquireName.Text = "Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(112, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Phone:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(41, 82);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(137, 20);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "Property Address:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(55, 42);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 20);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Enquirer Name:";
            // 
            // lblEnquireDate
            // 
            this.lblEnquireDate.Location = new System.Drawing.Point(185, 202);
            this.lblEnquireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnquireDate.Name = "lblEnquireDate";
            this.lblEnquireDate.Size = new System.Drawing.Size(85, 20);
            this.lblEnquireDate.TabIndex = 38;
            this.lblEnquireDate.Text = "Contact Ph";
            // 
            // lblEnquirePrice
            // 
            this.lblEnquirePrice.Location = new System.Drawing.Point(186, 162);
            this.lblEnquirePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnquirePrice.Name = "lblEnquirePrice";
            this.lblEnquirePrice.Size = new System.Drawing.Size(85, 20);
            this.lblEnquirePrice.TabIndex = 37;
            this.lblEnquirePrice.Text = "Office";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(63, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Enquired Date:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(61, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Enquired Price:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 40);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EnquiryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 354);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEnquireDate);
            this.Controls.Add(this.lblEnquirePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblContactPh);
            this.Controls.Add(this.lblPropAddress);
            this.Controls.Add(this.lblEnquireName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "EnquiryViewForm";
            this.Text = "Enquiry View Form";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblContactPh;
        internal System.Windows.Forms.Label lblPropAddress;
        internal System.Windows.Forms.Label lblEnquireName;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblEnquireDate;
        internal System.Windows.Forms.Label lblEnquirePrice;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
    }
}