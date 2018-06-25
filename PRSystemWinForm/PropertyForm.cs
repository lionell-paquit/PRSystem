using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRSystemWinForm
{
    public partial class PropertyForm : Form
    {
        protected ClsAllProperties _Property;
        public delegate void LoadPropertyFormDelegate(ClsAllProperties prProperty);

        public PropertyForm()
        {
            InitializeComponent();
        }
        public static Dictionary<char, Delegate> _PropertiesForm = new Dictionary<char, Delegate>
            {
                {'R', new LoadPropertyFormDelegate(RentForm.Run) },
                {'S', null}
        };

        public static void DispatchPropertyForm(ClsAllProperties prProperty)
        {
            _PropertiesForm[prProperty.PropertyType].DynamicInvoke(prProperty);
        }

        public void SetDetails(ClsAllProperties prProperty)
        {
            _Property = prProperty;
            updateForm();
            ShowDialog();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                MessageBox.Show(await ServiceClient.UpdatePropertyAsync(_Property));
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtPropertyAddress.Text = _Property.PropertyAddress;
            txtPropertyPrice.Text = _Property.PropertyPrice.ToString();
            txtPropertyDesc.Text = _Property.PropertyDesc;
            txtDateMod.Text = _Property.DateModified.ToShortDateString();
            if(_Property.IsAvailable)
            {
                radioYesAvailable.Checked = true;
            }
            else
            {
                radioNoAvailable.Checked = true;
            }
            if (_Property.PropertyType == 'R')
            {
                radioRent.Checked = true;
            }
            else
            {
                radioSale.Checked = true;
            }
        }

        protected virtual void pushData()
        {
            _Property.PropertyAddress = txtPropertyAddress.Text;
            _Property.PropertyPrice = decimal.Parse(txtPropertyPrice.Text);
            _Property.PropertyDesc = txtPropertyDesc.Text;
            _Property.DateModified = DateTime.Parse(txtDateMod.Text);
            _Property.IsAvailable = (radioYesAvailable.Checked == true) ? true : false;
            _Property.PropertyType = (radioRent.Checked == true) ? 'R' : 'S';
        }
    }
}
