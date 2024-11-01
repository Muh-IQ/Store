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
    public class ShippingCompanyData
    {
        public static DataTable GetAllShippingCompanyPerCountryID(int CountryID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllShippingCompanyPerCountryID", connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);

                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
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

        public static bool GetInfoShippingCompany(int CompanyID, ref string CompanyName, ref string ShippingCompanyDetails)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetInfoShippingCompany", connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", CompanyID);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                CompanyName = (string)reader["CompanyName"];
                                ShippingCompanyDetails = (string)reader["ShippingCompanyDetails"];

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
