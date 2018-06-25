using System;
using System.Collections.Generic;

namespace PRSystemSelfhost
{
    public class ClsRegion
    {
        public string RegionName { get; set; }
        public string RealtorName { get; set; }
        public string RealtorLocation { get; set; }
        public string RealtorPh { get; set; }

        public List<ClsAllProperties> PropertyList { get; set; }

        public override string ToString()
        {
            return RegionName;
        }

    }

    public class ClsAllProperties
    {
        public int PropertyId { get; set; }
        public string RegionName { get; set; }
        public string PropertyAddress { get; set; }
        public decimal PropertyPrice { get; set; }
        public string PropertyDesc { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsAvailable { get; set; }
        public string PropertyType { get; set; }
        public int? PropertyArea { get; set; }
        public decimal? RateableValue { get; set; }
        public string PropertyTerm { get; set; }
        public decimal? LetFee { get; set; }
        public string Furnishing { get; set; }

        public override string ToString()
        {
            return PropertyId + "\t";
        }

        public static readonly string FACTORY_PROMPT = "Enter R for Rent or S for Sale";

        public static ClsAllProperties NewProperty(string prChoice)
        {
            return new ClsAllProperties() { PropertyType = prChoice.ToUpper() };
        }
        
    }

    public class ClsEnquire
    {
        public int EnquireId { get; set; }
        public string PropertyAddress { get; set; }
        public string EnquireName { get; set; }
        public string EnquirePh { get; set; }
        public DateTime EnquireDate { get; set; }
        public decimal EnquirePrice { get; set; }

        public override string ToString()
        {
            return  EnquireName + "\t" + PropertyAddress;
        }
    }
}
