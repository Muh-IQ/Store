using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    public class OrderData
    {
        public static int? AddNewOrder(int CustomerID,decimal TotalAmount)
        {
            int? OrderID = null; ;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CutomerID", CustomerID);
                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        SqlParameter outputIdParam = new SqlParameter("@OrderID",SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                        command.ExecuteNonQuery();
                        OrderID = (int)command.Parameters["@OrderID"].Value;
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return OrderID;
        }

        /// <summary>
        /// Adds a new buying record for a range of products to the database.
        /// </summary>
        /// <param name="CustomerID">The ID of the customer making the purchase.</param>
        /// <param name="Orders">The DataTable containing the orders information.</param>
        /// <param name="PaymentMethod">The payment method used for the purchase.</param>
        /// <returns>True if the buying record was successfully added; otherwise, false.</returns>
        public static bool AddNewBuyingForRangeOfProduct(int CustomerID, DataTable Orders, string PaymentMethod, string Address, DateTime ExpectedDeliveryDate, int CompanyID)
        {
            // Initialize a boolean flag indicating whether the operation was successful
            bool IsAdd = true;

            try
            {
                // Establish a connection to the database using the connection string specified in ConnectionSetting.ConnectionString
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SQL command object to execute the stored procedure "SP_AddNewBuyingForRangeOfProduct"
                    using (SqlCommand command = new SqlCommand("SP_AddNewBuyingForRangeOfProduct", connection))
                    {
                        // Specify that the command is a stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the stored procedure
                        command.Parameters.AddWithValue("@CustomerID", CustomerID); // CustomerID parameter
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod); // PaymentMethod parameter
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@ExpectedDeliveryDate", ExpectedDeliveryDate);
                        command.Parameters.AddWithValue("@CompanyID", CompanyID);

                        // Add a parameter for the DataTable Orders which will be passed as a structured parameter to the stored procedure
                        var param = command.Parameters.AddWithValue("@mytable", Orders);
                        param.SqlDbType = SqlDbType.Structured; // Specify the SqlDbType as Structured

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, set the IsAdd flag to false and write the exception details to the debug output
                IsAdd = false;
                Debug.WriteLine(ex);
            }

            // Return the IsAdd flag indicating whether the operation was successful
            return IsAdd;
        }







        /// <summary>
        /// Adds a new buying transaction of a product for a customer into the database.
        /// </summary>
        /// <param name="CustomerID">The ID of the customer making the purchase.</param>
        /// <param name="ProductID">The ID of the product being purchased.</param>
        /// <param name="Quantity">The quantity of the product being purchased.</param>
        /// <param name="Price">The price per unit of the product.</param>
        /// <param name="PaymentMethod">The payment method used for the purchase.</param>
        /// <returns>True if the transaction is successfully added; otherwise, false.</returns>
        public static bool AddNewBuyingOfProduct(int CustomerID, int ProductID, int Quantity, decimal Price, string PaymentMethod,string Address , DateTime ExpectedDeliveryDate,int CompanyID)
        {
            bool IsAdd = true; // Flag indicating whether the transaction was successfully added to the database

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open(); // Open the database connection

                    using (SqlCommand command = new SqlCommand("SP_AddNewBuyingOfProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Set the command type as stored procedure

                        // Set the stored procedure parameters
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@ExpectedDeliveryDate", ExpectedDeliveryDate);
                        command.Parameters.AddWithValue("@CompanyID", CompanyID);

                        command.ExecuteNonQuery(); // Execute the stored procedure
                    }
                }
            }
            catch (Exception ex)
            {
                IsAdd = false; // Set the flag to indicate the failure of adding the transaction
                Debug.WriteLine(ex); // Log any exceptions that occur during the process
            }

            return IsAdd; // Return the flag indicating the success or failure of the transaction addition
        }



        public static  DataTable GetPageInfoForOrderItemAndOrderAndPayment(int CustomerID, int PageNumber)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetPageInfoForOrderItemAndOrderAndPayment", connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", @CustomerID);
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader =  command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return dataTable;
        }


        public static bool GetInfoOrderByOrderID(int OrderID,ref int CustomerID, ref decimal TotalAmount, ref DateTime OrderDateTime,
            ref byte OrderStatus, ref int PaymentID,ref string Address)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetInfoOrderByOrderID", connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                CustomerID = (int)reader["CustomerID"];
                                OrderDateTime = (DateTime)reader["OrderDateTime"];
                                OrderStatus = (byte)reader["OrderStatus"];
                                PaymentID = (int)reader["PaymentID"];
                                Address = (string)reader["Address"];
                                TotalAmount = (decimal)reader["TotalAmount"];

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                Debug.WriteLine(ex.Message);
            }
            return IsFound;
        }


    }
}

