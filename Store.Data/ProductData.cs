using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.Data
{
    public class ProductData
    {
        public static bool GetInfoProductByID(int ProductID,ref string ProductName, ref string Description, ref decimal Price, ref int QuantityInStock)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetInfoProductByID", connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound =true;
                                ProductName = (string)reader["ProductName"];
                                Description = (string)reader["Description"];
                                Price = (decimal)reader["Price"];
                                QuantityInStock = (int)reader["QuantityInStock"];
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
        public static async Task<DataTable> GetPageProductsWithBasicFilter(int ProductCategoryID,int PageNumber, short OrderBy, bool Sort)
        {
			 DataTable dataTable = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand("SP_GetPageProductsWithBasicFilter", connection))
					{
						command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        command.Parameters.AddWithValue("@OrderBy", OrderBy);
                        command.Parameters.AddWithValue("@Sort", Sort);
                        command.CommandType = CommandType.StoredProcedure;
						using (SqlDataReader reader = await command.ExecuteReaderAsync())
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
        public static async Task<DataTable> GetPageProductsWithManualFilter(int ProductCategoryID, int PageNumber, string NameProduct, decimal PriceForm, decimal PriceTo,int? Rating)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetPageProductsWithManualFilter", connection))
                    {
                        command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        command.Parameters.AddWithValue("@NameProduct", NameProduct);
                        command.Parameters.AddWithValue("@PriceForm", PriceForm);
                        command.Parameters.AddWithValue("@PriceTo", PriceTo);

                        command.Parameters.AddWithValue("@Rating", @Rating);

                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
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
        

        public static int GetCountPerPages(int ProductCategoryID)
        {
            decimal Count = 0; // Initialize count to 0

            try
            {
                // Establish database connection
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    // Prepare SQL command
                    using (SqlCommand command = new SqlCommand("SP_GetCountPerPages", connection))
                    {
                        command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID); // Set parameter value
                        command.CommandType = CommandType.StoredProcedure; // Set command type to stored procedure

                        connection.Open(); // Open database connection

                        // Execute command and read result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there is a result
                            {
                                Count = (decimal)reader["Result"]; // Get the count per pages
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); // Log any exceptions
            }

            return (int)Count; // Return count per pages as an integer
        }

        public static int GetCountPerPagesWithManualFilter(int ProductCategoryID,  string NameProduct, decimal PriceForm, decimal PriceTo, int? Rating)
        {
            decimal Count = 0; // Initialize count to 0

            try
            {
                // Establish database connection
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    // Prepare SQL command
                    using (SqlCommand command = new SqlCommand("SP_GetCountPerPagesWithManualFilter", connection))
                    {
                        connection.Open(); // Open database connection

                        // Set command parameters
                        command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                        command.Parameters.AddWithValue("@NameProduct", NameProduct);
                        command.Parameters.AddWithValue("@PriceForm", PriceForm);
                        command.Parameters.AddWithValue("@PriceTo", PriceTo);
                        command.Parameters.AddWithValue("@Rating", Rating);

                        command.CommandType = CommandType.StoredProcedure;

                        // Create an output parameter to retrieve the count
                        SqlParameter CountRowOut = new SqlParameter("@CountRowOut", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        // Add the output parameter to the command
                        command.Parameters.Add(CountRowOut);

                        // Execute the command
                        command.ExecuteReader();

                        // Get the count from the output parameter
                        Count = (int)command.Parameters["@CountRowOut"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); // Log any exceptions
            }

            return (int)Count; // Return count per pages as an integer
        }


        public static List<string> GetAllProductsName()
        {
            List<string> productsName = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllProductsName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        productsName = new List<string>();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productsName.Add((string)reader["ProductName"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return productsName;
        }

        public static async Task<DataTable> GetTopRatedProducts()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetTopRatedProducts", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
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

        public static async Task<DataTable> GetPromotedProducts()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetPromotedProducts", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
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
    }
}
