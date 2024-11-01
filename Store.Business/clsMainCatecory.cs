
using System.Data;
using System.Threading.Tasks;
using Store.Data;

namespace Store.Business
{
    public static class clsMainCatecory
    {
        public static  DataTable GetAllMainCategories()
        {
            return  clsMainCatecoryData.GetAllMainCategories();
        }
    }
}
