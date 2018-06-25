using System;
using System.Windows.Forms;

namespace PRSystemWinForm
{
    public partial class EnquiryViewForm : Form
    {
        private ClsEnquire _EnquiryDetail = new ClsEnquire();
        public EnquiryViewForm()
        {
            InitializeComponent();
        }
        public async void Run(string prEnquireId)
        {

            _EnquiryDetail = await ServiceClient.GetEnquiryDetailsAsync(prEnquireId);
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            lblEnquireName.Text = (string)_EnquiryDetail.EnquireName;
            lblPropAddress.Text = (string)_EnquiryDetail.PropertyAddress;
            lblContactPh.Text = (string)_EnquiryDetail.EnquirePh;
            lblEnquireDate.Text = _EnquiryDetail.EnquireDate.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
