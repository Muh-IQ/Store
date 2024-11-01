using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsUser : clsPerson
    {
        private enum _enMode { AddNew = 1, Update = 2 };
        private _enMode _Mode;
        public enum _enTypeInhertance { Cusotmer = 1,Seller = 2 , owner = 3}
        public int UserID { get; set; }
        public string Email { get; set; }
        public _enTypeInhertance TypeInhertance { get; set; }
        public clsUser()
        {
            _Mode = _enMode.AddNew;
        }


        public static bool IsExistsEmail(string Email)
        {
            return UserData.IsExistsEmail(Email);
        }


        protected clsUser(int UserID, string Email, _enTypeInhertance TypeInhertance, int? personID, string firstName, string lastName, string phoneNumber, int regionId) : base(personID, firstName, lastName, phoneNumber, regionId)
        {
            _Mode = _enMode.Update;
            this.UserID = UserID;   
            this.Email = Email;
            this.TypeInhertance = TypeInhertance;

        }

        //public virtual bool Save()
        //{
        //    PersonID = 1;
        //    return false;
        //}

        //protected virtual bool _AddNew()
        //{
        //    return false;
        //}

        //protected virtual bool _Update()
        //{
        //    return false;
        //}

        //public static clsUser Get(int userId)
        //{
        //    return new clsUser();
        //}

        //public static bool Delete(int id)
        //{
        //    return false;
        //}

        //public static  DataTable GetAll()
        //{
        //    return new DataTable();
        //}

    }
}
