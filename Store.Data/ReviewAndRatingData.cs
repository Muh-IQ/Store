using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Configuration;

namespace Store.Data
{
    public class ReviewAndRatingData
    {
        public static List<(byte RatingScore, string FullName, string ReviewText)> GetPageProductRating(int ProductID, int PageNumber)
        {
            List<(byte RatingScore, string FullName, string ReviewText)> list = new List<(byte RatingScore, string FullName, string ReviewText)>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetPageProductRating", connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           
                            while (reader.Read())
                            {
                                byte RatingScore = (byte)reader["RatingScore"];
                                string FullName = (string)reader["FullName"];
                                string ReviewText = reader["ReviewText"] == DBNull.Value ? null : (string)reader["ReviewText"];
                                list.Add((RatingScore, FullName, ReviewText)); 
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return list;
        }

        public static int GetRatingCountForProduct(int ProductID)
        {
            int count = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetRatingCountForProduct", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@ProductID", ProductID);

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

        /// <summary>
        /// Retrieves review and rating information based on the OrderItemID.
        /// </summary>
        /// <param name="OrderItemID">The unique identifier of the order item.</param>
        /// <returns>
        /// A tuple containing review and rating information:
        /// - IsFound: Indicates whether the review and rating information was found in the database.
        /// - RatingID: The ID of the rating.
        /// - ProductID: The ID of the product associated with the rating.
        /// - CustomerID: The ID of the customer who provided the review and rating.
        /// - ReviewText: The text of the review.
        /// - RatingScore: The score given in the rating.
        /// </returns>
        public static (bool IsFound, int RatingID, int ProductID, int CustomerID, string ReviewText, byte RatingScore) GetReviewAndRatingByOrderItemID(int OrderItemID)
        {
            bool IsFound = false;
            int RatingID = 0, ProductID = 0, CustomerID = 0;
            string ReviewText = null;
            byte RatingScore = 0;

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    // Prepare and execute the stored procedure
                    using (SqlCommand command = new SqlCommand("SP_GetReviewAndRatingByOrderItemID", connection))
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
                                RatingID = (int)reader["RatingID"];
                                ProductID = (int)reader["ProductID"];
                                CustomerID = (int)reader["CustomerID"];
                                ReviewText = reader["ReviewText"] == DBNull.Value? null : (string)reader["ReviewText"];
                                RatingScore = (byte)reader["RatingScore"];
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
            return (IsFound, RatingID, ProductID, CustomerID, ReviewText, RatingScore);
        }


        public static int? AddNewReviewAndRating(int ProductID, int CustomerID,string ReviewText,byte RatingScore,int OrderItemID)
        {
            int? OrderID = null; ;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewReviewAndRating", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@RatingScore", RatingScore);
                        command.Parameters.AddWithValue("@OrderItemID", OrderItemID);

                        if (ReviewText == null)
                        {
                            command.Parameters.AddWithValue("@ReviewText", DBNull.Value );

                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ReviewText", ReviewText);

                        }
                        SqlParameter outputIdParam = new SqlParameter("@RatingID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                        command.ExecuteNonQuery();
                        OrderID = (int)command.Parameters["@RatingID"].Value;
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return OrderID;
        }

        public static bool UpdateReviewAndRating(int RatingID,int ProductID, int CustomerID, string ReviewText, byte RatingScore, int OrderItemID)
        {
            int RowEffect = 0; ;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateReviewAndRating", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        if (ReviewText == null)
                        {
                            command.Parameters.AddWithValue("@ReviewText", DBNull.Value);

                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ReviewText", ReviewText);

                        }
                        command.Parameters.AddWithValue("@RatingScore", RatingScore);
                        command.Parameters.AddWithValue("@OrderItemID", OrderItemID);
                        command.Parameters.AddWithValue("@RatingID", RatingID);

                        RowEffect = command.ExecuteNonQuery();
                       
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return RowEffect > 0;
        }

        public static bool DeleteReviewAndRating(int RatingID)
        {
            int RowEffect = 0; ;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteReviewAndRating", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RatingID", RatingID);
                        
                        RowEffect = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return RowEffect > 0;
        }

    }
}
