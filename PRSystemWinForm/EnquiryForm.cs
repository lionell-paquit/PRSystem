using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRSystemWinForm
{
    public partial class EnquiryForm : Form
    {
        List<ClsEnquire> _Enquire = new List<ClsEnquire>();
        public EnquiryForm()
        {
            InitializeComponent();
        }

        public void Run()
        {
            ShowDialog();
        }
        private async void UpdateDisplay()
        {
            try
            {
                lstEnquire.DataSource = null;
                lstEnquire.DataSource = await ServiceClient.GetEnquiriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding enquiry list");
            }
        }

        private async void getPendingEnquiries()
        {
            lstEnquire.Items.Clear();
            List<ClsEnquire> enquireDetails = await ServiceClient.GetEnquiriesAsync();

        }

        private void EnquiryForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btnViewEnquiry_Click(object sender, EventArgs e)
        {
            string lcKey = Convert.ToString(lstEnquire.SelectedItem);
            EnquiryViewForm enquiryViewForm = new EnquiryViewForm();
            if (lcKey != null)
            {
                try
                {
                    enquiryViewForm.Run(lcKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
            }
        }
    }
}
