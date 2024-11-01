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
    public partial class frmEditCustomerData : Form
    {
        private enum _enModeSize { Max = 1, Min = 2 }
        _enModeSize _enMode;
        public frmEditCustomerData()
        {
            InitializeComponent();
        }

        private void frmEditCustomerData_Load(object sender, EventArgs e)
        {
            pnlYourInfo.Size = new System.Drawing.Size(1312, 65);
            pnlAddress.Size = new System.Drawing.Size(1312, 65);
            pnlYourInfo.Tag = _enModeSize.Min;
            pnlAddress.Tag = _enModeSize.Min;
            pnlPassword.Tag = _enModeSize.Max;

            btnUpdate.Location = new System.Drawing.Point(295, 221);


            _LoadData();
        }

        private void _LoadData()
        {
            tbFirstName.Text = Global.Customer.FirstName;
            tbLastName.Text = Global.Customer.LastName;
            tbPhone.Text = Global.Customer.PhoneNumber;
            _LoadAddress();
        }

        private void _LoadAddress()
        {
            cbCountries.DataSource = clsAddress.GetAllCountries().ToList(); ;
            cbCountries.DisplayMember = "Value";
            cbCountries.ValueMember = "Key";
            cbCountries.SelectedValue = Global.Customer.AddressInfo.CountryID;


            cbCities.DataSource = clsAddress.GetAllCities(Global.Customer.AddressInfo.CountryID).ToList();
            cbCities.DisplayMember = "Value";
            cbCities.ValueMember = "Key";
            cbCities.SelectedValue = Global.Customer.AddressInfo.CityID;

            var Regions = clsAddress.GetAllRegions(Global.Customer.AddressInfo.CityID).ToList();
            cbRegions.DataSource = Regions;
            cbRegions.DisplayMember = "Value";
            cbRegions.ValueMember = "Key";


            cbRegions.SelectedValue = Global.Customer.RegionId;

            // It should edit it
            // create by MOhammed ajaj 24/4/19
            //short Counter = 0;
            //foreach (KeyValuePair<int, string> region in Regions)
            //{
            //    if (region.Key == Global.Customer.RegionId)
            //    {
            //        cbRegions.SelectedIndex = Counter;
            //    }
            //    Counter++;
            //}
        }
        private void pnlYourInfo_Click(object sender, EventArgs e)
        {
            btnUpdate.Location = new System.Drawing.Point(295, 202);
            if ((_enModeSize)pnlYourInfo.Tag == _enModeSize.Min)
            {
                pnlYourInfo.Size = new System.Drawing.Size(1312, 190);
                pnlYourInfo.Tag = _enModeSize.Max;

                pnlAddress.Size = new System.Drawing.Size(1312, 65);
                pnlPassword.Size = new System.Drawing.Size(1312, 65);

                pnlAddress.Tag = _enModeSize.Min;
                pnlPassword.Tag = _enModeSize.Min;
            }
            else
            {
                pnlYourInfo.Size = new System.Drawing.Size(1312, 65);
                pnlYourInfo.Tag = _enModeSize.Min;

                pnlPassword.Size = new System.Drawing.Size(1312, 190);
                pnlPassword.Tag = _enModeSize.Max;
            }
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            btnUpdate.Location = new System.Drawing.Point(295, 202);

            if ((_enModeSize)pnlPassword.Tag == _enModeSize.Min)
            {
                pnlPassword.Size = new System.Drawing.Size(1312, 190);
                pnlPassword.Tag = _enModeSize.Max;

                pnlAddress.Size = new System.Drawing.Size(1312, 65);
                pnlYourInfo.Size = new System.Drawing.Size(1312, 65);

                pnlAddress.Tag = _enModeSize.Min;
                pnlYourInfo.Tag = _enModeSize.Min;
            }
            else
            {
                pnlPassword.Size = new System.Drawing.Size(1312, 65);
                pnlPassword.Tag = _enModeSize.Min;

                pnlYourInfo.Size = new System.Drawing.Size(1312, 190);
                pnlYourInfo.Tag = _enModeSize.Max;
            }
        }

        private void pnlAddress_Click(object sender, EventArgs e)
        {
            btnUpdate.Location = new System.Drawing.Point(295, 202);

            if ((_enModeSize)pnlAddress.Tag == _enModeSize.Min)
            {
                pnlAddress.Size = new System.Drawing.Size(1312, 190);
                pnlAddress.Tag = _enModeSize.Max;

                pnlPassword.Size = new System.Drawing.Size(1312, 65);
                pnlYourInfo.Size = new System.Drawing.Size(1312, 65);

                pnlPassword.Tag = _enModeSize.Min;
                pnlYourInfo.Tag = _enModeSize.Min;
            }
            else
            {
                pnlAddress.Size = new System.Drawing.Size(1312, 65);
                pnlAddress.Tag = _enModeSize.Min;

                pnlYourInfo.Size = new System.Drawing.Size(1312, 190);
                pnlYourInfo.Tag = _enModeSize.Max;
            }
        }


        private void chbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.Customer.TypeInhertance != clsUser._enTypeInhertance.Cusotmer && Global.Customer.TypeInhertance != clsUser._enTypeInhertance.Seller && Global.Customer.TypeInhertance != clsUser._enTypeInhertance.owner)
            {
                lblWarning.Visible = true;
            }
            else
            {
                lblWarning.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve the customer object from the global variable
            clsCustomer Customer = Global.Customer;

            // Check if no checkboxes are selected
            if (!chbPassword.Checked && !chbAddress.Checked && !chbYourInfo.Checked)
            {
                MessageBox.Show("You must select at least one section!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }



             //** Only selected sections are updated
            
            // Check if password checkbox is checked
            if (chbPassword.Checked)
            {
                if (!_CheckPassword())
                    return;

                // Update the password with its hash value
                Customer.Password = clsUtility.ComputeHash(tbPassword.Text.Trim());
            }

            // Check if address checkbox is checked
            if (chbAddress.Checked)
            {
                // Update the region ID with the selected city's ID
                Customer.RegionId = ((KeyValuePair<int, string>)cbCities.SelectedItem).Key;
            }

            // Check if personal information checkbox is checked
            if (chbYourInfo.Checked)
            {
                // Update the customer's personal information
                Customer.FirstName = tbFirstName.Text.Trim();
                Customer.LastName = tbLastName.Text.Trim();
                Customer.PhoneNumber = tbPhone.Text.Trim();
            }

            // Save the changes to the customer object
            if (Customer.Save())
            {
                MessageBox.Show("Modified successfully"); // Display success message
                Global.OnLoadCustomerData?.Invoke(); // Invoke the event to reload customer data
            }
            else
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display error message
            }
        }

        private bool _CheckPassword()
        {

            // Validate the old password
            if (clsUtility.ComputeHash(tbOldPassword.Text.Trim()) != Global.Customer.Password)
            {
                MessageBox.Show("The old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text) && string.IsNullOrWhiteSpace(tbVerificationPassword.Text))
            {
                MessageBox.Show("The password cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //Verify that the passwords match
            if (tbPassword.Text != tbVerificationPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method
            }
            return true;
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

        private void btnShow_Hide_Click(object sender, EventArgs e)
        {
            //This code works with tbPassword ,tbVerificationPassword

            /*
                Verification is done through the sending object.
                If btnShow_Hide is pressed, the text points to tbPassword.

                If he presses btnShow_Hide_verification,
                The text refers to tbVerificationPassword.

                If btnShow_Hide_Old is pressed,
                The text points to tbOldPassword
            */

            Guna2TextBox Text = ((Button)sender).Name == "btnShow_Hide" ? tbPassword : ((Button)sender).Name == "btnShow_Hide_verification" ? tbVerificationPassword : tbOldPassword;


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

      
        private void _VerifyPasswordsMatch()
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text) && string.IsNullOrWhiteSpace(tbVerificationPassword.Text))
            {
                pbMatchPassword.Visible = false;
                pbMatchPasswordVerification.Visible = false;
                return;
            }

            if (tbPassword.Text != tbVerificationPassword.Text)
            {
                pbMatchPassword.Visible = true;
                pbMatchPasswordVerification.Visible = true;
                pbMatchPassword.Image = Properties.Resources.delete;
                pbMatchPasswordVerification.Image = Properties.Resources.delete;
                return; // Exit the method
            }
            else
            {
                pbMatchPassword.Image = Properties.Resources.circle;
                pbMatchPasswordVerification.Image = Properties.Resources.circle;
            }
        }
        
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            _VerifyPasswordsMatch();
        }

        private void tbVerificationPassword_TextChanged(object sender, EventArgs e)
        {
            _VerifyPasswordsMatch();
        }
    }
}
