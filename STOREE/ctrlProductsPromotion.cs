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
    public partial class ctrlProductsPromotion : UserControl
    {
        public delegate void OnReturnClickControls(int ProductID);
        public OnReturnClickControls OnReturnClick;
        public ctrlProductsPromotion()
        {
            InitializeComponent();
        }

        private async void _LoadProducts()
        {
            ctrlDisplayProductsAsLinear1.LoadProducts(await clsProduct.GetPromotedProducts());

            ctrlDisplayProductsAsLinear1.OnReturnClick += _OnCliclProduct;
        }
        private void _OnCliclProduct(int productid)
        {
            OnReturnClick?.Invoke(productid);
        }

        private void ctrlProductsPromotion_Load(object sender, EventArgs e)
        {
            _LoadProducts();
        }
    }
}
