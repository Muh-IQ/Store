using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Store.Business;
using Store.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static Store.Business.clsProduct;
using Spelling_Check_V2;
using Store.Data;
namespace Store
{
    public partial class frmShop : Form
    {
        private enum _enBasicFilterItems { None = 0, PriceLowToHigh = 1, PriceHighToLow = 2, RatingLowToHigh = 3, RatingHighToLow = 4, Manual = 5 }
        private enum _enManualFilterItems { Price = 0 ,Rating =1}

        public event Action OnAddBasket;
        public Action OnIsLogin;

        private string _MainCategoryName;
        private clsProduct._enOrderBy _OrderBy = _enOrderBy.ProductID;
        private clsProduct._enSort _Sort = _enSort.ASC;
        private int _MainCategoryID;
        private int _ProductCategoryID = 1;
        private int _ProductPageNumber = 1;
        public frmShop(string MainCategoryName, int MainCategoryID)
        {
            InitializeComponent();

            this._MainCategoryName = MainCategoryName;
            this._MainCategoryID = MainCategoryID;
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _MainCategoryName;
            _LoadSubCategoriesNames(clsSubCategory.GetAllSubCategories(_MainCategoryID));


            ctrlShowPages1.PageSelected += _LoadProductsWithBasicFilterOrNone;//It should be the subscription here,
                                                         //Because the subscription is multiple
                                                         //every time the function that contains                                                         //the subscription is used
        }


        private void _LoadSubCategoriesNames(DataTable SubCategoriesNames)
        {
            pnlSubCategories.Controls.Clear();
            pnlSubCategories.Visible = true;

            foreach (DataRow SubCategoryName in SubCategoriesNames.Rows)
            {
                pnlSubCategories.Controls.Add(_GenerateSubCategoriesButttons(SubCategoryName["SubcatecoryName"].ToString(), (int)SubCategoryName["SubCategoryID"]));
            }
        }
        private void _LoadProductCategories(DataTable ProductCategories)
        {
            //getAlldata
            flpProductCategories.Controls.Clear();
            //flpProductCategories.Visible = true;
            foreach (DataRow item in ProductCategories.Rows)
            {
                flpProductCategories.Controls.Add(_GenerateProductCategoriesButttons(item["ProductCategoryName"].ToString(), (int)item["ProductCategoryID"]));
            }


        }
        private async void btnSubCategory_Click(object sender, EventArgs e)
        {
            //Reset Filter
            _OrderBy = _enOrderBy.ProductID;
            _Sort = _enSort.ASC;
            cbFilter.SelectedIndex = 0;

            flpProductCategories.Visible = true;
            pnlFilter.Visible = false;

            Guna2Button btn = (Guna2Button)sender;


            _LoadProductCategories(await clsProductCategory.GetAllProductCategory((int)btn.Tag));
            ctrlShowPages1.ClearPages();
            flpProducts.Controls.Clear();
            flpProducts.BackgroundImage = Resources.in_stock_removebg_preview;
            flpProducts.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            _ProductCategoryID = (int)btn.Tag;
            _LoadProductsWithBasicFilterOrNone(_ProductPageNumber);
            flpProductCategories.Visible = false;

            pnlFilter.Visible = true; 
        }

        //Get Product
        private async void _LoadProductsWithBasicFilterOrNone(int _ProductPageNumber )
        {
            flpProducts.Controls.Clear();
            ctrlShowPages1.Visible = true;
            this._ProductPageNumber = _ProductPageNumber;
            DataTable Products = await clsProduct.GetPageProductsWithBasicFilter(_ProductCategoryID, _ProductPageNumber, _OrderBy, _Sort);
            _DrawControlProducts(Products);
            ctrlShowPages1.LoadData(_ProductCategoryID);
        }

        private bool _DrawControlProducts(DataTable Products)
        {
           // flpProducts.Controls.Clear();
            ctrlShowPages1.Visible = true;          
            if (Products.Rows.Count < 1)
            {
                MessageBox.Show("This page contains no products", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            flpProducts.BackgroundImage = null;
            int? Rating = null;
            foreach (DataRow item in Products.Rows)
            {
                
                if (int.TryParse(item["Rating"].ToString(), out int result))
                    Rating = result;
                else
                    Rating = null;


                flpProducts.Controls.Add(_GenerateCtrlProducts((int)item["ProductID"], item["ProductName"].ToString(), item["Description"].ToString(), (decimal)item["Price"], (int)item["QuantityInStock"],item["ImageUrl"].ToString(), Rating));
            }
            return true;
        }
        private Guna2Button _GenerateSubCategoriesButttons(string SubCategoryButttonName = "Test", int SubCategoryID = 0)
        {

            Guna2Button btn = new Guna2Button();
            btn.BorderColor = System.Drawing.Color.Empty;
            btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            btn.CheckedState.FillColor = System.Drawing.Color.White;
            btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            btn.DefaultAutoSize = true;
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.Dock = System.Windows.Forms.DockStyle.Left;
            btn.FillColor = System.Drawing.Color.Transparent;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.HoverState.FillColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(224, 0);
            btn.Name = "guna2Button6";
            btn.PressedColor = System.Drawing.Color.White;
            btn.Size = new System.Drawing.Size(72, 42);
            btn.TabIndex = 6;
            btn.Text = SubCategoryButttonName;
            btn.Tag = SubCategoryID;
            btn.Click += btnSubCategory_Click;
            return btn;
        }
        private Guna2Button _GenerateProductCategoriesButttons(string ProductCategoriesButttonName = "Test", int ProductCategoriesID = 0)
        {

            Guna2Button btn = new Guna2Button();
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
            btn.Location = new System.Drawing.Point(4, 4);
            btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btn.Name = "guna2Button7";
            btn.Size = new System.Drawing.Size(116, 33);
            btn.TabIndex = 7;
            btn.Click += btnProductCategory_Click;


            btn.Text = ProductCategoriesButttonName;
            btn.Tag = ProductCategoriesID;
            return btn;
        }

        private ctrlProduct _GenerateCtrlProducts(int productID, string ProductName, 
            string Description, decimal Price, int QuantityInStock, string ImageUrl , int? Rating)
        {
            ctrlProduct ctrl = new ctrlProduct();
            ctrl.ID = productID;
            ctrl.NameProduct = ProductName;
            ctrl.Description = Description;
            ctrl.Price = Price;
            ctrl.ImageURL = ImageUrl;
            ctrl.QuantityInStock = QuantityInStock;
            ctrl.Rating = Rating ?? 0;
            ctrl.Click += Ctrl_Clik;
            return ctrl;
        }
        private void Ctrl_Clik(object sender, EventArgs e)
        {
            flpProducts.Controls.Clear();
            ctrlShowPages1.Visible = false;
            frmShowDetails showDetails = new frmShowDetails(((ctrlProduct)sender).ID);
            showDetails.TopLevel = false;
            showDetails.OnAddCard += _ChangedBasket;
            showDetails.OnIsLogin += _WhenLogged;
            showDetails.Show();

            flpProducts.Controls.Add(showDetails);
            showDetails.backToShop += _Refreshes;
        }

        private void _WhenLogged()
        {
            OnIsLogin?.Invoke();
        }
        private void _Refreshes()
        {
            _LoadProductsWithBasicFilterOrNone(_ProductPageNumber);
            ctrlShowPages1.Visible = true;
        }

        private void _ChangedBasket()
        {
            OnAddBasket?.Invoke();
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrlShowPages1.ClearPages();
            
            cbManualFilter.Visible = txtProductName.Visible = txtFrom.Visible = txtTo.Visible = btnGo.Visible = false;
            int SelectedIndex = cbFilter.SelectedIndex;
            switch (SelectedIndex)
            {
                case (int)_enBasicFilterItems.None:
                    _OrderBy = _enOrderBy.ProductID;
                    _Sort = _enSort.ASC;
                    //Unsubscribe so that when you turn to a second page,
                    //an event will not be sent and the screen will refresh
                    ctrlShowPages1.PageSelected = null;
                    ctrlShowPages1.PageSelected += _LoadProductsWithBasicFilterOrNone;
                    
                    break;
                case (int)_enBasicFilterItems.PriceLowToHigh:
                    _OrderBy = _enOrderBy.Price;
                    _Sort = _enSort.ASC;
                    break;
                case (int)_enBasicFilterItems.PriceHighToLow:
                    _OrderBy = _enOrderBy.Price;
                    _Sort = _enSort.DESC;
                    break;
                case (int)_enBasicFilterItems.RatingLowToHigh:
                    _OrderBy = _enOrderBy.Rating;
                    _Sort = _enSort.ASC;
                    break;
                case (int)_enBasicFilterItems.RatingHighToLow:
                    _OrderBy = _enOrderBy.Rating;
                    _Sort = _enSort.DESC;
                    break;
                case (int)_enBasicFilterItems.Manual:
                    //Unsubscribe so that when you turn to a second page,
                    //an event will not be sent and the screen will refresh
                    ctrlShowPages1.PageSelected = null;
                    ctrlShowPages1.PageSelected += _LoadProductsWithManualFilter;
                    cbManualFilter.Visible = txtProductName.Visible = txtFrom.Visible = txtTo.Visible = btnGo.Visible = true;
                    return;

            }
            //Reset ProductPageNumber 
            //Even if it is on any page, it goes back to the first page
            _ProductPageNumber = 1;
            _LoadProductsWithBasicFilterOrNone(_ProductPageNumber);
        }
        
        private void ResetControlsFilter()
        {
            //reset => 1 - txtFrom 2 - txtTo 3 - txtProductName And cbStar
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtProductName.Text = string.Empty;
            cbStar.SelectedIndex = 0;
        }
        private void cbManualFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear all contents of the control so that the filter works properly
            ResetControlsFilter();

            _enManualFilterItems SelectedIndex = (_enManualFilterItems) cbManualFilter.SelectedIndex;
            switch (SelectedIndex)
            {
                case _enManualFilterItems.Price:
                    txtFrom.Visible = true;
                    txtTo.Visible = true;
                    cbStar .Visible = false;
                    break;
                case _enManualFilterItems.Rating:
                    cbStar.Visible = true;
                    txtFrom.Visible = false;
                    txtTo.Visible = false;
                    break;
            }
        }

        private (decimal From, decimal To, string ProductName, short? Rating) _ConvertTextControlToVariable()
        {
            decimal From = (txtFrom.Text.Trim() == "") ? 0 : decimal.Parse(txtFrom.Text.Trim());
            decimal To = (txtTo.Text.Trim() == "") ? 0 : decimal.Parse(txtTo.Text.Trim());
            string ProductName = (txtProductName.Text.Trim() == "") ? null : txtProductName.Text.Trim();
            short? Rating;
            if (cbStar.SelectedIndex == (int)ctrlProduct._enStar.None)
                Rating = null;
            else
                Rating = (short)cbStar.SelectedIndex;
            return (From, To, ProductName, Rating);
        }
        private  async void _LoadProductsWithManualFilter(int _ProductPageNumber)
        {
            flpProducts.Controls.Clear();
            ctrlShowPages1.Visible = true;
            this._ProductPageNumber = _ProductPageNumber;

            
            var VariablesData = _ConvertTextControlToVariable();
           

            DataTable Products = await _LoadProductsData(_ProductCategoryID, _ProductPageNumber, VariablesData.ProductName, VariablesData.From, VariablesData.To, VariablesData.Rating);


            if (_DrawControlProducts(Products))
            {
                ctrlShowPages1.LoadData(_ProductCategoryID, VariablesData.ProductName, VariablesData.From, VariablesData.To, VariablesData.Rating);
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTo.Text.Trim()) && string.IsNullOrEmpty(txtProductName.Text.Trim()) && cbStar.SelectedIndex == (int)ctrlProduct._enStar.None)
            {
                MessageBox.Show("Plz,Enter search terms", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             ctrlShowPages1.ClearPages();
            _LoadProductsWithManualFilter(this._ProductPageNumber = 1);          
        }

        private async Task<DataTable> _LoadProductsData(int ProductCategoryID,int ProductPageNumber, string WrongProductName, decimal From, decimal To, int? Rating)
        {
            DataTable Products = await clsProduct.GetPageProductsWithManualFilter(_ProductCategoryID, _ProductPageNumber, WrongProductName, From, To,    Rating);

            if (!string.IsNullOrEmpty(WrongProductName))
            {
                if (Products.Rows.Count < 1)
                {
                    List<string> ProductsName = clsProduct.GetAllProductsName();

                    SpellingCheck check = new SpellingCheck(ProductsName);
                    // return correct name
                    string RightProductName = check.CorrectionOfTwoLetters(WrongProductName);
                    Products = await clsProduct.GetPageProductsWithManualFilter(_ProductCategoryID, _ProductPageNumber, RightProductName,    From, To,   Rating);
                    ctrlAutoCorrect AutoCorrect = new ctrlAutoCorrect();
                    AutoCorrect.LoadData( WrongProductName, RightProductName);
                    flpProducts.Controls.Add(AutoCorrect);
                }
            }
            return Products;
        }

       
    }
}
