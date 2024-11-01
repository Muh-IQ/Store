using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsCustomer:clsUser
    {
        private enum _enMode { AddNew = 1, Update = 2 };
        private _enMode _Mode;
        public int? CustomerID { get; set; }
        public string Password { get; set; }
        public clsCustomer()
        {
            _Mode = _enMode.AddNew;
        }

        private clsCustomer(int? customerID, string password, int UserID, string Email, 
            _enTypeInhertance TypeInhertance, int? personID, string firstName, string lastName,
            string phoneNumber, int regionId):
            base(UserID, Email, TypeInhertance, personID,firstName, lastName, phoneNumber, regionId)
        {
            CustomerID = customerID;
            Password = password;
            this._Mode = _enMode.Update;
        }

        /// <summary>
        /// Finds a customer by their email and password and returns a customer object.
        /// </summary>
        /// <param name="Email">The email of the customer to find.</param>
        /// <param name="Password">The password of the customer to find.</param>
        /// <returns>Returns a clsCustomer object if the customer is found; otherwise, returns null.</returns>
        public static clsCustomer FindCustomerByEmailAndPassword(string Email, string Password)
        {
            int PersonID = 0, RegionID = 0, UserID = 0, CustomerID = 0;
            string FirstName = null, LastName = null, Phone = null;
            byte TypeInher = 0;

            bool Result = CustomerData.FindCustomerByEmailAndPassword(Email, Password, ref PersonID, ref FirstName,
                ref LastName, ref Phone, ref RegionID, ref UserID, ref TypeInher, ref CustomerID);

            if (Result)
            {
                return new clsCustomer(CustomerID, Password, UserID, Email, (_enTypeInhertance)TypeInher, PersonID, FirstName
                    , LastName, Phone, RegionID);
            }
            return null;
        }

        private bool _AddNew()
        {
            return (this.CustomerID = CustomerData.AddNewCustomer(FirstName, LastName, PhoneNumber, RegionId, Email, (byte)TypeInhertance, Password)) != null;  ;
        }

        private bool _Update()
        {
            return CustomerData.UpdateCustomer((int)PersonID,FirstName,LastName,PhoneNumber,RegionId,UserID,(int)CustomerID,Password);
        }


        public  bool Save()
        {
           switch (_Mode) 
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;
        }

    }


}
