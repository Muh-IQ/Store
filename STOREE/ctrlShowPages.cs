using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Store.Business;
using Store.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Store.ctrlShowPages;

namespace Store
{
    public partial class ctrlShowPages : UserControl
    {
        public delegate void OnSelectedPage(int PageOfNumber);
        public OnSelectedPage PageSelected;
        private enum _enRightOrLeft { Left = 1,  Right = 2 };
        private int _SelectedPage = 1;
        private int _PagesOFNumber = 1;
        private int _ProductCategoryID = 1;

        public ctrlShowPages()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads data for the default product category ID.
        /// </summary>
        /// <param name="ProductCategoryID">The ID of the product category. Default value is 1.</param>
        public void LoadData(int ProductCategoryID = 1)
        {
            _ProductCategoryID = ProductCategoryID; // Set the product category ID
            _PagesOFNumber = clsProduct.GetCountPerPages(ProductCategoryID); // Get the count per pages
            DrawControl(); // Draw the control
        }

        /// <summary>
        /// Loads data with additional filtering options.
        /// </summary>
        /// <param name="ProductCategoryID">The ID of the product category.</param>
        /// <param name="NameProduct">The name of the product for filtering.</param>
        /// <param name="PriceForm">The minimum price for filtering.</param>
        /// <param name="PriceTo">The maximum price for filtering.</param>
        ///  /// <param name="Rating">The Rating star for filtering, Allow Nullable.</param>
        public void LoadData(int ProductCategoryID, string NameProduct, decimal PriceForm, decimal PriceTo,int? Rating)
        {
            
            _ProductCategoryID = ProductCategoryID; // Set the product category ID
            _PagesOFNumber = clsProduct.GetCountPerPages(ProductCategoryID, NameProduct, PriceForm, PriceTo,Rating); // Get the count per pages with manual filtering
            DrawControl(); // Draw the control
        }

        private void DrawControl()
        {
            // <- 1 2 3 ->    I will draw this design
            flpPages.Controls.Clear();
            if (_PagesOFNumber <= 1)
            {
                return;
            }
            GenerateLeftRight(@"C:\Users\Asus\Desktop\Store-01\ImageSystem\Left.jpg", _enRightOrLeft.Left);

            for (int i = 1; i <= _PagesOFNumber; i++)
            {
                
                    flpPages.Controls.Add(Generatebutton(i.ToString()));
            }

            GenerateLeftRight(@"C:\Users\Asus\Desktop\Store-01\ImageSystem\Right.jpg", _enRightOrLeft.Right);
            
            Guna2CircleButton btn = (Guna2CircleButton)flpPages.Controls[_SelectedPage];
            btn.Checked = true; //to select the First button -> button[1]
            
        }
      
        private void PictureRightORLeft_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pb = ((PictureBox)sender);
                if (_SelectedPage >= 1 && _SelectedPage <= _PagesOFNumber)
                {
                    if (((_enRightOrLeft)pb.Tag == _enRightOrLeft.Right))
                    {
                        _SelectedPage++;
                        flpPages.Controls[_SelectedPage].Text = _SelectedPage.ToString();
                        flpPages.Controls[_SelectedPage].Tag = _SelectedPage;
                        Guna2CircleButton btn = (Guna2CircleButton)flpPages.Controls[_SelectedPage];
                        btn.PerformClick();
                    }
                    else if (((_enRightOrLeft)pb.Tag == _enRightOrLeft.Left))
                    {
                        _SelectedPage--;
                        Guna2CircleButton btn = (Guna2CircleButton)flpPages.Controls[_SelectedPage];
                        btn.PerformClick();
                       
                        flpPages.Controls[_SelectedPage].Text = _SelectedPage.ToString();
                        flpPages.Controls[_SelectedPage].Tag = _SelectedPage;
                        
                    }

                }

            }
            catch (Exception ex)
            {
                _SelectedPage = 1;//failure -> _SelectedPage in the left he can access to 0
                Debug.WriteLine($"Picture_Click : {ex.Message} :-(");
            } 
            
           
        }
        private void ButtonPage_Click(object sender, EventArgs e)
        {
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            _SelectedPage = Convert.ToInt16(btn.Tag);
            EnableDisableRightOrLeft();
            if (PageSelected != null)
            {
                PageSelected?.Invoke(_SelectedPage);
            }

        }
        private void EnableDisableRightOrLeft()
        {
            if (_SelectedPage<=1)
            {
                _SelectedPage = 1;

                flpPages.Controls[0].Enabled = false; ;

            }
            else
            {
                flpPages.Controls[0].Enabled = true; ;
            }
            if (_SelectedPage >= _PagesOFNumber)
            {
                _SelectedPage = _PagesOFNumber;
                flpPages.Controls[_PagesOFNumber + 1].Enabled = false; ;
            }
            else
            {
                
                flpPages.Controls[_PagesOFNumber+1].Enabled = true; ;
            }
        }
        private void GenerateLeftRight(string ImageUrl,_enRightOrLeft enTag)
        {
            PictureBox pb = new PictureBox();
            pb.ImageLocation = ImageUrl;
            pb.Name = "pictureBox2";
            pb.Size = new System.Drawing.Size(40, 40);
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb.TabIndex = 6;
            pb.TabStop = false;
            pb.Tag = (int)enTag;
            pb.Click += PictureRightORLeft_Click;
            flpPages.Controls.Add(pb);
        }
        private Guna2CircleButton Generatebutton(string CounterText)
        {
            Guna2CircleButton btn = new Guna2CircleButton();

            btn.BackColor = System.Drawing.Color.White;
            btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.Location = new System.Drawing.Point(78, 3);
            btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            btn.Name = "guna2Button7";
            btn.Size = new System.Drawing.Size(40, 40);
            btn.TextAlign = HorizontalAlignment.Center;
            btn.Click += ButtonPage_Click;
            btn.Text = CounterText;
            btn.Tag = CounterText;
            return btn;
        }
        public void ClearPages()
        {
            flpPages.Controls.Clear();
            _SelectedPage = 1;
        }
    }
}
