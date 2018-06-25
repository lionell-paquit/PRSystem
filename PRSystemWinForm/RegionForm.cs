using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRSystemWinForm
{
    public partial class RegionForm : Form
    {
        private ClsRegion _Region;

        private static Dictionary<string, RegionForm> _RegionFormList =
            new Dictionary<string, RegionForm>();
        public RegionForm()
        {
            InitializeComponent();
        }

        public static void Run(string prRegionName)
        {
            RegionForm lcRegionForm;
            if (string.IsNullOrEmpty(prRegionName) ||
                !_RegionFormList.TryGetValue(prRegionName, out lcRegionForm))
            {
                lcRegionForm = new RegionForm();
                if (string.IsNullOrEmpty(prRegionName))
                    lcRegionForm.SetDetails(new ClsRegion());

                else
                {
                    _RegionFormList.Add(prRegionName, lcRegionForm);
                    lcRegionForm.refreshFormFromDB(prRegionName);
                }
            }
            else
            {
                lcRegionForm.Show();
                lcRegionForm.Activate();
            }
        }

        private async void refreshFormFromDB(string prRegionName)
        {
            try
            {
                SetDetails(await ServiceClient.GetRegionNamesAsync(prRegionName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(prRegionName + "\n" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void updateTitle(string prPropertyAddress)
        {
            if (!string.IsNullOrEmpty(prPropertyAddress))
                Text = "Region Details, " + prPropertyAddress;
        }

        private void UpdateDisplay()
        {
            try
            {
                lstProperty.DataSource = null;
                if (_Region.PropertyList != null)
                    lstProperty.DataSource = _Region.PropertyList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding property list");
            }
        }

        public void UpdateForm()
        {
            lblRegionName.Text = _Region.RegionName;
            lblRealtorName.Text = _Region.RealtorName;
            lblRealtorLocation.Text = _Region.RealtorLocation;
            lblRealtorPh.Text = _Region.RealtorPh;
        }

        public void SetDetails(ClsRegion prRegion)
        {
            _Region = prRegion;
            UpdateForm();
            UpdateDisplay();
            Show();
        }

        private void pushData()
        {
            _Region.RegionName = lblRegionName.Text;
            _Region.RealtorName = lblRealtorName.Text;
            _Region.RealtorLocation = lblRealtorLocation.Text;
            _Region.RealtorPh = lblRealtorPh.Text;
        }

        private async void btnAddProperty_Click(object sender, EventArgs e)
        {
            string lcReply = new InputBox(ClsAllProperties.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(lcReply)) // not cancelled?
            {
                ClsAllProperties lcProperty = ClsAllProperties.NewProperty(lcReply[0]);
                lcProperty.RegionName = _Region.RegionName;
                PropertyForm.DispatchPropertyForm(lcProperty);
                refreshFormFromDB(_Region.RegionName);
                MainForm.Instance.UpdateDisplay();
            }

        }

        private void btnEditProperty_Click(object sender, EventArgs e)
        {
            int lcKey = lstProperty.SelectedIndex;

            if (lcKey > 0)
                try
                {
                    RegionForm.Run(lstProperty.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private async void btnDelProperty_Click(object sender, EventArgs e)
        {
            int lcIndex = lstProperty.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting a Property", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeletePropertyAsync(lstProperty.SelectedItem as ClsAllProperties));
                refreshFormFromDB(_Region.RegionName);
                MainForm.Instance.UpdateDisplay();
            }
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pushData();
            //MessageBox.Show(await ServiceClient.UpdatePropertyAsync(_Region));
            Hide();
        }
    }
}
