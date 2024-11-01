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
    public class AddressData
    {
        public static (bool IsFound, int CountryID, int CityID, string CountryName, string CityName, string RegionName) GetAddressDataByRegionID(int RegionID)
        {
            bool IsFound = false;
            int CountryID = 0, CityID = 0;
            string CountryName = null,  CityName = null,  RegionName = null;
            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    // Prepare and execute the stored procedure
                    using (SqlCommand command = new SqlCommand("SP_GetAddressDataByRegionID", connection))
                    {
                        command.Parameters.AddWithValue("@RegionID", RegionID);
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        // Retrieve data from the database
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // If data is found, populate variables with retrieved values
                            if (reader.Read())
                            {
                                IsFound = true;
                                CountryID = (int)reader["CountryID"];
                                CityID = (int)reader["CityID"];
                                CountryName = (string)reader["CountryName"];
                                CityName = (string)reader["CityName"];
                                RegionName = (string)reader["RegionName"];
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
            return (IsFound, CountryID, CityID,CountryName,CityName,RegionName);
        }


        public static Dictionary<int, string> GetAllCountries()
        {
           Dictionary<int , string> DicData = new Dictionary<int , string>();
           
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllCountries", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                DicData.Add((int)reader["CountryID"], (string)reader["CountryName"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return DicData;
        }

        public static Dictionary<int, string> GetAllCities(int countryId)
        {
            Dictionary<int, string> DicData = new Dictionary<int, string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllCitiesPerCountryID", connection))
                    {
                        command.Parameters.AddWithValue("@CountryId", countryId);

                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DicData.Add((int)reader["CityID"], (string)reader["CityName"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return DicData;
        }

        public static Dictionary<int, string> GetAllRegions(int cityId)
        {
            Dictionary<int, string> DicData = new Dictionary<int, string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSetting.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllRegionsPerCityID", connection))
                    {
                        command.Parameters.AddWithValue("@CityID", cityId);

                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DicData.Add((int)reader["RegionID"], (string)reader["RegionName"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
            return DicData;
        }


    }
}
