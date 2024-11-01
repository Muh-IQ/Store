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
    public partial class frmMyPurchases : Form
    {
        private int _PageNumber = 0;

        private int _VisibleCrtlCount = 0;
        private int _MyPurchasesCount = 0;

        public frmMyPurchases()
        {
            InitializeComponent();
        }

        private void frmMyPurchases_Load(object sender, EventArgs e)
        {
            //get total count
            _MyPurchasesCount = clsOrderItem.GetOrderItemCountForMyPurchases((int)Global.Customer.CustomerID);
            
            DataTable data = clsOrder.GetPageInfoForOrderItemAndOrderAndPayment((int)Global.Customer.CustomerID, ++_PageNumber);
            _VisibleCrtlCount += data.Rows.Count;

            foreach (DataRow row in data.Rows) 
            {
                flpPurchasedProduct.Controls.Add(_GenerateCtrl((int)row["OrderItemID"], (string)row["PaymentMethod"], (DateTime)row["OrderDateTime"]));
            }

            lblShowMore.Visible = !(_VisibleCrtlCount == _MyPurchasesCount);

        }

        private ctrlPurchasedProduct _GenerateCtrl(int OrderItem,string PaymentMethod,DateTime date )
        {
            ctrlPurchasedProduct ctrl = new ctrlPurchasedProduct();
            ctrl.PaymentMethod = PaymentMethod;
            ctrl.Date = date;
            ctrl.LoadData(OrderItem);
            return ctrl;    
        }

        private void lblShowMore_Click(object sender, EventArgs e)
        {

            DataTable data = clsOrder.GetPageInfoForOrderItemAndOrderAndPayment((int)Global.Customer.CustomerID, ++_PageNumber);
            _VisibleCrtlCount += data.Rows.Count;

            foreach (DataRow row in data.Rows)
            {
                flpPurchasedProduct.Controls.Add(_GenerateCtrl((int)row["OrderItemID"], (string)row["PaymentMethod"], (DateTime)row["OrderDateTime"]));
            }

            lblShowMore.Visible = !(_VisibleCrtlCount == _MyPurchasesCount);
        }
    }
}
