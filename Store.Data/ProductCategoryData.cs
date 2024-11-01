using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    public class ProductCategoryData
    {
        public static async Task<DataTable> GetAllProductCategory(int SubCategoryID)
        {
            DataTable dataTable = new DataTable();

            
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();  
                    using (SqlCommand command = new SqlCommand("SP_GetAllProductCategories", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SubCategoryID", SubCategoryID);
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

                Debug.WriteLine($"An Error occurred in GetAllProductCategory : {ex.Message}");
            }
            return dataTable;
        }
    }
}
