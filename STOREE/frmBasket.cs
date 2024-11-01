using Store.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class frmBasket : Form
    {

        // Event to notify subscribers when the basket is changed
        public event Action OnChangedBasket;

        // DataTables to hold card information
        private DataTable _Cards;
        private DataTable _BuyCards;

        public frmBasket()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            // Clear controls in the flow layout panel
            flpBasketProduct.Controls.Clear();

            // Get all cards for the current customer
            _Cards = clsCard.GetAllCards((int)Global.Customer.CustomerID);

            // Loop through each card and generate a control for it
            int index = 0;
            foreach (DataRow dr in _Cards.Rows)
            {

                flpBasketProduct.Controls.Add(_GenerateControl((string)dr["ProductName"], (string)dr["Description"], (decimal)dr["Price"], (int)dr["QuantityInStock"], (string)dr["ImageUrl"], (int)dr["Quantity"], (int)dr["ProductID"], (int)dr["CardID"]));
                index++;
            }
        }


        // Method to generate a control for a card
        private ctrlProductCard _GenerateControl(string ProductName, string Description, decimal Price, int QuantityInStock, string ImageUrl, int Quantity, int ProductID, int CardID)
        {
            ctrlProductCard card = new ctrlProductCard();
            Task.Run(() => { card.LoadData(ProductName, Description, Price, QuantityInStock, ImageUrl, Quantity, ProductID, CardID); });
            card.OnDelete += _DeleteControl;
            card.OnQuantityChanged += _CalculatePriceInAllControls;
            card.OnSelect += _FillListOfBuying;
            return card;
        }
        private void _FillListOfBuying(string ProductName,int ProductID,int Quantity,decimal Price, int CardID, bool IsChecked)
        {
            if (IsChecked && !_BuyCards.Rows.Contains(ProductID)) 
            {
                _BuyCards.Rows.Add(ProductName, ProductID, Quantity, Price, CardID);
            }
            else 
            {
                if (_BuyCards.Rows.Contains(ProductID))
                {
                    _BuyCards.Rows.Find(ProductID).Delete();
                }
            }
        }

        // Event handler for deleting a control (card) from the basket
        private void _DeleteControl(object sender, EventArgs e)
        {
            // Remove the control from the flow layout panel
            flpBasketProduct.Controls.Remove((ctrlProductCard)sender);

            // Recalculate the total price
            _CalculatePriceInAllControls(null, null);

            // Raise the OnChangedBasket event
            OnChangedBasket?.Invoke();
        }

        // Event handler for deleting all cards from the basket
        private void lblDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Detete all cards", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                MessageBox.Show("Done canceled");
                return;
            }
            
            // Delete all cards for the current customer from the database
            if (clsCard.DeleteAllCards((int)Global.Customer.CustomerID))
            {
                // Clear controls in the flow layout panel
                flpBasketProduct.Controls.Clear();

                // Reset the total price
                lblInfoCards.Text = $"Subtotal ({0} Item) :  {0.ToString("f2")} $";

                // Raise the OnChangedBasket event
                OnChangedBasket?.Invoke();
            }
        }

        // Method to calculate the total price of all controls (cards) in the basket
        private void _CalculatePriceInAllControls(object sender, EventArgs e)
        {
            int Count = flpBasketProduct.Controls.Count;
            decimal TotalPrice = 0;

                foreach (ctrlProductCard item in flpBasketProduct.Controls)
                {
                    
                        TotalPrice += item.TotalPrice;
                
                }

                lblInfoCards.Text = $"Subtotal ({Count} Item) :  {TotalPrice.ToString("f2")} $";
        }

        // Event handler for buying all cards in the basket
        private void lblBuyAllCards_Click(object sender, EventArgs e)
        {
            if (flpBasketProduct.Controls.Count > 0 && _BuyCards.Rows.Count < 1)
            {
                MessageBox.Show("Plz, choose products", "choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_BuyCards.Rows.Count < 1)
            {
                MessageBox.Show("The cart is empty or the products are not available", "Empty | Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open the payment form for the customer to complete the purchase
            frmPayment frm = new frmPayment();
            frm.LoadProducts(_BuyCards);
            frm.OnDoneBuying += _DeleteCardsForBuy;
            frm.ShowDialog();
        }

        // Shown event handler
        private void frmBasket_Shown_1(object sender, EventArgs e)
        {
            // Initialize the _BuyCards DataTable
            _BuyCards = new DataTable();
            _BuyCards.Columns.Add("ProductName", typeof(string));
            DataColumn idColumn = _BuyCards.Columns.Add("ProductID", typeof(int));
            _BuyCards.Columns.Add("Quantity", typeof(int)); 
            _BuyCards.Columns.Add("Price", typeof(decimal));
            _BuyCards.Columns.Add("CardID", typeof(int));
            _BuyCards.PrimaryKey = new DataColumn[] { idColumn };


            // Calculate the total price of all controls
            _CalculatePriceInAllControls(null, null);

            // Dispose _Cards DataTable and set it to null
            _Cards.Dispose();
            _Cards = null;
        }
        private void _DeleteCardsForBuy()
        {
            int Count = flpBasketProduct.Controls.Count;
                // Clear controls in the flow layout panel
                for (int i = (Count -1); i >= 0; i--)
                {
                    ctrlProductCard ctrl = ((ctrlProductCard)flpBasketProduct.Controls[i]);

                    if (ctrl.Quantity > 0 && _BuyCards.Rows.Contains(ctrl.ProductID))
                    {
                        flpBasketProduct.Controls.RemoveAt(i);
                    }
                }
                // Recalculate the total price
                _CalculatePriceInAllControls(null, null);

                // Raise the OnChangedBasket event
                OnChangedBasket?.Invoke();
        }
        private void lblSelectAllCards_Click(object sender, EventArgs e)
        {
            bool IsSelectAll = false;
            if (Convert.ToInt16(lblSelectAllCards.Tag) == 0)
            {
                IsSelectAll = true;
                lblSelectAllCards.Tag = 1;
                lblSelectAllCards.Text = "Un" + lblSelectAllCards.Text;
            }
            else
            {
                lblSelectAllCards.Tag = 0;
                lblSelectAllCards.Text = lblSelectAllCards.Text.Remove(0,2);
                IsSelectAll = false;
            }
            foreach (ctrlProductCard item in flpBasketProduct.Controls)
            {

                 item.Change_checkBoxOfSelectProduct(IsSelectAll);

            }
        }
    }
           
}

