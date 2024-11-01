using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class frmProfileMenu : Form
    {
        public Action OnDoneLogged;
        public Action OnBasketClick;
        public Action OnSignOutClick;
        public frmProfileMenu()
        {
            InitializeComponent();
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            _resize();
            this.Close();
        }
        private  void _resize()
        {
            int Width = this.Size.Width;
            for (int NewHeight = this.Size.Height - 10; NewHeight > 0; NewHeight-=10) 
            {
                Thread.Sleep(10);
                this.Size = new Size(Width, NewHeight);
            }
        }
       
        private void frmProfileMenu_MouseLeave(object sender, EventArgs e)
        {   // this.ClientRectangle => Form Space
            // Control.MousePosition => Mouse location
            // PointToClient => تحويل الى الاحداثيات
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                // إذا كان الماوس قد غادر الفورم الابن، قم بإغلاقه
                _resize();
                this.Close();
            }
        }

        private void frmProfileMenu_Load(object sender, EventArgs e)
        {
                lblLogin_Or_Create.Visible = Global.Customer == null;
                lblSignOut.Visible = !lblLogin_Or_Create.Visible;

        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            else
                //When he logs in, we send an event to the
                //main form, through which a form for modifying customer information opens
                OnDoneLogged?.Invoke();
            pbClose_Click(null,null);
        }

        private void lblBasket_Click(object sender, EventArgs e)
        {
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            else
            {
                pbClose_Click(null, null);

                //When he logs in, we send an event to the main form,
                //through which the basket form opens
                OnBasketClick?.Invoke();
            }
        }

        private void lblPurchases_Click(object sender, EventArgs e)
        {
            //Log in if you are not logged in
            if (!clsUtility.IsLogged())
                return;
            else
            {
                pbClose_Click(null, null);
                
                frmMyPurchases frm = new frmMyPurchases();
                frm.ShowDialog();
            }
        }

        private void lblLogin_Or_Create_Click(object sender, EventArgs e)
        {
            pbClose_Click(null, null);
            frmLoginOrCreate frm = new frmLoginOrCreate();
            frm.ShowDialog();
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                pbClose_Click(null, null);

                OnSignOutClick?.Invoke();
            }
        }
    }
}
