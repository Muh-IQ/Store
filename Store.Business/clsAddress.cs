using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsAddress
    {
        private enum _enMode { AddNew = 1, Update = 2 }
        private _enMode _EnMode = _enMode.AddNew;
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int RegionID { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public string FullAddress ()
        {
            return $"{CountryName} - {CityName} - {RegionName}";
        }
        public clsAddress()
        {
            _EnMode = _enMode.AddNew;
        }

        private clsAddress(int countryID, int cityID, int regionID, string CountryName, string CityName, string RegionName)
        {
            CountryID = countryID;
            CityID = cityID;
            RegionID = regionID;
            this.CountryName = CountryName;
            this.CityName = CityName;
            this.RegionName = RegionName;
            _EnMode = _enMode.Update;
        }

        public static clsAddress FindByRegionID(int regionID)
        {
            var Data =  AddressData.GetAddressDataByRegionID(regionID);
            if (Data.IsFound)
            {
                return new  clsAddress(Data.CountryID,Data.CityID,regionID, Data.CountryName, Data.CityName, Data.RegionName);
            }
            return null;
        }
        public static Dictionary<int, string> GetAllCountries()
        {
            return AddressData.GetAllCountries();
        }

        public static Dictionary<int, string> GetAllCities(int countryId)
        {
            return AddressData.GetAllCities(countryId);
        }

        public static Dictionary<int, string> GetAllRegions(int cityId)
        {
            return AddressData.GetAllRegions(cityId);
        }
    }
}
