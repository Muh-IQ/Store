using Store.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class frmPayment : Form
    {
        public Action OnDoneBuying;

        private DataTable _Products;
        private DataTable _Companies;

        // buying from Show Details
        private int _ProductID { get; set; }
        private string _NameProduct { get; set; }
        private int _Quantity { get; set; }
        private decimal _Price { get; set; }
        //

        private decimal _TotalPrice = 0;
        private decimal _TotalPriceOfProducts = 0;
        private decimal _DeliveryCost = 0;
        private int _ShippingCompanyID = 0;
        private DateTime _ExpectedDeliveryTime;
        public frmPayment()
        {
            InitializeComponent();
        }

        public void LoadProducts(DataTable Products)
        {
            this._Products = Products;
            foreach (DataRow Row in Products.Rows) 
            {
                flpProductsInfo.Controls.Add(_Generatectrl((string)Row["ProductName"], (int)Row["Quantity"], (decimal)Row["Price"]));
            }

        }
        public void LoadProduct(int ProductID, string Name, int Quantity, decimal Price)
        {
            _ProductID = ProductID;
            _NameProduct = Name;
            _Quantity = Quantity;
                _Price = Price;
                flpProductsInfo.Controls.Add(_Generatectrl(Name, Quantity, Price));
        }
     
        private ctrlProductInformation _Generatectrl(string Name , int  Quantity , decimal Price)
        {
            ctrlProductInformation ctrl = new ctrlProductInformation();
            ctrl.productName = Name;
            ctrl.Quantity = Quantity;
            ctrl.PriceOfOneProduct = Price;
            ctrl.TotalPrice = (Price * Quantity);
            return ctrl;
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblYourAddress.Text = Global.Customer.AddressInfo.FullAddress();
        }

        private void frmPayment_Shown(object sender, EventArgs e)
        {
           
            lblNumberOfProducts.Text = flpProductsInfo.Controls.Count.ToString();
            foreach (ctrlProductInformation item in flpProductsInfo.Controls)
            {
                _TotalPriceOfProducts += item.TotalPrice;
            }
            lblTotalPriceOfProducts.Text = _TotalPriceOfProducts.ToString("f2")+" $";

            _Companies = clsShippingCompany.GetAllShippingCompanyPerCountryID(Global.Customer.AddressInfo.CountryID);
            
            if (_Companies.Rows.Count < 1)
            {
                cbShippingCompany.Items.Add("Shipping Company");
                cbShippingCompany.SelectedIndex = 0;
                btnPay.Enabled = false;
                lblDeliveryNotSupported.Visible = true;
                return;
            }
            
            foreach (DataRow item in _Companies.Rows)
            {
                cbShippingCompany.Items.Add(item["CompanyName"]);
            }
            cbShippingCompany.SelectedIndex = 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Buying", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No) 
            {
                MessageBox.Show("Done Canceled");
                return;
            }

            // _Products From Basket
            if (_Products != null)
            {
                // buying from basket
                _BuyingForRange();
            }
            else 
            {
                // buying from Show Details
                _BuyingOfOneProduct();
            }

        }
        private void _BuyingForRange()
        {
            // Add a new buying record for the customer
            if (clsOrder.AddNewBuyingForRangeOfProduct((int)Global.Customer.CustomerID, _GenerateDataTableForBuy(_Products), ctrlPaymentMethod1.PaymentMethod,Global.Customer.AddressInfo.FullAddress(), _ExpectedDeliveryTime, _ShippingCompanyID))
            {
                // Display a success message
                MessageBox.Show("Your purchase has been made");


                //// Delete all cards for the current customer from the database
                //if (!clsCard.DeleteAllCardsForBuy((int)Global.Customer.CustomerID))
                //    MessageBox.Show("An error occurred clearing basket items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Raise Done Buying
                OnDoneBuying?.Invoke();

                this.Close();
            }
            else
            {
                // Display an error message
                MessageBox.Show("The purchase has not been completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _BuyingOfOneProduct()
        {
            // Add a new buying record for the customer
            if (clsOrder.AddNewBuyingOfProduct((int)Global.Customer.CustomerID, _ProductID,_Quantity,_Price, ctrlPaymentMethod1.PaymentMethod,Global.Customer.AddressInfo.FullAddress(), _ExpectedDeliveryTime, _ShippingCompanyID))
            {
                // Display a success message
                MessageBox.Show("Your purchase has been made");
                this.Close();
            }
            else
            {
                // Display an error message
                MessageBox.Show("The purchase has not been completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable _GenerateDataTableForBuy(DataTable Products)
        {
            DataTable _BuyCards = new DataTable();
            _BuyCards.Columns.Add("ProductID", typeof(int));
            _BuyCards.Columns.Add("Quantity", typeof(int));
            _BuyCards.Columns.Add("Price", typeof(decimal));
            _BuyCards.Columns.Add("CardID", typeof(int));

            foreach (DataRow item in _Products.Rows)
            {
                if ((int)item["Quantity"] > 0)
                {
                    _BuyCards.Rows.Add(item["ProductID"], item["Quantity"], item["Price"], item["CardID"]);
                }
            }
            return _BuyCards;
        }


        private void cbShippingCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in _Companies.Rows)
            {
                if (cbShippingCompany.SelectedItem == item["CompanyName"])
                {
                    _ShippingCompanyID = Convert.ToInt16(item["CompanyID"]);
                    lblExpectedDeliveryTime.Text = (_ExpectedDeliveryTime = DateTime.Now.AddDays(Convert.ToInt16(item["TheExpectedNumberOfDaysOfArrival"]))).ToShortDateString();
                    lblDeliveryCost.Text = ( _DeliveryCost = Convert.ToDecimal(item["DeliveryCost"])).ToString("f2") + " $";
                    lblTotalPrice.Text = (_DeliveryCost + _TotalPriceOfProducts).ToString("f2") + " $";
                    return; 
                }
            }
            
        }
    }
}
