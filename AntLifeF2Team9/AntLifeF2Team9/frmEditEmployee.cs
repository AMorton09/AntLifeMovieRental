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
    public partial class frmEditEmployee : Form
    {
        frmCreateAccount addAccount = new frmCreateAccount();
        
        User editedUser = new User();
        
        public frmEditEmployee()
        {
            InitializeComponent();
        }


        #region Methods for Validation
        public bool firstNameCheck()
        {
            string textNameF = textBoxFirstName.Text;

            if (textNameF != "")
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
     
        #endregion Methods for Validation


        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text.Equals("CA"))
            {

                comboBoxStates.DataSource = addAccount.dictProvinces.Keys.ToArray();
                labelState.Text = "Province";
                textBoxZip.MaxLength = 7;

            }
            if (comboBoxCountry.Text.Equals("US"))
            {
                comboBoxStates.DataSource = addAccount.dictStates.Keys.ToArray();
                labelState.Text = "State";
                textBoxZip.MaxLength = 5;

            }
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

            editedUser = (User)Tag;
            comboBoxStates.DataSource = addAccount.dictStates.Keys.ToArray();
            comboBoxCountry.DataSource = addAccount.dictCountry.Keys.ToArray();

            textBoxAddress.Text = editedUser.address;
            textBoxCity.Text = editedUser.city;
            textBoxEmail.Text = editedUser.email;
            textBoxFirstName.Text = editedUser.firstName;
            textBoxLastName.Text = editedUser.lastName;
            textBoxZip.Text = editedUser.zip;
            comboBoxCountry.SelectedItem = null;
            comboBoxStates.SelectedItem = null;
        }

        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            bool validFName = firstNameCheck();
            bool validLName;
            bool validAddress;
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
                goodToGo = zipCheck();
            else return;
            


            if (goodToGo)
            {

                if (textBoxEmail.Text.Equals(textBoxConfirmEmail.Text))
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(_cnDB))
                        {

                            using (SqlCommand cmd = new SqlCommand("usp_EditAccount", cn))
                            {



                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = editedUser.userID;
                                cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 25).Value = textBoxFirstName.Text;
                                cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 25).Value = textBoxLastName.Text;
                                cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = textBoxAddress.Text;
                                cmd.Parameters.Add("@city", SqlDbType.VarChar, 25).Value = textBoxCity.Text;
                                cmd.Parameters.Add("@zip", SqlDbType.VarChar, 7).Value = textBoxZip.Text;
                                cmd.Parameters.Add("@state", SqlDbType.VarChar, 30).Value = addAccount.dictStates[comboBoxStates.Text];
                                cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = addAccount.dictCountry[comboBoxCountry.Text];
                                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = textBoxEmail.Text;


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
                    frmManageEmp manageEmployeeForm = new frmManageEmp();
                    Hide();
                    manageEmployeeForm.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Please make sure your emails match");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            frmManageEmp manageEmployeeForm = new frmManageEmp();
            Hide();
            manageEmployeeForm.ShowDialog();
            Close();
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
