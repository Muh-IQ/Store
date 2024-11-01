using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsShippingCompany
    {
        private enum _enMode { AddNew = 1, Update = 2 }
        private _enMode _EnMode = _enMode.AddNew;
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ShippingCompanyDetails { get; set; }

        private clsShippingCompany(int companyID, string companyName, string shippingCompanyDetails)
        {
            _EnMode = _enMode.Update;
            CompanyID = companyID;
            CompanyName = companyName;
            ShippingCompanyDetails = shippingCompanyDetails;
        }

        public static clsShippingCompany Find(int CompanyID)
        {
            string CompanyName = null, ShippingCompanyDetails = null;
            if (ShippingCompanyData.GetInfoShippingCompany(CompanyID, ref CompanyName, ref ShippingCompanyDetails))
            {
                return new clsShippingCompany(CompanyID, CompanyName, ShippingCompanyDetails);
            } 
            return null;
        }
        public static DataTable GetAllShippingCompanyPerCountryID(int CountryID)
        {
            return ShippingCompanyData.GetAllShippingCompanyPerCountryID(CountryID);
        }

       
    }
}
