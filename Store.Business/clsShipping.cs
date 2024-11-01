using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsShipping
    {
        private enum _enMode { AddNew = 1, Update = 2 }
        private _enMode _EnMode = _enMode.AddNew;
        public enum _enStatus { New = 1, Complete = 2 }
        public int ShippingID { get; set; }
        public int OrderID { get; set; }
        public DateTime ShippingDate { get; set; }
        public string TrackingNumber { get; set; }
        public _enStatus ShippingStatus { get; set; }
        public string ShippingStatusAsText 
        { 
            get
            {
                switch (ShippingStatus)
                {
                    case _enStatus.New:
                        return "New";
                    case _enStatus.Complete:
                        return "Complete";
                    default:
                        return "Nnknown";
                }
            }

        }
        public DateTime ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public int CompanyID { get; set; }
        public clsShippingCompany CompanyInfo { get; set; } 
        public clsShipping()
        {
            _EnMode = _enMode.AddNew;
        }

        public clsShipping(int shippingID, int orderID, DateTime shippingDate, string trackingNumber, _enStatus shippingStatus, DateTime expectedDeliveryDate, DateTime? actualDeliveryDate, int companyID)
        {
            _EnMode = _enMode.Update;
            ShippingID = shippingID;
            OrderID = orderID;
            ShippingDate = shippingDate;
            TrackingNumber = trackingNumber;
            ShippingStatus = shippingStatus;
            ExpectedDeliveryDate = expectedDeliveryDate;
            ActualDeliveryDate = actualDeliveryDate;
            CompanyID = companyID;
            CompanyInfo = clsShippingCompany.Find(companyID);
        }

        public static clsShipping FindByOrderID(int OrderID)
        {
            int  ShippingID = 0, CompanyID = 0;
            DateTime ShippingDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.UtcNow ;
            string TrackingNumber = null; byte ShippingStatus = 0;
            DateTime? ActualDeliveryDate= null;
            bool Result = ShippingData.GetInfoShipping(OrderID, ref ShippingID, ref ShippingDate, ref TrackingNumber, ref ShippingStatus, ref ExpectedDeliveryDate, ref ActualDeliveryDate, ref CompanyID);

            if (Result) 
            {
                return new clsShipping(ShippingID, OrderID, ShippingDate, TrackingNumber,(_enStatus) ShippingStatus, ExpectedDeliveryDate, ActualDeliveryDate, CompanyID);
            }
            return null;
        }
    }
}
