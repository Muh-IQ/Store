using Guna.UI2.WinForms;
using Store.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    
    public partial class ctrlProductCard : UserControl
    {
        public event EventHandler OnDelete;
        public event EventHandler OnQuantityChanged;
        public Action<string,int ,int ,decimal, int, bool> OnSelect;

        private bool _IsChanged { get; set; } = false;
        public int Quantity { get; set; }
        private int _CardID { get; set; }
        private decimal _Price { get; set; }
        private decimal _TotalPrice { get; set; }
        private int _MaxQuantity { get; set; }
        public int ProductID { get; set; }
        public decimal TotalPrice
        {
            get
            { return _TotalPrice; }
        }
  
        private int SelectedQuantity 
        {
            get { return Quantity; }
            set 
            {
                Quantity = value;
                if (Quantity > _MaxQuantity || Quantity == 0)
                {
                    //MessageBox.Show($"This {lbName.Text} quantity maximume is{_MaxQuantity} ");
                    lblUnavailable.Visible = true;
                    lbProductQuantity.Text = (Quantity = _MaxQuantity).ToString();
                }
                else
                    lbProductQuantity.Text = Quantity.ToString();
            }
        }
        public ctrlProductCard()
        {
            InitializeComponent();
        }
       
        public void LoadData(string ProductName, string Description, decimal Price, int QuantityInStock, string ImageUrl, int SelectedQuantity, int ProductID, int CardID )
        {
            _MaxQuantity = QuantityInStock; ;
            _Price = Price;

            _TotalPrice = SelectedQuantity * _Price;

            //Calculate the number of the product, multiply the price, display it, and store it in _TotalPrice
            lblProductPrice.Text = (SelectedQuantity > 0) ? (_TotalPrice ).ToString("f2") + "$" : (_TotalPrice = _Price).ToString("f2") + "$";

            lbName.Text = ProductName.Trim();
            this.SelectedQuantity = SelectedQuantity;
            this._CardID = CardID;
            this.ProductID = ProductID;
            lbDescription.Text = Description.Trim();

            pbImage.Load(ImageUrl);

        }
     
        private void lblDelete_Click(object sender, EventArgs e)
        {
            if (clsCard.DeleteCard(_CardID)) 
                OnDelete?.Invoke(this, null);       
        }

        /// Edit Quantity when edit it in this control
        ~ctrlProductCard()
        {
            // Edit quantity in database if is changed Quantity
            if (_IsChanged)
            {
                clsCard.UpdateQuantityCard(_CardID, Quantity);           
            }
        }

        private void btnIncreaseCount_Click(object sender, EventArgs e)
        {
            _IsChanged=true;    
            if (SelectedQuantity + 1 <= _MaxQuantity)
            {
                SelectedQuantity++;
                lbProductQuantity.Text = SelectedQuantity.ToString();
                //Calculate the number of the product, multiply the price, display it, and store it in _TotalPrice
                lblProductPrice.Text = (_TotalPrice = SelectedQuantity * _Price).ToString("f2");
                // Raise event
                OnQuantityChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show($"Out of stock, maximum is {_MaxQuantity}");
            }

        }

        private void btnDecreaseCount_Click(object sender, EventArgs e)
        {
            _IsChanged = true;
            if (SelectedQuantity > 1)
            {
                SelectedQuantity--;
                lbProductQuantity.Text = SelectedQuantity.ToString();
                //Calculate the number of the product, multiply the price, display it, and store it in _TotalPrice
                lblProductPrice.Text = (_TotalPrice = SelectedQuantity * _Price).ToString("f2");
                // Raise event
                OnQuantityChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("You cannot choose less than 1");
            }
        }

        private void chbSelect_Click(object sender, EventArgs e)
       {
            if (Quantity <= 0) 
            {
                chbSelect.Checked = false;
                MessageBox.Show("A product that is not available cannot be purchased", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                OnSelect?.Invoke(lbName.Text.Trim(), ProductID, Quantity, _Price, _CardID, chbSelect.Checked);
            }
        }

        public void Change_checkBoxOfSelectProduct(bool value)
        {
            if (Quantity > 0)
            {
                chbSelect.Checked = value;
                OnSelect?.Invoke(lbName.Text.Trim(), ProductID, Quantity, _Price, _CardID, chbSelect.Checked);
            }
        }
    }
}
