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
using static Store.ctrlProduct;

namespace Store
{
    public partial class ctrlShowComment : UserControl
    {
        private string _comment { get; set; }
        public string Comment
        {
            get
            { return _comment; }
            set
            {
                _comment = value;
                tbComment.Text = _comment;
                //if _comment is empty => resize this ctrl
                _Resize();
            }
        }

        private string _FullName { get; set; }
        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                lblName.Text = _FullName;
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
        public ctrlShowComment()
        {
            InitializeComponent();
        }

        private void _Resize()
        {
            if (string.IsNullOrEmpty(_comment)) 
            {
                this.Size = new System.Drawing.Size(556, 28);
            }
        }
    }
}
