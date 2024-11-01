using Guna.UI2.WinForms;
using Store.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Store.Business.clsUser;
using static System.Net.Mime.MediaTypeNames;

namespace Store
{
    public partial class frmCreateAccount : Form
    {
        public Action OnClickLogin; 
        public Action OnClickSignUp;
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnNextStage1_Click(object sender, EventArgs e)
        {
            
            lblVerifyPassword.Visible = tbPassword.Text.Trim() != tbVerificationPassword.Text.Trim() ||
                (string.IsNullOrEmpty(tbPassword.Text.Trim()) && string.IsNullOrEmpty(tbVerificationPassword.Text.Trim()));
            lblEmailRequired.Visible = string.IsNullOrEmpty(tbEmail.Text);
            //if a password is correct and email is full , go to page 2
            if (!lblVerifyPassword.Visible && !lblEmailRequired.Visible)
            {
                guna2TabControl1.SelectTab(1);
            }
        }

        private void lblLoginStage1_Click(object sender, EventArgs e)
        {
            OnClickLogin?.Invoke();
        }

        private void btnSignInStage1_Click(object sender, EventArgs e)
        {
            clsCustomer customer = new clsCustomer();
            
            
            customer.TypeInhertance= _enTypeInhertance.Cusotmer;////

            customer.Email = tbEmail.Text.Trim();

 

            customer.Password= clsUtility.ComputeHash(tbPassword.Text.Trim());// Encrption to Hash

            customer.FirstName = tbFirstName.Text.Trim();
            customer.LastName = tbLastName.Text.Trim();
            customer.PhoneNumber= tbPhone.Text.Trim();
            customer.RegionId = ((KeyValuePair<int, string>)cbCities.SelectedItem).Key;

            if (customer.Save())
            {
                MessageBox.Show("Done add successfully");
                OnClickSignUp?.Invoke();
            }
            else
                MessageBox.Show("The addition was not successful","Error " ,MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void btnNextStage2_Click(object sender, EventArgs e)
        {
            lblCheckTheFields.Visible = string.IsNullOrEmpty(tbFirstName.Text.Trim())
                || string.IsNullOrEmpty(tbLastName.Text.Trim())
                || string.IsNullOrEmpty(tbPhone.Text.Trim());

            //If all fields are filled, go to page 3
            if (!lblCheckTheFields.Visible)
            {
                guna2TabControl1.SelectTab(2);
            }
           
        }

        private void btnPreviousStage2_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(0);
        }

        private void btnPreviousStage3_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(1);
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            var countries = clsAddress.GetAllCountries().ToList();
            cbCountries.DataSource = countries;
            cbCountries.DisplayMember = "Value";
            cbCountries.ValueMember = "Key";
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbCities.DataSource = clsAddress.GetAllCities(((KeyValuePair<int, string>)cbCountries.SelectedItem).Key).ToList();
            cbCities.DisplayMember = "Value";
            cbCities.ValueMember = "Key";
       
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRegions.DataSource = clsAddress.GetAllRegions(((KeyValuePair<int, string>)cbCities.SelectedItem).Key).ToList();
            cbRegions.DisplayMember = "Value";
            cbRegions.ValueMember = "Key";
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            //Muhammedajaj@gmail.com
            lblThisEmailIsInvalid.Visible = !( btnNextStage1.Visible = !clsUser.IsExistsEmail(tbEmail.Text.Trim()));
            lblEmailRequired.Visible = string.IsNullOrEmpty(tbEmail.Text);
        }

        private void btnShow_Hide_Click(object sender, EventArgs e)
        {
            //This code works with tbPassword ,tbVerificationPassword
           
            /*
                Verification is done through the sending object.
                If he presses btnShow_Hide, Text points to tbPassword,
                and if he presses btnShow_Hide_verification,
                Text points to tbVerificationPassword.
             
            */

            Guna2TextBox Text  = ((Button)sender).Name == "btnShow_Hide" ? tbPassword: tbVerificationPassword;
           

            if (Text.UseSystemPasswordChar)
            {
                //is work when a password is hidden
                Text.UseSystemPasswordChar = false;
                Text.PasswordChar = '\0';
                ((Button)sender).Image = Properties.Resources.hide_3_;

            }
            else
            {
                //is work when a password is shown
                Text.UseSystemPasswordChar = true;
                ((Button)sender).Image = Properties.Resources.show;
            }
        }

    }
}
