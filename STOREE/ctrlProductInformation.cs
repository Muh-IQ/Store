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
    public partial class ctrlProductInformation : UserControl
    {
        private string _ProductName;
        public string productName
        {
            set 
            {
                _ProductName = value;
                lblProductName.Text = value;
            }
            get { return _ProductName; }
        }

        private decimal _TotalPrice;
        public decimal TotalPrice
        {
            set
            {
                _TotalPrice = value;
                lblTotalPrice.Text = value.ToString("f2")+" $";
            }
            get { return _TotalPrice; }

        }

        private int _Quantity;
        public int Quantity
        {
            set
            {
                _Quantity = value;
                lblQuantity.Text = value.ToString   ();
            }
            get { return _Quantity; }
        }

        private decimal _PriceOfOneProduct;
        public decimal PriceOfOneProduct
        {
            set
            {
                _PriceOfOneProduct = value;
                lblPriceOfOneProduct.Text = value.ToString("f2") + " $";
            }
            get { return _PriceOfOneProduct; }

        }

        public ctrlProductInformation()
        {
            InitializeComponent();
        }

        private void lblShowLess_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(601, 50);
            lblShowMore.Visible = true;
        }

        private void lblShowMore_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(601, 100);
            lblShowMore.Visible = false;
        }

        private void ctrlProductInformation_Load(object sender, EventArgs e)
        {
            lblShowLess_Click(null, null);
        }
    }
}
