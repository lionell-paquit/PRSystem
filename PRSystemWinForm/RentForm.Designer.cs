namespace PRSystemWinForm
{
    partial class RentForm
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
            this.txtPropertyTerm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLetFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioPartial = new System.Windows.Forms.RadioButton();
            this.radioFully = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPropertyTerm
            // 
            this.txtPropertyTerm.Location = new System.Drawing.Point(140, 113);
            this.txtPropertyTerm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyTerm.Name = "txtPropertyTerm";
            this.txtPropertyTerm.Size = new System.Drawing.Size(226, 22);
            this.txtPropertyTerm.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Term";
            // 
            // txtLetFee
            // 
            this.txtLetFee.Location = new System.Drawing.Point(140, 143);
            this.txtLetFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtLetFee.Name = "txtLetFee";
            this.txtLetFee.Size = new System.Drawing.Size(226, 22);
            this.txtLetFee.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 68;
            this.label8.Text = "Let Fee";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioNone);
            this.groupBox4.Controls.Add(this.radioPartial);
            this.groupBox4.Controls.Add(this.radioFully);
            this.groupBox4.Location = new System.Drawing.Point(159, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 53);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Location = new System.Drawing.Point(145, 19);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(63, 21);
            this.radioNone.TabIndex = 2;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // radioPartial
            // 
            this.radioPartial.AutoSize = true;
            this.radioPartial.Location = new System.Drawing.Point(70, 20);
            this.radioPartial.Name = "radioPartial";
            this.radioPartial.Size = new System.Drawing.Size(69, 21);
            this.radioPartial.TabIndex = 1;
            this.radioPartial.Text = "Partial";
            this.radioPartial.UseVisualStyleBackColor = true;
            // 
            // radioFully
            // 
            this.radioFully.AutoSize = true;
            this.radioFully.Checked = true;
            this.radioFully.Location = new System.Drawing.Point(6, 21);
            this.radioFully.Name = "radioFully";
            this.radioFully.Size = new System.Drawing.Size(58, 21);
            this.radioFully.TabIndex = 0;
            this.radioFully.TabStop = true;
            this.radioFully.Text = "Fully";
            this.radioFully.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(45, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 73;
            this.label9.Text = "Furnishing";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLetFee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPropertyTerm);
            this.Controls.Add(this.label3);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPropertyTerm, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtLetFee, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPropertyTerm;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtLetFee;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radioPartial;
        private System.Windows.Forms.RadioButton radioFully;
        internal System.Windows.Forms.Label label9;
    }
}