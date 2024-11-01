using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Business;

namespace Store.Data
{
    public partial class ctrlAutoCorrect : UserControl
    {
        public ctrlAutoCorrect()
        {
            InitializeComponent();
            
        }
        
        public void LoadData(string WrongNameProduct, string RightNameProduct)
        {

            // clsProduct.GetCountPerPages(ProductCategoryID, NameProduct, 0, 0, 0);
            lblDoYouMean.Text = $"Show results for {RightNameProduct} instead of {WrongNameProduct} .";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(0,0);
        }
    }
}
