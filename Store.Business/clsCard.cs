using Store.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business
{
    public class clsCard
    {
        private enum _enMode { AddNew = 1, Update = 2 }
        private _enMode _EnMode = _enMode.AddNew;
        public int? CardID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Quantity { get; set; }
        public clsCard()
        {
            _EnMode = _enMode.AddNew;
        }

        private clsCard(int cardID, int productID, int customerID)
        {
            CardID = cardID;
            ProductID = productID;
            CustomerID = customerID;
            _EnMode = _enMode.Update;
        }

        private bool _AddNew()
        {
            return (this.CardID = CardData.AddNewCardAndUpdated(ProductID, CustomerID,Quantity)) != null;
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
                    return true;
                default:
                    return false;
            }

        }

        public static  DataTable GetAllCards(int customerID)
        {
            return  CardData.GetAllCards(customerID);
        }
        public static bool DeleteCard(int CardID)
        {
            return CardData.DeleteCard(CardID);
        }
        
        //public static bool DeleteAllCardsForBuy(int customerID)
        //{
        //    return CardData.DeleteAllCardsForBuy(customerID);
        //}
        public static bool DeleteAllCards(int customerID)
        {
            return CardData.DeleteAllCards(customerID);
        }

        public  bool UpdateQuantityCard(int Quantity)
        {
            return CardData.UpdateQuantityCard(ProductID, Quantity);
        }
        public static bool UpdateQuantityCard( int CardID, int Quantity)
        {
            return CardData.UpdateQuantityCard(CardID, Quantity);
        }
        public static int? GetCountCards(int CustomerID)
        {   
            return CardData.GetCountCards(CustomerID);
        }
    }
}
