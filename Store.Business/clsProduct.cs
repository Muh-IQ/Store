using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsProduct
    {
        // for only Function => GetPageProducts
        public  enum _enOrderBy { ProductID = 0, Price = 1 ,Rating = 2}
        public  enum _enSort { ASC = 0, DESC = 1 }

        private enum _enMode { AddNew=1 , Update=2}
        private _enMode _EnMode = _enMode.AddNew;
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public string ImageUrl { get; set; }

        public clsProduct()
        {
            
        }
        private clsProduct(int productID, string productName, string description, decimal price, int quantityInStock)
        {
            ProductID = productID;
            ProductName = productName;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            _EnMode = _enMode.Update;
            ImageUrl = GetImage();


        }

        public static clsProduct Find(int ProductID)
        {
            string productName = string.Empty, description = string.Empty;
            decimal price = 0; int quantityInStock = 0;
            if (ProductData.GetInfoProductByID(ProductID, ref productName, ref description, ref price, ref quantityInStock))
            {
                return new clsProduct(ProductID, productName, description, price, quantityInStock);
            }
            return null;
        }

        /// <summary>
        /// Retrieves products asynchronously based on the specified category ID, page number, order by criteria, and sort preference.
        /// </summary>
        /// <param name="ProductCategoryID">The ID of the product category to retrieve products for.</param>
        /// <param name="PageNumber">The page number of the results.</param>
        /// <param name="OrderBy">The criteria for ordering the results.</param>
        /// <param name="Sort">A boolean value indicating whether to sort the results.</param>
        /// <returns>A task representing the asynchronous operation that returns a DataTable containing the retrieved products.</returns>
        /// <remarks>
        /// This method connects to the database using the specified connection string, executes a stored procedure named "SP_GetPageProducts" with provided parameters, and loads the result into a DataTable asynchronously. Any encountered exceptions are logged using Debug.WriteLine.
        /// </remarks>

        public static async Task<DataTable> GetPageProductsWithBasicFilter(int ProductCategoryID, int PageNumber, _enOrderBy OrderBy, _enSort Sort)
        {   
            return await ProductData.GetPageProductsWithBasicFilter(ProductCategoryID, PageNumber, (short) OrderBy,Convert.ToBoolean( Sort));
        }


        /// <summary>
        /// Retrieves a DataTable of page products filtered by product name and price range.
        /// </summary>
        /// <param name="ProductCategoryID">The ID of the product category to filter by.</param>
        /// <param name="PageNumber">The page number of the results.</param>
        /// <param name="NameProduct">The name of the product to filter by.</param>
        /// <param name="PriceForm">The minimum price of the products to include in the result set.</param>
        /// <param name="PriceTo">The maximum price of the products to include in the result set.</param>
        /// <returns>A DataTable containing the filtered page products.</returns>
        /// <remarks>This method executes a stored procedure named 'SP_GetPageProductsWithNameAndPriceFilter' to fetch the data from the database.</remarks>
        public static async Task<DataTable> GetPageProductsWithManualFilter(int ProductCategoryID, int PageNumber, string NameProduct, decimal PriceForm, decimal PriceTo, int? Rating)
        {
            return await ProductData.GetPageProductsWithManualFilter(ProductCategoryID, PageNumber, NameProduct, PriceForm, PriceTo, Rating);
        }

        /// <summary>
        /// Retrieves the count per pages for a given product category ID.
        /// </summary>
        /// <param name="ProductCategoryID">The ID of the product category for which count per pages is needed.</param>
        /// <returns>The count per pages as an integer.</returns>
        public static int GetCountPerPages(int ProductCategoryID)
        {
            return ProductData.GetCountPerPages(ProductCategoryID);
        }

        /// <summary>
        /// Retrieves the count per pages for a given product category ID with manual filtering options.
        /// </summary>
        /// <param name="ProductCategoryID">The ID of the product category for which count per pages is needed.</param>
        /// <param name="NameProduct">The name of the product for filtering.</param>
        /// <param name="PriceForm">The minimum price for filtering.</param>
        /// <param name="PriceTo">The maximum price for filtering.</param>
        /// <returns>The count per pages as an integer.</returns>
        public static int GetCountPerPages(int ProductCategoryID, string NameProduct, decimal PriceForm, decimal PriceTo, int? Rating)
        {
            return ProductData.GetCountPerPagesWithManualFilter(ProductCategoryID, NameProduct, PriceForm, PriceTo, Rating);
        }

        public DataTable GetAllProductImage()
        {
            return ProductImageData.GetAllProductImages(this.ProductID);
        }
        public static DataTable GetAllProductImage(int ProductID)
        {
            return ProductImageData.GetAllProductImages(ProductID);
        }
        public string GetImage(byte ImageOrder = 1)
        {
            return ProductImageData.GetImageUrlByProductID(ProductID, ImageOrder);
        }

        public bool UpdateQuantityCard(int Quantity)
        {
            return CardData.UpdateQuantityCard(ProductID, Quantity);
        }

        public  List<(byte RatingScore, string FullName, string ReviewText)> GetPageProductRating(int PageNumber)
        {
            return ReviewAndRatingData.GetPageProductRating(this.ProductID, PageNumber);
        }

        public  int GetRatingCountForProduct()
        {
            return ReviewAndRatingData.GetRatingCountForProduct(this.ProductID);
        }



        /// <summary>
        /// Adds a new buying transaction of a product for a customer using the current instance's product details.
        /// </summary>
        /// <param name="CustomerID">The ID of the customer making the purchase.</param>
        /// <param name="Quantity">The quantity of the product being purchased.</param>
        /// <param name="PaymentMethod">The payment method used for the purchase.</param>
        /// <returns>True if the transaction is successfully added; otherwise, false.</returns>
        public bool AddNewBuyingOfProduct(int CustomerID, int Quantity, string PaymentMethod,string Address, DateTime ExpectedDeliveryDate, int CompanyID)
        {
            // Delegate the task of adding a new buying transaction to the OrderData class, using the product details from the current instance
            return OrderData.AddNewBuyingOfProduct(CustomerID, this.ProductID, Quantity, this.Price, PaymentMethod, Address, ExpectedDeliveryDate, CompanyID);
        }


        public static List<string> GetAllProductsName()
        {
            return ProductData.GetAllProductsName();
        }

        public static async Task<DataTable> GetTopRatedProducts()
        {
            return await ProductData.GetTopRatedProducts();
        }

        public static async Task<DataTable> GetPromotedProducts()
        {
            return await ProductData.GetPromotedProducts();
        }
    }
}
