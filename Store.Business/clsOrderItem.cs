using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsOrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public clsProduct ProductInfo { get; set; }
        public clsOrder OrderInfo { get; set; }
        public clsReviewAndRating ReviewAndRatingInfo { get; set; } 
        private clsOrderItem(int orderItemID, int orderID, int productID, int quantity, decimal price, decimal totalPrice)
        {
            OrderItemID = orderItemID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            Price = price;
            TotalPrice = totalPrice;
            OrderInfo = clsOrder.Find(orderID);
            ProductInfo = clsProduct.Find(productID);
            ReviewAndRatingInfo = clsReviewAndRating.FindByOrderItemID(orderItemID);
        }

        /// <summary>
        /// Finds an order item by its ID and returns a corresponding clsOrderItem object.
        /// </summary>
        /// <param name="orderItemID">The ID of the order item to find.</param>
        /// <returns>
        /// A clsOrderItem object representing the found order item, or null if the order item was not found.
        /// </returns>
        public static clsOrderItem Find(int orderItemID)
        {
            // Retrieve information about the product using the provided ID
            var DataInfo = OrderItemData.GetInfoProductByID(orderItemID);

            // Check if the product information was found
            if (DataInfo.IsFound)
            {
                // Create and return a new clsOrderItem object with the retrieved information
                return new clsOrderItem(orderItemID, DataInfo.OrderID, DataInfo.ProductID, DataInfo.Quantity, DataInfo.Price, DataInfo.TotalPrice);
            }

            // If the product information was not found, return null
            return null;
        }



        public static int GetOrderItemCountForMyPurchases(int CustomerID)
        {
            return OrderItemData.GetOrderItemCountForMyPurchases(CustomerID);
        }
    }
}
