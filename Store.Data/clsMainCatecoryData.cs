using System;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Configuration;

namespace Store.Data
{
    public static class clsMainCatecoryData
    {
        public static DataTable GetAllMainCategories()
        {
            DataTable dataTable = new DataTable();
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllMainCategories", connection))
                    {
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
                Debug.WriteLine("GetAllMainCategories : " + ex.Message);
            }
            return dataTable;
        }

             
    }
}
