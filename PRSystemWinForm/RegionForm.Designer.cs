namespace PRSystemWinForm
{
    partial class RegionForm
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRealtorPh = new System.Windows.Forms.Label();
            this.lblRealtorLocation = new System.Windows.Forms.Label();
            this.lblRealtorName = new System.Windows.Forms.Label();
            this.lblRegionName = new System.Windows.Forms.Label();
            this.lstProperty = new System.Windows.Forms.ListBox();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnEditProperty = new System.Windows.Forms.Button();
            this.btnDelProperty = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 85);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 20);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Office";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 56);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 20);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Realtor";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Region";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contact Ph";
            // 
            // lblRealtorPh
            // 
            this.lblRealtorPh.Location = new System.Drawing.Point(149, 113);
            this.lblRealtorPh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealtorPh.Name = "lblRealtorPh";
            this.lblRealtorPh.Size = new System.Drawing.Size(328, 20);
            this.lblRealtorPh.TabIndex = 26;
            // 
            // lblRealtorLocation
            // 
            this.lblRealtorLocation.Location = new System.Drawing.Point(149, 85);
            this.lblRealtorLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealtorLocation.Name = "lblRealtorLocation";
            this.lblRealtorLocation.Size = new System.Drawing.Size(328, 20);
            this.lblRealtorLocation.TabIndex = 25;
            // 
            // lblRealtorName
            // 
            this.lblRealtorName.Location = new System.Drawing.Point(149, 56);
            this.lblRealtorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealtorName.Name = "lblRealtorName";
            this.lblRealtorName.Size = new System.Drawing.Size(328, 20);
            this.lblRealtorName.TabIndex = 24;
            // 
            // lblRegionName
            // 
            this.lblRegionName.Location = new System.Drawing.Point(149, 26);
            this.lblRegionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.Size = new System.Drawing.Size(328, 20);
            this.lblRegionName.TabIndex = 23;
            // 
            // lstProperty
            // 
            this.lstProperty.FormattingEnabled = true;
            this.lstProperty.ItemHeight = 16;
            this.lstProperty.Location = new System.Drawing.Point(27, 194);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(613, 148);
            this.lstProperty.TabIndex = 27;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(85, 374);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(85, 40);
            this.btnAddProperty.TabIndex = 28;
            this.btnAddProperty.Text = "Add";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnEditProperty
            // 
            this.btnEditProperty.Location = new System.Drawing.Point(225, 374);
            this.btnEditProperty.Name = "btnEditProperty";
            this.btnEditProperty.Size = new System.Drawing.Size(85, 40);
            this.btnEditProperty.TabIndex = 29;
            this.btnEditProperty.Text = "Edit";
            this.btnEditProperty.UseVisualStyleBackColor = true;
            this.btnEditProperty.Click += new System.EventHandler(this.btnEditProperty_Click);
            // 
            // btnDelProperty
            // 
            this.btnDelProperty.Location = new System.Drawing.Point(365, 374);
            this.btnDelProperty.Name = "btnDelProperty";
            this.btnDelProperty.Size = new System.Drawing.Size(85, 40);
            this.btnDelProperty.TabIndex = 30;
            this.btnDelProperty.Text = "Delete";
            this.btnDelProperty.UseVisualStyleBackColor = true;
            this.btnDelProperty.Click += new System.EventHandler(this.btnDelProperty_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(286, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(80, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Available";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(505, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 40);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelProperty);
            this.Controls.Add(this.btnEditProperty);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.lstProperty);
            this.Controls.Add(this.lblRealtorPh);
            this.Controls.Add(this.lblRealtorLocation);
            this.Controls.Add(this.lblRealtorName);
            this.Controls.Add(this.lblRegionName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "RegionForm";
            this.Text = "Region Details";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblRealtorPh;
        internal System.Windows.Forms.Label lblRealtorLocation;
        internal System.Windows.Forms.Label lblRealtorName;
        internal System.Windows.Forms.Label lblRegionName;
        private System.Windows.Forms.ListBox lstProperty;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnEditProperty;
        private System.Windows.Forms.Button btnDelProperty;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
    }
}