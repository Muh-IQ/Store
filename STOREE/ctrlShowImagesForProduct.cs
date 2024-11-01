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
    public partial class ctrlShowImagesForProduct : UserControl
    {
        public ctrlShowImagesForProduct()
        {
            InitializeComponent();
        }
        public void LoadProductImages(int ProductID)
        {

            DataTable Images = clsProduct.GetAllProductImage(ProductID);
            byte Counter = 4;
            foreach (DataRow item in Images.Rows)
            {
                ((PictureBox)pnlProductImages.Controls[Counter--]).ImageLocation = (string)item["ImageUrl"];
                if (Counter == 0)
                    break;
            }
            //set  top  image of Main Image => pbMainImage
            ((PictureBox)pnlProductImages.Controls[0]).ImageLocation = ((PictureBox)pnlProductImages.Controls[4]).ImageLocation;


            if (Images.Rows.Count == 1)
            {
                pbMainImage.Dock = DockStyle.Fill;
            }
        }

        private void pbImage1_Click(object sender, EventArgs e)
        {
            pbMainImage.ImageLocation = ((PictureBox)sender).ImageLocation;
        }

    }
}
