namespace PRSystemWinForm
{
    partial class SaleForm
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
            this.txtRateableValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPropertyArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRateableValue
            // 
            this.txtRateableValue.Location = new System.Drawing.Point(140, 143);
            this.txtRateableValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtRateableValue.Name = "txtRateableValue";
            this.txtRateableValue.Size = new System.Drawing.Size(226, 22);
            this.txtRateableValue.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 72;
            this.label8.Text = "Rateable Value $";
            // 
            // txtPropertyArea
            // 
            this.txtPropertyArea.Location = new System.Drawing.Point(140, 113);
            this.txtPropertyArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyArea.Name = "txtPropertyArea";
            this.txtPropertyArea.Size = new System.Drawing.Size(226, 22);
            this.txtPropertyArea.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Property Area";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 405);
            this.Controls.Add(this.txtRateableValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPropertyArea);
            this.Controls.Add(this.label3);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPropertyArea, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtRateableValue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtRateableValue;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtPropertyArea;
        internal System.Windows.Forms.Label label3;
    }
}