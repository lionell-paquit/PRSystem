namespace PRSystemWinForm
{
    partial class PropertyForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioSale = new System.Windows.Forms.RadioButton();
            this.radioRent = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioNoAvailable = new System.Windows.Forms.RadioButton();
            this.radioYesAvailable = new System.Windows.Forms.RadioButton();
            this.txtDateMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPropertyDesc = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPropertyAddress = new System.Windows.Forms.TextBox();
            this.txtPropertyPrice = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 131);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 28);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 68);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(139, 28);
            this.btnOK.TabIndex = 57;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioSale);
            this.groupBox3.Controls.Add(this.radioRent);
            this.groupBox3.Location = new System.Drawing.Point(159, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 53);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioSale
            // 
            this.radioSale.AutoSize = true;
            this.radioSale.Location = new System.Drawing.Point(90, 21);
            this.radioSale.Name = "radioSale";
            this.radioSale.Size = new System.Drawing.Size(57, 21);
            this.radioSale.TabIndex = 1;
            this.radioSale.Text = "Sale";
            this.radioSale.UseVisualStyleBackColor = true;
            // 
            // radioRent
            // 
            this.radioRent.AutoSize = true;
            this.radioRent.Checked = true;
            this.radioRent.Location = new System.Drawing.Point(6, 21);
            this.radioRent.Name = "radioRent";
            this.radioRent.Size = new System.Drawing.Size(59, 21);
            this.radioRent.TabIndex = 0;
            this.radioRent.TabStop = true;
            this.radioRent.Text = "Rent";
            this.radioRent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNoAvailable);
            this.groupBox2.Controls.Add(this.radioYesAvailable);
            this.groupBox2.Location = new System.Drawing.Point(159, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 53);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioNoAvailable
            // 
            this.radioNoAvailable.AutoSize = true;
            this.radioNoAvailable.Location = new System.Drawing.Point(90, 21);
            this.radioNoAvailable.Name = "radioNoAvailable";
            this.radioNoAvailable.Size = new System.Drawing.Size(47, 21);
            this.radioNoAvailable.TabIndex = 1;
            this.radioNoAvailable.Text = "No";
            this.radioNoAvailable.UseVisualStyleBackColor = true;
            // 
            // radioYesAvailable
            // 
            this.radioYesAvailable.AutoSize = true;
            this.radioYesAvailable.Checked = true;
            this.radioYesAvailable.Location = new System.Drawing.Point(6, 21);
            this.radioYesAvailable.Name = "radioYesAvailable";
            this.radioYesAvailable.Size = new System.Drawing.Size(53, 21);
            this.radioYesAvailable.TabIndex = 0;
            this.radioYesAvailable.TabStop = true;
            this.radioYesAvailable.Text = "Yes";
            this.radioYesAvailable.UseVisualStyleBackColor = true;
            // 
            // txtDateMod
            // 
            this.txtDateMod.Location = new System.Drawing.Point(140, 83);
            this.txtDateMod.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateMod.Name = "txtDateMod";
            this.txtDateMod.Size = new System.Drawing.Size(226, 22);
            this.txtDateMod.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 70;
            this.label7.Text = "Date Modified";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(45, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Property Type";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(45, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Is Available";
            // 
            // txtPropertyDesc
            // 
            this.txtPropertyDesc.Location = new System.Drawing.Point(140, 184);
            this.txtPropertyDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyDesc.Multiline = true;
            this.txtPropertyDesc.Name = "txtPropertyDesc";
            this.txtPropertyDesc.Size = new System.Drawing.Size(226, 77);
            this.txtPropertyDesc.TabIndex = 65;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(23, 27);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 22);
            this.Label1.TabIndex = 63;
            this.Label1.Text = "Address";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Description";
            // 
            // txtPropertyAddress
            // 
            this.txtPropertyAddress.Location = new System.Drawing.Point(140, 23);
            this.txtPropertyAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyAddress.Name = "txtPropertyAddress";
            this.txtPropertyAddress.Size = new System.Drawing.Size(226, 22);
            this.txtPropertyAddress.TabIndex = 61;
            // 
            // txtPropertyPrice
            // 
            this.txtPropertyPrice.Location = new System.Drawing.Point(140, 53);
            this.txtPropertyPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyPrice.Name = "txtPropertyPrice";
            this.txtPropertyPrice.Size = new System.Drawing.Size(226, 22);
            this.txtPropertyPrice.TabIndex = 62;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(23, 56);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 22);
            this.Label2.TabIndex = 64;
            this.Label2.Text = "Price $";
            // 
            // PropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDateMod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPropertyDesc);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPropertyAddress);
            this.Controls.Add(this.txtPropertyPrice);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "PropertyForm";
            this.Text = "Property Details";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioSale;
        private System.Windows.Forms.RadioButton radioRent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioNoAvailable;
        private System.Windows.Forms.RadioButton radioYesAvailable;
        internal System.Windows.Forms.TextBox txtDateMod;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtPropertyDesc;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtPropertyAddress;
        internal System.Windows.Forms.TextBox txtPropertyPrice;
        internal System.Windows.Forms.Label Label2;
    }
}