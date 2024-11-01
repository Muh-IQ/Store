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
    public class UserData
    {
        public static bool IsExistsEmail(string Email)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsExistsEmail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Email", Email);

                        SqlParameter parameterReturn = new SqlParameter()
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(parameterReturn);

                        command.ExecuteScalar();

                        int result = Convert.ToInt32(parameterReturn.Value);
                        
                        IsFound = result == 1;
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return IsFound;
        }

    }
}
