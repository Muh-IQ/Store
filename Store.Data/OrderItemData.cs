using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    public class OrderItemData
    {
        /// <summary>
        /// Retrieves information about a product based on its OrderItemID.
        /// </summary>
        /// <param name="OrderItemID">The unique identifier of the order item.</param>
        /// <returns>
        /// A tuple containing information about the product:
        /// - IsFound: Indicates whether the product was found in the database.
        /// - OrderID: The ID of the order to which the product belongs.
        /// - ProductID: The ID of the product.
        /// - Quantity: The quantity of the product ordered.
        /// - Price: The price of the product.
        /// - TotalPrice: The total price for the quantity of the product ordered.
        /// </returns>
        public static (bool IsFound, int OrderID, int ProductID, int Quantity, decimal Price, decimal TotalPrice) GetInfoProductByID(int OrderItemID)
        {
            bool IsFound = false;
            int OrderID = 0, ProductID = 0, Quantity = 0;
            decimal Price = 0, TotalPrice = 0;

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    // Prepare and execute the stored procedure
                    using (SqlCommand command = new SqlCommand("SP_GetOrderItemByOrderItemID", connection))
                    {
                        command.Parameters.AddWithValue("@OrderItemID", OrderItemID);
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        // Retrieve data from the database
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // If data is found, populate variables with retrieved values
                            if (reader.Read())
                            {
                                IsFound = true;
                                OrderID = (int)reader["OrderID"];
                                ProductID = (int)reader["ProductID"];
                                Quantity = (int)reader["Quantity"];
                                Price = (decimal)reader["Price"];
                                TotalPrice = (decimal)reader["TotalPrice"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and set IsFound to false
                IsFound = false;
                Debug.WriteLine(ex.Message);
            }

            // Return the retrieved information
            return (IsFound, OrderID, ProductID, Quantity, Price, TotalPrice);
        }


        public static int GetOrderItemCountForMyPurchases(int CustomerID)
        {
            int count = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetOrderItemCountForMyPurchases", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter = new SqlParameter("@CountRowOut", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(parameter);

                        command.ExecuteReader();

                        count = (int)command.Parameters["@CountRowOut"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); // Log any exceptions
            }
            return count;
        }
    }
}
