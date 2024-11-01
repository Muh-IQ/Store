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
    public partial class ctrlPurchasedProduct : UserControl
    {
        private clsOrderItem _OrderItem;
        private int _OrderItemID;
        private string _PaymentMethod;
        private bool _IsGetShippingDetails = false;
        public string PaymentMethod
        {
            get { return _PaymentMethod; }
            set
            {
                _PaymentMethod = value;
                lblPaymentBy.Text = _PaymentMethod;
            }
        }
        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                lblDate.Text = _Date.ToShortDateString();
            }
        }
        public ctrlPurchasedProduct()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(888, 305);
        }

        public void LoadData(int OrderItemID)
        {
            _OrderItemID = OrderItemID;
            _OrderItem = clsOrderItem.Find(OrderItemID);
            if (_OrderItem == null) 
                return;

            pbImage.ImageLocation = _OrderItem.ProductInfo.ImageUrl;
            lbName.Text = _OrderItem.ProductInfo.ProductName;
            lbDescription.Text=_OrderItem.ProductInfo.Description;

            //نكتب Price 
            // الموجود في OrderItem بسبب ممكن تحديث سعر المنتج الاصلي
            lblProductPrice.Text= _OrderItem.Price.ToString("f2");

            lblNumberOfProductPurchased.Text = $"({_OrderItem.Quantity}) Purchased product";
            lblTotalPrice.Text = _OrderItem.TotalPrice.ToString("f2");

            //is found object ReviewAndRatingInfo  or not
            if (_OrderItem.ReviewAndRatingInfo != null)
            {
                tbComment.Text = _OrderItem.ReviewAndRatingInfo.ReviewText;

                cbRating.SelectedIndex = _OrderItem.ReviewAndRatingInfo.RatingScore;

            }
            else 
            {
                _OrderItem.ReviewAndRatingInfo= new clsReviewAndRating(); ;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            _DisableAndVisibleControl();

        }

        private void btnPostComment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbComment.Text) && cbRating.SelectedIndex == 0)
            {
                MessageBox.Show("Please add a comment and rating", "Unfilled fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _OrderItem.ReviewAndRatingInfo.ProductID = _OrderItem.ProductID;
            _OrderItem.ReviewAndRatingInfo.CustomerID = (int)Global.Customer.CustomerID;
            _OrderItem.ReviewAndRatingInfo.ReviewText = tbComment.Text.Trim()==string.Empty? null : tbComment.Text.Trim();
            _OrderItem.ReviewAndRatingInfo.OrderItemID = _OrderItemID;
            _OrderItem.ReviewAndRatingInfo.RatingScore = (byte)cbRating.SelectedIndex;
            if (_OrderItem.ReviewAndRatingInfo.Save())
            {
                MessageBox.Show("Comment added successfully", "Comment", MessageBoxButtons.OK);
                _DisableAndVisibleControl();
            }
            else
                MessageBox.Show("Comment was not added successfully", "Comment", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnPostComment.Visible = true;
            tbComment.Enabled = true;
            cbRating.Enabled = true;
        }

        private void _DisableAndVisibleControl()
        {
            if (_OrderItem.ReviewAndRatingInfo._EnMode == clsReviewAndRating._enMode.Update)
            {
                btnPostComment.Visible = false;
                tbComment.Enabled = false;
                cbRating.Enabled = false;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
            }
            else
            {
                btnPostComment.Visible = true;
                tbComment.Enabled = true;
                cbRating.Enabled = true;

                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete the comment and rating?", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_OrderItem.ReviewAndRatingInfo.DeleteReviewAndRating())
                {
                    MessageBox.Show("Deleted");
                    _ResetReviewAndRating();
                }
                else
                    MessageBox.Show("An error occurred during deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Deletion has been cancelled");
        }

        private void _ResetReviewAndRating()
        {
            //Reset mode
            _OrderItem.ReviewAndRatingInfo._EnMode = clsReviewAndRating._enMode.AddNew;

            //Reset Control
            cbRating.SelectedIndex = 0;
            tbComment.Text = string.Empty;

            _DisableAndVisibleControl();
        }

        private void lblShippingDetails_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lblShippingDetails.Tag) == 0)
            {
                lblShippingDetails.Tag = 1;
                pnlShippingDetails.Visible = true;
                this.Size = new System.Drawing.Size(888, 436);
            }
            else
            {
                lblShippingDetails.Tag = 0;
                pnlShippingDetails.Visible = false;
                this.Size = new System.Drawing.Size(888, 305);
            }
            if (!_IsGetShippingDetails)
            {
                _IsGetShippingDetails = true;
                _GetShippingDetails();
            }
        }

        private void _GetShippingDetails()
        {
            lblAddressDelivery.Text = _OrderItem.OrderInfo.Address.Trim();
            clsShipping shipping = clsShipping.FindByOrderID(_OrderItem.OrderID);
            if (shipping != null) 
            {
                lblShippingCompany.Text = shipping.CompanyInfo.CompanyName;
                lblShippingStatus.Text = shipping.ShippingStatusAsText;
                lblTrackingNumber.Text = shipping.TrackingNumber;
                lblExpectedDeliveryDate.Text = shipping.ExpectedDeliveryDate.ToShortDateString();
                lblActualDeliveryDate.Text = (shipping.ActualDeliveryDate == null)? "Unknown" : ((DateTime)shipping.ActualDeliveryDate).ToShortDateString();
            }
        }
    }
}
