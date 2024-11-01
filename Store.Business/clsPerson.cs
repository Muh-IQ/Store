using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsPerson
    {
        private enum _enMode { AddNew = 1, Update = 2 };
        private _enMode _Mode;

        public int? PersonID { get; protected set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int RegionId { get; set; }

        public clsAddress AddressInfo { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        protected clsPerson()
        {
            PersonID = null;
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            RegionId = -1;

            _Mode = _enMode.AddNew;
        }

        protected clsPerson(int? personID, string firstName, string lastName, string phoneNumber, int regionId)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            RegionId = regionId;
            AddressInfo= clsAddress.FindByRegionID(regionId);
            _Mode = _enMode.Update;
        }




    }
}
