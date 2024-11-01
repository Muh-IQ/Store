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
using static Store.Business.clsProduct;

namespace Store
{
    public partial class ctrlDisplayProductsAsLinear : UserControl
    {
        private int scrollStep = 100;
        public delegate void OnReturnClickControls(int ProductID);
        public OnReturnClickControls OnReturnClick;
        public ctrlDisplayProductsAsLinear()
        {
            InitializeComponent();
            
        }
       
        private bool _btnLeftLock = false;
        private bool _btnRightLock = false;

        private int _scrollValue = 0;
        private int _ScrollValue
        {
            get
            {
                return _scrollValue;
            }
            set
            {
                _scrollValue = value;

                if (_scrollValue <= flpShowProducts.HorizontalScroll.Minimum)
                {
                    _scrollValue = flpShowProducts.HorizontalScroll.Minimum+2;
                    btnScrollLeft.Visible = false;
                    btnScrollRight.Visible = true;
                }
                
                else if(_scrollValue >= flpShowProducts.HorizontalScroll.Maximum)
                {
                    _scrollValue = flpShowProducts.HorizontalScroll.Maximum;
                    btnScrollLeft.Visible = true;
                    btnScrollRight.Visible = false;
                }
                else
                {
                    btnScrollLeft.Visible = true;
                    btnScrollRight.Visible = true;
                }
                flpShowProducts.HorizontalScroll.Value = _scrollValue;
                flpShowProducts.PerformLayout();

            }
        }
        private void btnScrollRight_Click(object sender, EventArgs e)
        {
            _ScrollValue += flpShowProducts.HorizontalScroll.LargeChange;
        }

        private void btnScrollLeft_Click(object sender, EventArgs e)
        {
            _ScrollValue -= flpShowProducts.HorizontalScroll.LargeChange;
        }

        public void LoadProducts(DataTable Products)
        {
            if (Products.Rows.Count < 1)
                return;
            if (Products.Rows.Count < 5)
                _Hiden_ShowControl(false);
            foreach (DataRow item in Products.Rows)
            {
                flpShowProducts.Controls.Add(_GenerateCtrlProducts((int)item["ProductID"], item["ProductName"].ToString(), (byte)item["Rating"], (int)item["CountOfRating"], (decimal)item["Price"],  item["ImageUrl"].ToString()));
            }
            flpShowProducts.AutoScroll = true;
        }

        private ctrlProductShowInMainForm _GenerateCtrlProducts(int productID, string ProductName,
           byte Rating,int CountOfRating, decimal Price, string ImageUrl)
        {
            ctrlProductShowInMainForm ctrl = new ctrlProductShowInMainForm();
            ctrl.LoadData(productID, ProductName, Rating, CountOfRating, Price, ImageUrl);
            ctrl.OnClick_Controls += RaiseBackEvent;
           
            return ctrl;
        }
        private void RaiseBackEvent(int ProductID)
        {
            OnReturnClick?.Invoke(ProductID);
        }

        private void flpShowProducts_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= flpShowProducts.HorizontalScroll.LargeChange- 50)
            {
                btnScrollRight.Visible = false;
                btnScrollLeft.Visible = true;
                _btnRightLock = false; 
            }
            else if (e.NewValue == 0 )
            {
                btnScrollLeft.Visible = false;
                btnScrollRight.Visible = true;
                _btnLeftLock = false;
            }
            else
            {
                btnScrollRight.Visible = true;
                btnScrollLeft.Visible = true;
                _btnLeftLock = true;
                _btnRightLock = true;

            }
        }

        //private void flpShowProducts_MouseLeave(object sender, EventArgs e)
        //{
        //    // this.ClientRectangle => Form Space
        //    // Control.MousePosition => Mouse location
        //    // PointToClient => تحويل الى الاحداثيات
        //    if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
        //    {
        //       // UnVisible;
        //        _Hiden_ShowControl(false);
        //    }
        //}
        private void _Hiden_ShowControl(bool value)
        {
            btnScrollLeft.Visible = value;
            btnScrollRight.Visible = value;
        }

        //private void flpShowProducts_MouseEnter(object sender, EventArgs e)
        //{
        //    //Visible
        //    _Hiden_ShowControl(true);
        //}
    }
}
