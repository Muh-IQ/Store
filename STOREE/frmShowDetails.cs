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

namespace Store
{
    public partial class frmShowDetails : Form
    {
        public delegate void OnBack();
        public OnBack backToShop;
        public Action OnAddCard;
        public Action OnIsLogin;

        private bool _VisableBtnBack;
        public bool VisableBtnBack
        {
            set
            {
                _VisableBtnBack = value;
                btnBack.Visible = _VisableBtnBack;
            }
            get 
            {
                return _VisableBtnBack;
            }
        }  

        private int _ProductID;
        private int _QuantityInStock;
        private int _NumberOfproducts ;
        private decimal _Price;
        private clsProduct _Product;

        private short _PageNumber = 0;
        private int _CommentCount;
        private int _VisibleCommentCount = 0;
        public frmShowDetails(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
        }

        private void frmShowDetails_Load(object sender, EventArgs e)
        {
            _Product = clsProduct.Find(_ProductID);
            if(_Product == null) 
            {
                MessageBox.Show("Can not Load Data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblProductname.Text = _Product.ProductName;
            lblDescription.Text = _Product.Description;
            _QuantityInStock= _Product.QuantityInStock;
            lblStockIn.Text= _QuantityInStock.ToString()+ " in stock";
            lblStockIn.ForeColor = (_QuantityInStock > 0)? Color.Green : Color.Red;
            lbProductCount.Text = (_QuantityInStock > 0) ? "1" : "0";
            _NumberOfproducts = (_QuantityInStock > 0) ? 1 : 0;
            _Price = _Product.Price;
            lblPrice.Text = _Price.ToString("f2");
            ctrlShowImagesForProduct1.LoadProductImages(_ProductID);
            lblShowMore.Visible = (_CommentCount =_Product.GetRatingCountForProduct()) > 0;

            if (lblShowMore.Visible)
            {
                //load 3 comment
                lblShowMore_Click(null, null);
            }
            else
            {// if not exist comment
                ctrlNotFoundComment ctrl = new ctrlNotFoundComment();
                flpImagesAndComment.Controls.Add(ctrl);
            }
        }

        private void btnIncreaseCount_Click(object sender, EventArgs e)
        {
            if (_NumberOfproducts + 1 <= _QuantityInStock)
            {
                _NumberOfproducts++;
                lbProductCount.Text = _NumberOfproducts.ToString();
                lblPrice.Text = (_NumberOfproducts * _Price).ToString("f2");
            }
            else
            {
                MessageBox.Show($"Out of stock, maximum is {_QuantityInStock}");
            }
        }

        private void btnDecreaseCount_Click(object sender, EventArgs e)
        {
            if (_NumberOfproducts >1)
            {
                _NumberOfproducts--;
                lbProductCount.Text = _NumberOfproducts.ToString();
                lblPrice.Text = (_NumberOfproducts * _Price).ToString("f2");
            }
            else
            {
                MessageBox.Show("You cannot choose less than 1");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backToShop?.Invoke();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            
            OnIsLogin?.Invoke();

            clsCard card = new clsCard();
            card.ProductID = _ProductID;
            card.Quantity = _NumberOfproducts;
            card.CustomerID = (int)Global.Customer.CustomerID;
            if (card.Save())
            {
                OnAddCard();
            }
        }

        private void lblShowMore_Click(object sender, EventArgs e)
        {    

            List<(byte RatingScore, string FullName, string ReviewText)> Comment = _Product.GetPageProductRating(++_PageNumber);
            
            _VisibleCommentCount += Comment.Count;
            
            foreach (var item in Comment) 
            {
                
                flpImagesAndComment.Controls.Add(_GeneratectrlComment(item.RatingScore, item.FullName, item.ReviewText));

            }

            if (_VisibleCommentCount == _CommentCount)
            {
                lblShowMore.Visible = false;
            }
       
        }

        private ctrlShowComment _GeneratectrlComment(byte RatingScore, string FullName, string ReviewText)
        {
            ctrlShowComment ctrl = new ctrlShowComment();
            ctrl.FullName = FullName;

            ctrl.Rating = RatingScore;
            ctrl.Comment = ReviewText;
            return ctrl;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            OnIsLogin?.Invoke();

            if (_QuantityInStock < 1)
            {
                MessageBox.Show("This product is not available now", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Open the payment form for the customer to complete the purchase
            frmPayment frm = new frmPayment();
            frm.LoadProduct(_ProductID, _Product.ProductName, _NumberOfproducts, _Price);
            frm.ShowDialog();

        }
    }
}
