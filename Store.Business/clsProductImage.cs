using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsProductImage
    {
        private enum _enMode { AddNew = 1, Update = 2 }
        private _enMode _EnMode = _enMode.AddNew;
        public int ImageID { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }
        public clsProduct ProductInfo;
        public sbyte ImageOrder { get; set; }
        public clsProductImage()
        {
            _EnMode = _enMode.AddNew;
        }

        private clsProductImage(int imageID, string imageUrl, int productID, sbyte imageOrder)
        {
            ImageID = imageID;
            ImageUrl = imageUrl;
            ProductID = productID;
            ImageOrder = imageOrder;
            ProductInfo= clsProduct.Find(productID);
            _EnMode = _enMode.Update;
        }

        public static clsProductImage FindByProductID(int imageID)
        {
            int ProductID = -1; string imageUrl = string.Empty; sbyte ImageOrder = 1;
            if (ProductImageData.GetInfoProductImage( imageID, ref imageUrl, ref ProductID, ref ImageOrder))
            {
                return new clsProductImage(imageID, imageUrl, ProductID, ImageOrder);
            }
            return null;
        }
        public static DataTable GetAllProductImage(int ProductID)
        {
            return ProductImageData.GetAllProductImages(ProductID);           
        }
    }
}
