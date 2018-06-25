using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSystemSelfhost
{
    public class PRSystemController : System.Web.Http.ApiController
    {
        public List<string> GetRegionNames()
        {
            DataTable lcResult = ClsDbConnection.GetDataTable("SELECT RegionName FROM RegionInfo", null);
            List<string> lcRegionNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcRegionNames.Add((string)dr[0]);
            return lcRegionNames;
        }

        public ClsRegion GetRegion(string RegionName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("RegionName", RegionName);
            DataTable lcResult =
                ClsDbConnection.GetDataTable("SELECT * FROM RegionInfo WHERE RegionName = @RegionName", par);
            if (lcResult.Rows.Count > 0)
                return new ClsRegion()
                {
                    RegionName = (string)lcResult.Rows[0]["RegionName"],
                    RealtorName = (string)lcResult.Rows[0]["RealtorName"],
                    RealtorLocation = (string)lcResult.Rows[0]["RealtorLocation"],
                    RealtorPh = (string)lcResult.Rows[0]["ContactPh"],
                    PropertyList = getRegionProperties(RegionName)
                };
            else
                return null;
        }

        private List<ClsAllProperties> getRegionProperties(string RegionName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("RegionName", RegionName);
            DataTable lcResult = ClsDbConnection.GetDataTable
                ("SELECT * FROM PropertyInfo WHERE RegionName = @RegionName", par);
            List<ClsAllProperties> lcProperty = new List<ClsAllProperties>();
            foreach (DataRow dr in lcResult.Rows)
                lcProperty.Add(dataRow2AllProperties(dr));
            return lcProperty;
        }

        public List<ClsEnquire> GetEnquiries()
        {
            DataTable lcResult = ClsDbConnection.GetDataTable("SELECT * FROM Enquire INNER JOIN PropertyInfo " +
                "ON Enquire.PropertyId = PropertyInfo.PropertyId", null);
            List<ClsEnquire> lcEnquire= new List<ClsEnquire>();
            foreach (DataRow dr in lcResult.Rows)
                lcEnquire.Add( new ClsEnquire
                {
                    EnquireId = Convert.ToInt16(dr["EnquireId"]),
                    PropertyAddress = Convert.ToString(dr["PropertyAddress"]),
                    EnquireName = Convert.ToString(dr["EnquireName"]),
                    EnquirePh = Convert.ToString(dr["EnquirePh"]),
                    EnquirePrice = Convert.ToDecimal(dr["EnquirePrice"]),
                    EnquireDate = Convert.ToDateTime(dr["EnquireDate"])
                });
            return lcEnquire;
        }
        public ClsEnquire GetEnquiryDetails(string prEnquireId)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("EnquireId", prEnquireId);
            DataTable lcResult = ClsDbConnection.GetDataTable("SELECT * FROM Enquire INNER JOIN PropertyInfo " +
                "ON Enquire.PropertyId = PropertyInfo.PropertyId AND Enquire.EnquireId = @EnquireId", par);
            if (lcResult.Rows.Count > 0)
                return new ClsEnquire()
                {
                    EnquireId = Convert.ToInt16(lcResult.Rows[0]["EnquireId"]),
                    PropertyAddress = Convert.ToString(lcResult.Rows[0]["PropertyAddress"]),
                    EnquireName = Convert.ToString(lcResult.Rows[0]["EnquireName"]),
                    EnquirePh = Convert.ToString(lcResult.Rows[0]["EnquirePh"]),
                    EnquirePrice = Convert.ToDecimal(lcResult.Rows[0]["EnquirePrice"]),
                    EnquireDate = Convert.ToDateTime(lcResult.Rows[0]["EnquireDate"])
                };
            else
                return null;
        }

        public string PostProperty(ClsAllProperties prProperty)
        {
            try
            {
                int lcRecCount = ClsDbConnection.Execute("INSERT INTO PropertyInfo " +
                    "(RegionName, PropertyAddress, PropertyPrice, PropertyDescription, DateModified, IsAvailable, PropertyType, PropertyArea, RateableValue, PropertyTerm, LetFee, Furnishing)" +
                    "VALUES (@RegionName, @PropertyAddress, @PropertyPrice, @PropertyDesc, @DateModified, @IsAvailable, @PropertyType, @PropertyArea, @RateableValue, @PropertyTerm, @LetFee, @Furnishing)",
                    preparePropertyParameters(prProperty));
                if (lcRecCount == 1)
                    return "Property Added";
                else
                    return "Unexpected Property insert count" + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> preparePropertyParameters(ClsAllProperties prProperty)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(12);
            par.Add("RegionName", prProperty.RegionName);
            par.Add("PropertyAddress", prProperty.PropertyAddress);
            par.Add("PropertyPrice", prProperty.PropertyPrice);
            par.Add("PropertyDescription", prProperty.PropertyDesc);
            par.Add("DateModified", prProperty.DateModified);
            par.Add("IsAvailable", prProperty.IsAvailable);
            par.Add("PropertyType", prProperty.PropertyType);
            par.Add("PropertyArea", prProperty.PropertyArea);
            par.Add("RateableValue", prProperty.RateableValue);
            par.Add("PropertyTerm", prProperty.PropertyTerm);
            par.Add("LetFee", prProperty.LetFee);
            par.Add("Furnishing", prProperty.Furnishing);

            return par;
        }

        public string PutProperty(ClsAllProperties prProperty)
        {   // update
            try
            {
                int lcRecCount = ClsDbConnection.Execute("UPDATE PropertyInfo SET " +
                    "RegionName = @RegionName, PropertyAddress = @PropertyAddress, " +
                    "PropertyPrice = @PropertyPrice, PropertyDescription = @PropertyDesc, " +
                    "DateModified = @DateModified, IsAvailable = @IsAvailable, PropertyType = @PropertyType, " +
                    "PropertyArea = @PropertyArea, RateableValue = @RateableValue, PropertyTerm = @PropertyTerm, " +
                    "LetFee = @LetFee, Furnishing = @Furnishing " +
                    "WHERE PropertyId = @PropertyId",
                    preparePropertyParameters(prProperty));
                if (lcRecCount == 1)
                    return "One Property updated";
                else
                    return "Unexpected artist update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteProperty(string PropertyId)
        {
            try
            {
                int lcRecCount = ClsDbConnection.Execute(
                    "DELETE FROM PropertyInfo WHERE PropertyId = @PropertyId", preparePropertyDeletionParameters(PropertyId));
                if (lcRecCount == 1)
                    return "One Property Deleted";
                else
                    return "Unexpected property deletion count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }
        private Dictionary<string, object> preparePropertyDeletionParameters(string prPropertyId)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("PropertyId", prPropertyId);
            return par;
        }

        private ClsAllProperties dataRow2AllProperties(DataRow dr)
        {
            return new ClsAllProperties()
            {
                PropertyId = Convert.ToInt16(dr["PropertyId"]),
                RegionName = Convert.ToString(dr["RegionName"]),
                PropertyAddress = Convert.ToString(dr["PropertyAddress"]),
                PropertyPrice = Convert.ToDecimal(dr["PropertyPrice"]),
                PropertyDesc = dr["PropertyDesc"] is DBNull ? (string)null : Convert.ToString(dr["PropertyDesc"]),
                DateModified = Convert.ToDateTime(dr["DateModified"]),
                IsAvailable = Convert.ToBoolean(dr["IsAvailable"]),
                PropertyType = Convert.ToString(dr["PropertyType"]),
                PropertyArea = dr["PropertyArea"] is DBNull ? (int?)null : Convert.ToInt16(dr["PropertyArea"]),
                RateableValue = dr["RateableValue"] is DBNull ? (decimal?)null : Convert.ToDecimal(dr["RateableValue"]),
                PropertyTerm = dr["PropertyTerm"] is DBNull ? (string)null : Convert.ToString(dr["PropertyTerm"]),
                LetFee = dr["LetFee"] is DBNull ? (decimal?)null : Convert.ToDecimal(dr["LetFee"]),
                Furnishing = dr["Furnishing"] is DBNull ? (string)null : Convert.ToString(dr["Furnishing"]),
            };
        }

    }
}
