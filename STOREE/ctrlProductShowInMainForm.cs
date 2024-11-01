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
    public partial class ctrlProductShowInMainForm : UserControl
    {
        private enum _enStar { None = 0, star1 = 1, star2 = 2, star3 = 3, star4 = 4, star5 = 5 };
        public ctrlProductShowInMainForm()
        {
            InitializeComponent();
        }
        public Action OnMouseEnterControls;
        public Action OnLeaveControls;
        public delegate void OnClickControls(int ProductID);
        public OnClickControls OnClick_Controls;

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

        private _enStar _Rating;
        public int Rating
        {
            get { return (int)_Rating; }
            set
            {
                _Rating = (_enStar)value;
                switch (_Rating)
                {
                    case _enStar.None:
                        pbRating.Image = Resources.satr_0_removebg_preview; break;

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
        public void LoadData(int ProductID, string Name , byte Rating, int CountOfRating, decimal Price,string ImagePath)
        {
            ID = ProductID;
            lblProcudtName.Text = Name; ;
            lblProductPrice.Text = Price.ToString("f2") + "$";
            this.Rating = Rating;
            lblCountOfRating.Text = $"({CountOfRating})";
            pbImage.LoadAsync(ImagePath);
           
        }

        //private void Controls_MouseHover(object sender, EventArgs e)
        //{
        //    //OnMouseEnterControls?.Invoke();
        //}

        //private void Controls_MouseLeave(object sender, EventArgs e)
        //{
        //    //OnLeaveControls?.Invoke();
        //}

        private void Controls_Click(object sender, EventArgs e)
        {
            OnClick_Controls?.Invoke(_ID);
        }
    }
}
