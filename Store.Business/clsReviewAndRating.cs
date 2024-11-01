using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsReviewAndRating
    {
        public enum _enMode { AddNew = 1, Update = 2 }
        public _enMode _EnMode = _enMode.AddNew;
        public int OrderItemID { get; set; }
        public int? RatingID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public string ReviewText { get; set; }
        public byte RatingScore { get; set; }

        private clsReviewAndRating(int orderItemID, int ratingID, int productID, int customerID, string reviewText, byte ratingScore)
        {
            OrderItemID = orderItemID;
            RatingID = ratingID;
            ProductID = productID;
            CustomerID = customerID;
            ReviewText = reviewText;
            RatingScore = ratingScore;
            _EnMode = _enMode.Update;
        }
        public clsReviewAndRating()
        {
             _EnMode = _enMode.AddNew;
        }
        public static clsReviewAndRating FindByOrderItemID(int orderItemID)
        {
            var Data = ReviewAndRatingData.GetReviewAndRatingByOrderItemID(orderItemID);
            if (Data.IsFound)
            {
                return new clsReviewAndRating(orderItemID, Data.RatingID, Data.ProductID, Data.CustomerID, Data.ReviewText, Data.RatingScore);
            }
            return null;
        }
        public static List<(byte RatingScore, string FullName, string ReviewText)> GetPageProductsComment(int ProductID, int PageNumber)
        {
            return ReviewAndRatingData.GetPageProductRating(ProductID, PageNumber);
        }

        private bool _AddNew()
        {
           return (this.RatingID = ReviewAndRatingData.AddNewReviewAndRating(ProductID,CustomerID,ReviewText,RatingScore,OrderItemID)) != null;
        }

        private bool _Update()
        {
            return ReviewAndRatingData.UpdateReviewAndRating((int)RatingID,ProductID, CustomerID, ReviewText, RatingScore, OrderItemID);
        }
        public bool Save()
        {
            switch (_EnMode)
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        _EnMode = _enMode.Update;
                        return true;
                    }
                    return false;
                case _enMode.Update:
                    return _Update();
                default:
                    return false;
            }

        }

        public bool DeleteReviewAndRating()
        {
            return ReviewAndRatingData.DeleteReviewAndRating((int)RatingID);
        }
        public static int GetCommentCountForProduct(int ProductID)
        {
            return ReviewAndRatingData.GetRatingCountForProduct(ProductID);
        }
    }
}
