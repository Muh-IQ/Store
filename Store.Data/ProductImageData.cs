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
    public class ProductImageData
    {
        public static DataTable GetAllProductImages(int ProductID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllProductImageByProductID", connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);
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
        public static bool GetInfoProductImage( int ImageID, ref string ImageUrl , ref int ProductID, ref sbyte ImageOrder)
        {
            bool IsFound =false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetInfoImageByImageID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ImageID", @ImageID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                ImageID = (int)reader["ImageID"];
                                ImageUrl = (string)reader["ImageUrl"];
                                ProductID = (int)reader["ProductID"];
                                ImageOrder = (sbyte)reader["ImageOrder"];
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;

                Debug.WriteLine(ex);
            }
            return IsFound;
        }
        public static string GetImageUrlByProductID(int ProductID,  byte ImageOrder)
        {
            string ImageUrl = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetImageUrlProductID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@Order", ImageOrder);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ImageUrl = (string)reader["ImageUrl"];

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return ImageUrl;
        }

    }
}
