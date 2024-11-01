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
using static Store.ctrlDisplayProductsAsLinear;

namespace Store
{
    public partial class ctrlTopRatedProducts : UserControl
    {
        public delegate void OnReturnClickControls(int ProductID);
        public OnReturnClickControls OnReturnClick;
        public ctrlTopRatedProducts()
        {
            InitializeComponent();
        }
        private async void _LoadProducts()
        {
            ctrlDisplayProductsAsLinear1.LoadProducts(await clsProduct.GetTopRatedProducts());
            
            ctrlDisplayProductsAsLinear1.OnReturnClick += _OnCliclProduct;
        }
        private void _OnCliclProduct(int productid)
        {
            OnReturnClick?.Invoke(productid);
        }

        private void ctrlTopRatedProducts_Load(object sender, EventArgs e)
        {
            _LoadProducts();
        }
    }
}
