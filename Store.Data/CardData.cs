using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Store.Data
{
    public class CardData
    {
        //addNew and Update
        public static int? AddNewCardAndUpdated(int ProductID ,int CustomerID,int Quantity)
        {
            int? CardID = null; ;      
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    // in this procedure there are add new and update if  exist Card for this product
                    using (SqlCommand command = new SqlCommand("SP_AddNewCard", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        SqlParameter outputIdParam = new SqlParameter("@CardID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                       

                        command.ExecuteNonQuery();
                        CardID = (int)command.Parameters["@CardID"].Value;
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return CardID;
        }
        public static bool UpdateQuantityCard(int CardID, int Quantity)
        {
            int? RowEffect = null; 

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateQuantityInCard", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CardID", CardID);

                        command.Parameters.AddWithValue("@Quantity", Quantity);

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
        public static DataTable GetAllCards( int CustomerID)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                 
                    using (SqlCommand command = new SqlCommand("SP_GetAllCardsByCustomerID", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.CommandType=CommandType.StoredProcedure;
                        using (SqlDataReader reader =  command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                table.Load(reader);
                            }
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                
            }
            return table;
        }
        public static bool DeleteCard(int CardID)
        {
            byte RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteCardByCardID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CardID", CardID);
                        RowsAffected = (byte)command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
            return RowsAffected > 0;
        }
        //public static bool DeleteAllCardsForBuy(int CustomerID)
        //{
        //    int RowsAffected = 0;
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand("SP_DeleteAllCardByCustomerIDForBuy", connection))
        //            {
        //                command.CommandType = CommandType.StoredProcedure;
        //                command.Parameters.AddWithValue("@CustomerID", CustomerID);
        //                RowsAffected = command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);

        //    }
        //    return RowsAffected > 0;
        //}
        public static bool DeleteAllCards(int CustomerID)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteAllCardByCustomerID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        RowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
            return RowsAffected > 0;
        }
        public static int? GetCountCards(int CustomerID) 
        {
            int? Count = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetCountCards", connection))
                    {
                                 command.Parameters.AddWithValue("@CustomerID", CustomerID);
                                 command.CommandType = CommandType.StoredProcedure;
                                 SqlParameter parameterout = new SqlParameter("@Count", SqlDbType.Int)
                                 {
                                     Direction = ParameterDirection.Output
                                 };
                                     command.Parameters.Add(parameterout);
                                     command.ExecuteNonQuery();

                                     Count = (int)command.Parameters["@Count"].Value;
                    }

                   
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
            return Count;
        }
    }
}
