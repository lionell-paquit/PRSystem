using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRSystemWinForm
{
    public sealed partial class MainForm : Form
    {
        private static readonly MainForm _Instance = new MainForm();

        public MainForm()
        {
            InitializeComponent();
        }
        public static MainForm Instance
        {
            get { return MainForm._Instance; }
        }
        public async void UpdateDisplay()
        {
            try
            {
                lstRegion.DataSource = null;
                lstRegion.DataSource = await ServiceClient.GetRegionNamesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding region list");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btnViewProp_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstRegion.SelectedItem);
            if (lcKey != null)
            {
                try
                {
                    RegionForm.Run(lcKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
            }
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            EnquiryForm enquiryForm = new EnquiryForm();
            enquiryForm.Run();
        }
    }
}
