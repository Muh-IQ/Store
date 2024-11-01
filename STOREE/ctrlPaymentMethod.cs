using Guna.UI2.WinForms;
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
    public partial class ctrlPaymentMethod : UserControl
    {
        public string PaymentMethod = null;
        public ctrlPaymentMethod()
        {
            InitializeComponent();
        }



        private void PaymentOnDelivery_Click(object sender, EventArgs e)
        {
            pnlCard.Size = new System.Drawing.Size(800, 55);
            PaymentMethod = "Payment On Delivery";
            pnlPaymentOnDelivery.Size = new System.Drawing.Size(800, 166);
            rbPaymentOnDelivery.Checked = true;
            rbCard.Checked = false;
        }

        private void Card_Click(object sender, EventArgs e)
        {
            PaymentMethod = "Card";
            pnlPaymentOnDelivery.Size = new System.Drawing.Size(800, 55);
            pnlCard.Size = new System.Drawing.Size(800, 166);
            rbPaymentOnDelivery.Checked = false;
            rbCard.Checked = true;
        }
 

        private void ctrlPaymentMethod_Load(object sender, EventArgs e)
        {
            Card_Click(null, null); 
        }


    }
}
