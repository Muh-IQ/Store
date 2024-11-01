using Store.Properties;
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
    public partial class ctrlProduct : UserControl
    {     
        public ctrlProduct()
        {
            InitializeComponent();
        }
        public  enum _enStar { None = 0, star1 =1 , star2 = 2,star3 =3, star4 =4 , star5 = 5 };
        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
              
            }
        }
        private decimal _Price;
        public decimal Price
        { get
            {
                return _Price;
            }
          set
            {
                _Price = value;
                lblProductPrice.Text = _Price.ToString("f2") + "$";
            } 
        }
        private string _NameProduct;
        public string NameProduct
        {
            get
            {
                return _NameProduct;
            }
            set
            {
                _NameProduct = value;
                lblProcudtName.Text = _NameProduct; ;
            }
        }

        private string _ImageURL;
        public string ImageURL
        {
            get
            {
                return _ImageURL;
            }
            set
            {
                _ImageURL = value;
                pbImage.ImageLocation = _ImageURL; 
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                lblDescription.Text = _Description; 
            }
        }
        private int _QuantityInStock;
        public int QuantityInStock
        {
            get
            {
                return _QuantityInStock;
            }
            set
            {
                _QuantityInStock = value;
                lblStock.Text = _QuantityInStock.ToString() + " in Stock"; 
            }
        }

        private _enStar _Rating;
        public int Rating
        {
            get { return (int)_Rating; }
            set 
            {
                _Rating =(_enStar) value;
                switch(_Rating)
                {
                    case _enStar.None:
                        pbRating.Image=Resources.satr_0_removebg_preview; break;

                    case _enStar.star1:
                        pbRating.Image = Resources.satr_1_removebg_preview; break;

                    case _enStar.star2:
                        pbRating.Image = Resources.star_2_removebg_preview; break;

                    case _enStar.star3:
                        pbRating.Image = Resources.satr_3_removebg_preview; break;

                    case _enStar.star4:
                        pbRating.Image = Resources.satr_4_removebg_preview; break;
                    
                    case _enStar.star5:
                        pbRating.Image = Resources.satr_5_removebg_preview; break;
                }
            }
            
        }
        private void Product_Click(object sender, EventArgs e)
        {
            this.OnClick(e);  
        }
    }
}
