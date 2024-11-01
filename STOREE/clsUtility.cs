using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Store
{
    public class clsUtility
    {
        /// <summary>
        /// Encryption value use hash
        /// </summary>
        /// <param name="Value"> input  Value</param>
        /// <returns> Encrypted Value </returns>
        public static string ComputeHash(string Value)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] SHAbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Value));
                return BitConverter.ToString(SHAbytes).Replace("-", "").ToUpper();
            }
        }

        /// <summary>
        /// Writes the email and password to the Windows Registry under the specified key path for Remember Me feature.
        /// </summary>
        /// <param name="Email">The email to be stored in the Registry.</param>
        /// <param name="Password">The password to be stored in the Registry.</param>
        /// <param name="keyPath">The Registry key path where the values will be stored. Default is @"HKEY_CURRENT_USER\SOFTWARE\STORE".</param>
        /// <returns>Returns true if both values are successfully written to the Registry; otherwise, false.</returns>
        public static bool WriteRegisterForRememberMe(string Email, string Password, string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\STORE")
        {
            return WriteRegister("Email", Email, keyPath) && WriteRegister("Password", Password, keyPath);
        }

        /// <summary>
        /// Writes a value to the Windows Registry under the specified key path.
        /// </summary>
        /// <param name="valueName">The name of the value to be stored in the Registry.</param>
        /// <param name="valueData">The data to be stored in the Registry.</param>
        /// <param name="keyPath">The Registry key path where the value will be stored. Default is @"HKEY_CURRENT_USER\SOFTWARE\STORE".</param>
        /// <returns>Returns true if the value is successfully written to the Registry; otherwise, false.</returns>
        public static bool WriteRegister(string valueName, string valueData, string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\STORE")
        {
            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
            return true;
        }
       
        public static (bool IsRead, string Email, string Password) ReadRegisterForRememberMe( string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\STORE")
        {
            string Email = null,  Password = null;
            return (ReadRegister("Email", ref Email, keyPath) && ReadRegister("Password", ref Password, keyPath), Email, Password);
        }
        public static bool ReadRegister(string valueName,ref  string valueData, string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\STORE")
        {
            try
            {
                return (valueData = Registry.GetValue(keyPath, valueName, null) as string) != null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool IsLogged()
        {
            if (Global.Customer != null)
                return true;
            if (MessageBox.Show("Log in first to open the procedure", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmLoginOrCreate frm = new frmLoginOrCreate();
                frm.ShowDialog();
            }
            return Global.Customer != null;
        }
    }
}
