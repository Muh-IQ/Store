using Guna.UI2.WinForms;
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
    public partial class frmLogin : Form
    {
        public Action  OnClickSingUp ;
        public Action OnIsItsLogged;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            OnClickSingUp?.Invoke();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = tbEmail.Text.Trim();
            string EncryptedPassword = clsUtility.ComputeHash(tbPassword.Text.Trim());

            clsCustomer customer =  clsCustomer.FindCustomerByEmailAndPassword(Email, EncryptedPassword);
            if (customer != null) 
            {
                if(chbRememberMe.Checked) 
                {
                    clsUtility.WriteRegisterForRememberMe(Email, tbPassword.Text.Trim());
                }
                Global.Customer= customer;

                OnIsItsLogged?.Invoke();//Logged in event

                //Event: The customer information has been uploaded so that the information can be modified in the main form
                Global.OnLoadCustomerData?.Invoke();
            }
            else 
            {
                MessageBox.Show("Incorrect email or  password ","Access",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var Data = clsUtility.ReadRegisterForRememberMe();
            if (Data.IsRead)
            {
                tbEmail.Text = Data.Email;
                tbPassword.Text = Data.Password;
            }
        }

        private void btnShow_Hide_Click(object sender, EventArgs e)
        {

            if (tbPassword.UseSystemPasswordChar)
            {
                //is work when a password is hidden
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.PasswordChar = '\0';
                btnShow_Hide.Image = Properties.Resources.hide_3_;

            }
            else
            {
                //is work when a password is shown
                tbPassword.UseSystemPasswordChar = true;
                btnShow_Hide.Image = Properties.Resources.show;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");
        }
    }
}
