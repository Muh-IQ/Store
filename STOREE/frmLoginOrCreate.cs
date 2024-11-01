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
    public partial class frmLoginOrCreate : Form
    {
        public frmLoginOrCreate()
        {
            InitializeComponent();
        }
        private void _OpenfrmCreateAccount()
        {
            frmCreateAccount frm2 = new frmCreateAccount();
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            frm2.OnClickLogin = null;
            frm2.OnClickSignUp = null;
            frm2.OnClickLogin += _OpenfrmLogin;
            frm2.OnClickSignUp += _OpenfrmLogin; //go to form login after create account
            pnlCreateAccount.Controls.Add(frm2);
            pnlLogin.Controls.Clear();
            this.Text = "Create Account";
        }

        private void _OpenfrmLogin()
        {
            frmLogin frm = new frmLogin();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.OnClickSingUp = null;
            frm.OnClickSingUp += _OpenfrmCreateAccount;
            frm.OnIsItsLogged += _CloseThisForm;//بعد نجاح تسجيل الدخول نغلق هذه الفورم
            pnlLogin.Controls.Add(frm);
            pnlCreateAccount.Controls.Clear();
            this.Text = "Login";


        }
        private void frmLoginOrCreate_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.OnClickSingUp += _OpenfrmCreateAccount;
            frm.OnIsItsLogged += _CloseThisForm;
            pnlLogin.Controls.Add(frm);
        }

        private void _CloseThisForm()
        {
            this.Close();
        }
    }
}
