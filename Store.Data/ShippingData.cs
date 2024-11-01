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
    public class ShippingData
    {
        public static bool GetInfoShipping(int OrderID, ref int ShippingID, ref DateTime ShippingDate, ref string TrackingNumber,ref byte ShippingStatus,ref DateTime ExpectedDeliveryDate,ref DateTime? ActualDeliveryDate,ref int CompanyID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetInfoShipping", connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                ShippingID = (int)reader["ShippingID"];
                                ShippingDate = (DateTime)reader["ShippingDate"];
                                TrackingNumber = (string)reader["TrackingNumber"];
                                ShippingStatus = (byte)reader["ShippingStatus"];
                                ExpectedDeliveryDate = (DateTime)reader["ExpectedDeliveryDate"];
                                ActualDeliveryDate = (reader["ActualDeliveryDate"] == DBNull.Value)? null : (DateTime?)reader["ActualDeliveryDate"];
                                CompanyID = (int)reader["CompanyID"];
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
