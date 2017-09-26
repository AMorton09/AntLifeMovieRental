using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AntLifeF2Team9
{
    public partial class frmAddNewEmployee : Form
    {

        frmCreateAccount newAccountForm = new frmCreateAccount();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        public frmAddNewEmployee()
        {
            InitializeComponent();

            comboBoxStates.DataSource = newAccountForm.dictStates.Keys.ToArray();

            comboBoxCountry.DataSource = newAccountForm.dictCountry.Keys.ToArray();


        }
        #region Methods for Validation
        public bool firstNameCheck()
        {
            string textNameF = textBoxFirstName.Text;

            if (textNameF !="")
                return true;
            else
            {
                    MessageBox.Show("Please enter a valid First Name.", "Input Error");
               
                    textBoxFirstName.Clear();
                    textBoxFirstName.Focus();
              
                return false;
            }

        }
        public bool lastNameCheck()
        {
            string textNameL = textBoxLastName.Text;

            if (textNameL != "")
                return true;
            else
            {
             
                    MessageBox.Show("Please enter a valid Last Name.", "Input Error");
            
                    textBoxLastName.Clear();
                    textBoxLastName.Focus();
                return false;
            }
        }
        public bool addressCheck()
        {
            string address = textBoxAddress.Text;

            if (address != "")
                return true;
            else
           
                    MessageBox.Show("Please enter a valid First Name.", "Input Error");
              
                    textBoxAddress.Clear();
                    textBoxAddress.Focus();
            return false;
            }
        public bool cityCheck()
        {
            string city = textBoxCity.Text;

            if (city != "")
                return true;
            else
            {
                
                    MessageBox.Show("Please enter a valid City.", "Input Error");
             
                    textBoxCity.Clear();
                    textBoxCity.Focus();
                
                return false;
            }
        }
        public bool zipCheck()
        {
            if (comboBoxCountry.Text == "US")
            {
                if (textBoxZip.Text.Length == 5)
                    return true;
                else
                {
                    try
                    {
                        throw new Exception("Please enter a valid Zip Code(5 Characters).");
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Zip Code(5 Characters).", "Input Error");
                    }
                    finally
                    {
                        textBoxZip.Clear();
                        textBoxZip.Focus();
                    }
                    return false;
                }

            }
            else
                     if (comboBoxCountry.Text == "CA")
            {
                if (textBoxZip.Text.Length == 7)
                    return true;
                else
                {
                    try
                    {
                        throw new Exception("Please enter a valid Zip Code(7 Characters).");
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Zip Code(7 Characters).", "Input Error");
                    }
                    finally
                    {
                        textBoxZip.Clear();
                        textBoxZip.Focus();
                    }
                    return false;


                }
            }
            else
                return false;
        
    }
        public bool passCheck()
        {
            if (textBoxPassword.Text.Length >7)
                return true;
            else
            {
                try
                {
                    throw new Exception("Password must be atleast 8 characters.");
                }
                catch
                {
                    MessageBox.Show("Password must be atleast 8 characters.", "Input Error");
                }
                finally
                {
                    textBoxPassword.Clear();
                    textBoxConfirmPassword.Clear();
                    textBoxPassword.Focus();
                }
                return false;
            }
        }
        #endregion Methods for Validation
        #region Button Clicks
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
           
            string fName;
            string lName;
            string address;
            string city;
            string state;
            string zip;
            string country;
            string email;
            string confirmEmail;
            string plainTxtPassword;
            byte[] passwordHashByte;
            byte[] passwordSaltByte;
            string confirmPassword;
            string passwordHash;
            string passwordSalt;
            bool validFName = firstNameCheck();
            bool validLName;
            bool validAddress;
            bool validZip;
            bool validCity;
            bool goodToGo;

            if (validFName)
                validLName = lastNameCheck();
            else return;

            if (validLName)
                validAddress = addressCheck();
            else return;

            if (validAddress)
                validCity = cityCheck();
            else return;
            if (validCity)
                validZip = zipCheck();
            else return;
            if (validZip)
            {
                goodToGo = passCheck();
               
            }
            else return;
            

            if (goodToGo)
            { 
            fName = textBoxFirstName.Text;
            lName = textBoxLastName.Text;
            address = textBoxAddress.Text;
            city = textBoxCity.Text;
                if (comboBoxCountry.Text == "US")
                {
                    state = newAccountForm.dictStates[comboBoxStates.Text];
                }
                else
                {
                    state = newAccountForm.dictProvinces[comboBoxStates.Text];
                }
               

            confirmPassword = textBoxConfirmPassword.Text;
            confirmEmail = textBoxConfirmEmail.Text;

            zip = textBoxZip.Text;
            country = newAccountForm.dictCountry[comboBoxCountry.Text];
            email = textBoxEmail.Text;
            plainTxtPassword = textBoxPassword.Text;





            passwordSaltByte = newAccountForm.CreateSalt();
            byte[] plainTxtPasswordByte = Encoding.ASCII.GetBytes(plainTxtPassword);
            byte[] saltByte = newAccountForm.CreateSalt();
            passwordHashByte = newAccountForm.EncryptSha256(plainTxtPasswordByte, saltByte);
            passwordSalt = Convert.ToBase64String(saltByte);
            passwordHash = Convert.ToBase64String(passwordHashByte);

            if (email.Equals(confirmEmail) && plainTxtPassword.Equals(confirmPassword))
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_AddAccount", cn))
                        {


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 25).Value = fName;
                            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 25).Value = lName;
                            cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = address;
                            cmd.Parameters.Add("@city", SqlDbType.VarChar, 25).Value = city;
                            cmd.Parameters.Add("@zip", SqlDbType.VarChar, 7).Value = zip;
                            cmd.Parameters.Add("@state", SqlDbType.VarChar, 30).Value = state;
                            cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = country;
                            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                            cmd.Parameters.Add("@passwordHash", SqlDbType.VarChar, 256).Value = passwordHash;
                            cmd.Parameters.Add("@passwordSalt", SqlDbType.VarChar, 256).Value = passwordSalt;
                            cmd.Parameters.Add("@membershipLevel", SqlDbType.VarChar, 15).Value = "None";
                            cmd.Parameters.Add("@employee", SqlDbType.VarChar, 3).Value = "Yes";
                            cmd.Parameters.Add("@expDate", SqlDbType.Date, 20).Value = "0001-01-01";
                            cmd.Parameters.Add("@amountSpent", SqlDbType.VarChar, 3).Value = "0";
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
                }

            }

                Hide();
                frmManageEmp manageEmp = new frmManageEmp();
                manageEmp.ShowDialog();
                Close();
        }


        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Button Clicks
        #region Event Handlers
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text.Equals("CA"))
            {

                comboBoxStates.DataSource = newAccountForm.dictProvinces.Keys.ToArray();
                labelState.Text = "Province";
                textBoxZip.MaxLength = 7;

            }
            if (comboBoxCountry.Text.Equals("US"))
            {
                comboBoxStates.DataSource = newAccountForm.dictStates.Keys.ToArray();
                labelState.Text = "State";
                textBoxZip.MaxLength = 5;

            }
        }
        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBoxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxCountry.Text.Equals("US"))
            {
                e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
        }

        #endregion Event Handlers

        #region Extra Clicks
        private void labelCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
        
        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
        }
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
           
        }



        #endregion Extra Clicks

        
    } 
}

