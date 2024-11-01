using Guna.UI2.WinForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Threading.Tasks;
using Store.Business;
using System.Threading;

namespace Store
{
    public partial class frmMain : Form
    {
        private int _MainCategoryID = 0;
        public frmMain()
        {
            InitializeComponent();
        }
       
        // Events      
        private  void btnShop_Click(object sender, EventArgs e)
        {
            if (!_VisibleOrUnVisibleMainCategory())
                return;
            DataTable dataTable = new DataTable();
            dataTable =  clsMainCatecory.GetAllMainCategories();      
            
            _LoadMainCategoriesNames(dataTable);

        }
        
        private bool _VisibleOrUnVisibleMainCategory()
        {
            pnlMainCategoriesButttonsContainer.Visible = pnlMainCategoriesButttonsContainer.Visible ? false : true;
            return pnlMainCategoriesButttonsContainer.Visible;
        }
        private void btnMainCategory_Click(object sender, EventArgs e)
        {
            //To not load the opened form again
            Guna2Button btn = (Guna2Button)sender;
            if ((int)btn.Tag != _MainCategoryID)
            {
                _MainCategoryID = (int)btn.Tag;
                frmShop frmShop = new frmShop(btn.Text, _MainCategoryID);
                frmShop.OnAddBasket += _RefreshBasket;
                frmShop.OnIsLogin += _RefreshBasket;
                _OpenFormInpnlMainContainer(frmShop);
            }          
        }
        private void btnShop_CheckedChanged(object sender, EventArgs e)
        {
            pnlMainCategoriesButttonsContainer.Visible = false;
            lblHeader.Text = btnShop.Text;
        }
        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            lblHeader.Text = btnDashboard.Text;
        }
        private void btnSettings_CheckedChanged(object sender, EventArgs e)
        {
            lblHeader.Text = btnSettings.Text;
        }
        // Helper fucntions

        private void _OpenFormInpnlMainContainer(Form frm)
        {
                pnlMainContainer.Controls.Clear();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                pnlMainContainer.Controls.Add(frm);
        }

        private void _LoadMainCategoriesNames(DataTable MainCategoriesNames)
        {
            pnlMainCategoriesButttonsContainer.Controls.Clear();
            

            foreach (DataRow MainCategoryName in MainCategoriesNames.Rows)
            {
                pnlMainCategoriesButttonsContainer.Controls.Add(_GenerateMainCategoriesButttons(MainCategoryName["CategoryName"].ToString(),(int) MainCategoryName["MainCategoryID"]));
            }
        }

        private Guna2Button _GenerateMainCategoriesButttons(string MainCategoryButttonName = "Test",int MainCategoryID =0)
        {
            Guna2Button btn = new Guna2Button();
            btn.Text = MainCategoryButttonName;
            btn.Tag = MainCategoryID;
            btn.Size = new System.Drawing.Size(130, 35);
            btn.FillColor =  Color.FromArgb(57, 55, 65);
            btn.BorderRadius = 5;
            btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn.Click += btnMainCategory_Click;

            return btn;
        }

     
        private  void btnBasket_Click(object sender, EventArgs e)
        {
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            else
                _OpenFrmBasket();
        }
        private async void _OpenFrmBasket()
        {
            _RefreshBasket();

            btnBasket.BringToFront();

            frmWait wait = new frmWait();
            wait.Show();
            frmBasket Basket = new frmBasket();
            await Task.Run(() =>
            {
                Basket.LoadForm();

            });
            Basket.OnChangedBasket += _RefreshBasket;
            wait.Close();
            Basket.ShowDialog();

            Basket = null;
            GC.Collect();
        }
        private  void frmMain_Load(object sender, EventArgs e)
        {
            ctrlTopRatedProducts ctrl = new ctrlTopRatedProducts();
            ctrl.Location = new Point(9, 15);
            ctrl.OnReturnClick += OpenShowDetails;
            pnlMainContainer.Controls.Add(ctrl);

            ctrlProductsPromotion ctrlPro = new ctrlProductsPromotion();
            ctrlPro.Location = new Point(9, 250);
            ctrlPro.OnReturnClick += OpenShowDetails;
            pnlMainContainer.Controls.Add(ctrlPro);


            _RefreshBasket();

            //Subscribe with  Event information has been uploadedThe customer in order to
            //modify information in the main form
            Global.OnLoadCustomerData += _LoadCustomerData;
        }

        private void OpenShowDetails(int ProductID)
        {
            frmShowDetails frm = new frmShowDetails(ProductID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.VisableBtnBack = false;
            frm.OnAddCard += _RefreshBasket;
            frm.ShowDialog();
        }

        private void _RefreshBasket() 
       {
            if (Global.Customer == null)
            {
                return;
            }

            int ? Count = clsCard.GetCountCards((int)Global.Customer.CustomerID);
            if (Count == 0) 
            {
                niBasket.Visible = false;
            }
            else 
            {   if (Count > 9) 
                {
                    niBasket.Text = "9+";
                }
                else
                {
                    niBasket.Text = Count.ToString();
                }
                niBasket.Visible = true;
                
            }
       }

        private void btnPurchases_Click(object sender, EventArgs e)
        {            
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            else
                _RefreshBasket();
            frmMyPurchases frm = new frmMyPurchases();
            frm.ShowDialog();
        }

        private void _LoadCustomerData()
        {
            lblCustomerName.Text = Global.Customer.FullName;
            lblCustomerEmail.Text = Global.Customer.Email;
        }

        private void btnQuitBottom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                _LogOut();
            }
        }
        private void _LogOut()
        {
            Global.Customer = null;
            lblCustomerName.Text = "Demo account";
            lblCustomerEmail.Text = "Test@Demo.com";

            niBasket.Text = "0";
            niBasket.Visible = false;

            //pnlMainContainer.Controls.Clear();
        }
        private void pbCustomerProfile_Click(object sender, EventArgs e)
        {
            frmProfileMenu frm = new frmProfileMenu();
            int x = this.Location.X + pbCustomerProfile.Location.X + pbCustomerProfile.Width;
            int y = this.Location.Y + pbCustomerProfile.Location.Y + pbCustomerProfile.Height;
            frm.Location = new Point(x + 86, y + 38);
            frm.OnDoneLogged = null;
            frm.OnDoneLogged += _OpenfrmEditCustomerData;
            frm.OnBasketClick = null;
            frm.OnBasketClick += _OpenFrmBasket;
            frm.OnSignOutClick = null;
            frm.OnSignOutClick += _LogOut;
            frm.Show();

        }

        private void _OpenfrmEditCustomerData()
        {

                _RefreshBasket();

            pnlMainContainer.Controls.Clear();
            frmEditCustomerData frm = new frmEditCustomerData();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            pnlMainContainer.Controls.Add(frm);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMainContainer.Controls.Clear();
            frmMain_Load(null, null);
        }
    }
}
