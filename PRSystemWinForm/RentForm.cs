using System;

namespace PRSystemWinForm
{
    public sealed partial class RentForm : PRSystemWinForm.PropertyForm
    {
        private static readonly RentForm Instance = new RentForm();
        public RentForm()
        {
            InitializeComponent();
        }

        public static void Run(ClsAllProperties prRent)
        {
            Instance.SetDetails(prRent);
        }

        protected override void updateForm()
        {
            base.updateForm();
            ClsAllProperties lcProperty = (ClsAllProperties)_Property;
            txtPropertyTerm.Text = lcProperty.PropertyTerm.ToString();
            txtLetFee.Text = lcProperty.LetFee.ToString();
            if (lcProperty.Furnishing == "F")
            {
                radioFully.Checked = true;
            }
            else if (lcProperty.Furnishing == "P")
            {
                radioPartial.Checked = true;
            }
            else
            {
                radioNone.Checked = true;
            }
            
        }

        protected override void pushData()
        {
            base.pushData();
            ClsAllProperties lcProperty = (ClsAllProperties)_Property;
            lcProperty.PropertyTerm = txtPropertyTerm.Text;
            lcProperty.LetFee = Convert.ToDecimal(txtLetFee.Text);
            if (radioFully.Checked == true)
            {
                lcProperty.Furnishing = "F";
            }
            else if (radioPartial.Checked == true)
            {
                lcProperty.Furnishing = "P";
            }
            else
            {
                lcProperty.Furnishing = "N";
            }
            
        }
    }
}
