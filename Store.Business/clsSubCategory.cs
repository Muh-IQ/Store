using Store.Data;
using System.Collections.Generic;
using System.Data;


namespace Store.Business
{
    public class clsSubCategory
    {

        public static DataTable GetAllSubCategories(int MainCatecoryID)
        {
            return clsSubCategoryData.GetAllSubCategories(MainCatecoryID);
        }

    }
}
