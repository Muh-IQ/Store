using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Store.Data
{
    public class CustomerData
    {
        public static int? AddNewCustomer(string FirstName, string LastName, string PhoneNumber, int RegionId, string Email,byte TypeInhertance, string Password)
        {
            int? CustomerID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open(); // Open the database connection

                    using (SqlCommand command = new SqlCommand("SP_AddNewCustomerForAllData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Set the command type as stored procedure

                        // Set the stored procedure parameters
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Phone", PhoneNumber);
                        command.Parameters.AddWithValue("@RegionID", RegionId);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@TypeInher", TypeInhertance);
                        command.Parameters.AddWithValue("@Password", Password);
                        SqlParameter parameterOutput = new SqlParameter("@CustomerID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(parameterOutput);

                        command.ExecuteNonQuery(); // Execute the stored procedure\
                        Console.WriteLine();
                        //int x = (int)command.Parameters["@CustomerID"].Value;
                        CustomerID = (int?)command.Parameters["@CustomerID"].Value ?? null;

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex); // Log any exceptions that occur during the process
            }

            return CustomerID; 
        }

        public static bool UpdateCustomer(int PersonID ,string FirstName, string LastName, string PhoneNumber, int RegionId, int UserID, int CustomerID ,string Password)
        {
            bool IsUpdate = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open(); // Open the database connection

                    using (SqlCommand command = new SqlCommand("SP_UpdateCustomerForAllData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Set the command type as stored procedure

                        // Set the stored procedure parameters
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Phone", PhoneNumber);
                        command.Parameters.AddWithValue("@RegionID", RegionId);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        command.Parameters.AddWithValue("@Password", Password);
                        

                        IsUpdate =  command.ExecuteNonQuery() > 0; // Execute the stored procedure\
                       

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex); // Log any exceptions that occur during the process
            }

            return IsUpdate;
        }


        /// <summary>
        /// Finds a customer by their email and password in the database.
        /// </summary>
        /// <param name="Email">The email of the customer to find.</param>
        /// <param name="Password">The password of the customer to find.</param>
        /// <param name="PersonID">Output parameter for the person ID of the found customer.</param>
        /// <param name="FirstName">Output parameter for the first name of the found customer.</param>
        /// <param name="LastName">Output parameter for the last name of the found customer.</param>
        /// <param name="Phone">Output parameter for the phone number of the found customer.</param>
        /// <param name="RegionID">Output parameter for the region ID of the found customer.</param>
        /// <param name="UserID">Output parameter for the user ID of the found customer.</param>
        /// <param name="TypeInher">Output parameter for the type inheritance of the found customer.</param>
        /// <param name="CustomerID">Output parameter for the customer ID of the found customer.</param>
        /// <returns>Returns true if the customer is found; otherwise, false.</returns>
        public static bool FindCustomerByEmailAndPassword(string Email, string Password, ref int PersonID, ref string FirstName
               , ref string LastName, ref string Phone, ref int RegionID, ref int UserID, ref byte TypeInher, ref int CustomerID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindCustomerByEmailAndPassword", connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Password", Password);

                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Phone = (string)reader["Phone"];
                                RegionID = (int)reader["RegionID"];
                                UserID = (int)reader["UserID"];
                                TypeInher = (byte)reader["TypeInher"];
                                CustomerID = (int)reader["CustomerID"];

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
