using System;

namespace PRSystemWinForm
{
    public sealed partial class SaleForm : PRSystemWinForm.PropertyForm
    {
        private static readonly SaleForm Instance = new SaleForm();
        public SaleForm()
        {
            InitializeComponent();
        }

        public static void Run(ClsAllProperties prSale)
        {
            Instance.SetDetails(prSale);
        }

        protected override void updateForm()
        {
            base.updateForm();
            ClsAllProperties lcProperty = (ClsAllProperties)_Property;
            txtPropertyArea.Text = lcProperty.PropertyArea.ToString();
            txtRateableValue.Text = lcProperty.RateableValue.ToString();
        }

        protected override void pushData()
        {
            base.pushData();
            ClsAllProperties lcProperty = (ClsAllProperties)_Property;
            lcProperty.PropertyArea = Convert.ToInt16(txtPropertyArea.Text);
            lcProperty.RateableValue = Convert.ToDecimal(txtRateableValue.Text);
        }
    }
}
