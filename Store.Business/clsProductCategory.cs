using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsProductCategory
    {
        public static async Task<DataTable> GetAllProductCategory(int SubCategoryID)
        {
            return await ProductCategoryData.GetAllProductCategory(SubCategoryID);
        }
    }
}
