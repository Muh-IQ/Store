using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsOrder
    {
        private enum _enMode { AddNew =1 , Update =2}
        private _enMode _EnMode = _enMode.AddNew;

        public enum _enStatus { New =1, Complete = 2}

        public int? OrderID { get; set; }
        public int CustomerID { get; set; } 
        public int PaymentID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public decimal TotalAmount { get; set; }
        public _enStatus OrderStatus { get; set; }
        public string Address { get; set; }
        public clsOrder()
        {
             _EnMode = _enMode.AddNew;
        }

        private clsOrder(int? orderID, int customerID, int paymentID, DateTime orderDateTime
            , decimal totalAmount, _enStatus orderStatus, string address)
        {
            _EnMode = _enMode.Update;
            OrderID = orderID;
            CustomerID = customerID;
            PaymentID = paymentID;
            OrderDateTime = orderDateTime;
            TotalAmount = totalAmount;
            OrderStatus = orderStatus;
            Address = address;
        }

        public static clsOrder Find(int OrderID)
        {
            int CustomerID = 0, PaymentID = 0; DateTime OrderDateTime = DateTime.Now;
            byte OrderStatus = 0;   string Address = null; decimal TotalAmount = 0;

            bool Result = OrderData.GetInfoOrderByOrderID(OrderID, ref CustomerID,ref 
                TotalAmount, ref OrderDateTime, ref OrderStatus, ref PaymentID, ref Address);

            if (Result)
            {
                return new clsOrder((int)OrderID, CustomerID, PaymentID, OrderDateTime, TotalAmount,(_enStatus) OrderStatus, Address);
            }
            return null;
        }


        private bool _AddNew()
        {
            return (this.OrderID = OrderData.AddNewOrder(CustomerID, TotalAmount)) != null;
        }
        public bool Save()
        {
            switch (_EnMode) 
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        _EnMode = _enMode.Update;
                        return true;
                    }
                    return false;
                case _enMode.Update:
                    return true;
                default: 
                    return false;
            }

        }



        /// <summary>
        /// Adds a new buying record for a range of products to the database.
        /// </summary>
        /// <param name="CustomerID">The ID of the customer making the purchase.</param>
        /// <param name="Orders">The DataTable containing the orders information.</param>
        /// <param name="PaymentMethod">The payment method used for the purchase.</param>
        /// <returns>True if the buying record was successfully added; otherwise, false.</returns>
        public static bool AddNewBuyingForRangeOfProduct(int CustomerID, DataTable Orders, string PaymentMethod,string Address, DateTime ExpectedDeliveryDate, int CompanyID)
        {
            // Delegate the task of adding a new buying record for a range of products to the OrderData class
            // The OrderData class likely contains the implementation for adding buying records to the database
            return OrderData.AddNewBuyingForRangeOfProduct(CustomerID, Orders, PaymentMethod, Address, ExpectedDeliveryDate, CompanyID);
        }



        /// <summary>
        /// Adds a new buying transaction of a product for a customer.
        /// </summary>
        /// <param name="CustomerID">The ID of the customer making the purchase.</param>
        /// <param name="ProductID">The ID of the product being purchased.</param>
        /// <param name="Quantity">The quantity of the product being purchased.</param>
        /// <param name="Price">The price per unit of the product.</param>
        /// <param name="PaymentMethod">The payment method used for the purchase.</param>
        /// <returns>True if the transaction is successfully added; otherwise, false.</returns>
        public static bool AddNewBuyingOfProduct(int CustomerID, int ProductID, int Quantity, decimal Price, string PaymentMethod,string Address , DateTime ExpectedDeliveryDate, int CompanyID)
        {
            // Delegate the task of adding a new buying transaction to the OrderData class
            return OrderData.AddNewBuyingOfProduct(CustomerID, ProductID, Quantity, Price, PaymentMethod,Address, ExpectedDeliveryDate, CompanyID);
        }


        public static DataTable GetPageInfoForOrderItemAndOrderAndPayment(int CustomerID, int PageNumber)
        {
            return OrderData.GetPageInfoForOrderItemAndOrderAndPayment(CustomerID, PageNumber);
        }
    }
}
