using Store.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Global
    {              
        //Event: The customer information has been uploaded so that the information can be modified in the main form
        public static Action OnLoadCustomerData;
       
        public static clsCustomer Customer = null;
    }
}
