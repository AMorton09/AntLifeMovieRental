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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
          
        }
        User currentUser = new User();
        string emailEntry;


        private void labelLoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxEmail.Select();
        }

        frmCreateAccount createAccount = new frmCreateAccount();

        private void linkLabelNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            createAccount.ShowDialog();
        }
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;

        public bool nameCheck()
        {
            string textName = textBoxEmail.Text;

            if (textName != "")
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Email.", "Input Error");

                textBoxEmail.Clear();
                textBoxEmail.Focus();

                return false;
            }
        }
        public bool passCheck()
        {
            string textPass = textBoxPassword.Text;

            if (textPass != "")
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Password.", "Input Error");

                textBoxPassword.Clear();
                textBoxPassword.Focus();

                return false;
            }
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            emailEntry = textBoxEmail.Text;
            string passwordEntry = textBoxPassword.Text;
            bool checkName = nameCheck();
            bool checkPass2;
            bool goodToGo;
            if (checkName)
            {
                checkPass2 = passCheck();
            }
            else return;
            if(checkPass2)
            {
                goodToGo = true;
            }

            else goodToGo = false;

            if (goodToGo)
            {
               

                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_GetUser", cn))
                        {


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = emailEntry;


                            cn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    currentUser.userID = reader.GetInt32(0);
                                    currentUser.firstName = reader.GetString(1);
                                    currentUser.lastName = reader.GetString(2);
                                    currentUser.address = reader.GetString(3);
                                    currentUser.city = reader.GetString(4);
                                    currentUser.zip = reader.GetString(5);
                                    currentUser.state = reader.GetString(6);
                                    currentUser.country = reader.GetString(7);
                                    currentUser.email = reader.GetString(8);
                                    currentUser.passwordHash = reader.GetString(9);
                                    currentUser.passwordSalt = reader.GetString(10);
                                    currentUser.membershipLevel = reader.GetString(11);
                                    string employeeString = reader.GetString(12);
                                    currentUser.expDate = Convert.ToString(reader.GetDateTime(13));
                                    currentUser.amountSpent = Convert.ToDouble(reader["amountSpent"]);
                                    if (employeeString.Equals("No"))
                                    {
                                        currentUser.employee = false;
                                    }
                                    else if (employeeString.Equals("Yes"))
                                    {
                                        currentUser.employee = true;
                                    }
                                }
                            }

                            reader.Close();
                            cn.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
                }

                if (currentUser.userID != 0)
                {

                    byte[] passwordEntryByte = Encoding.ASCII.GetBytes(passwordEntry);
                    byte[] shaPasswordEntry = createAccount.EncryptSha256(passwordEntryByte, Convert.FromBase64String(currentUser.passwordSalt));

                    if (checkPass(currentUser.passwordHash, Convert.ToBase64String(shaPasswordEntry)))
                    {

                        if (currentUser.employee)
                        {
                            this.Hide();
                            frmEmployee emp = new frmEmployee();
                            emp.Tag = currentUser;
                            emp.ShowDialog();
                            this.Close();
                        }
                        else if (!currentUser.employee)
                        {
                            
                            updateMemStatus();
                            getUser();
                            this.Hide();
                            frmCustomer cust = new frmCustomer();
                            cust.Tag = currentUser;
                            cust.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show("Please check your email");
                }


            }
        }


        private bool checkPass(string s1, string s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }
            else return false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
        }

        private void getUser()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetUser", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = emailEntry;


                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                currentUser.userID = reader.GetInt32(0);
                                currentUser.firstName = reader.GetString(1);
                                currentUser.lastName = reader.GetString(2);
                                currentUser.address = reader.GetString(3);
                                currentUser.city = reader.GetString(4);
                                currentUser.zip = reader.GetString(5);
                                currentUser.state = reader.GetString(6);
                                currentUser.country = reader.GetString(7);
                                currentUser.email = reader.GetString(8);
                                currentUser.passwordHash = reader.GetString(9);
                                currentUser.passwordSalt = reader.GetString(10);
                                currentUser.membershipLevel = reader.GetString(11);
                                string employeeString = reader.GetString(12);
                                currentUser.expDate = Convert.ToString(reader.GetDateTime(13));
                                currentUser.amountSpent = Convert.ToDouble(reader["amountSpent"]);
                                if (employeeString.Equals("No"))
                                {
                                    currentUser.employee = false;
                                }
                                else if (employeeString.Equals("Yes"))
                                {
                                    currentUser.employee = true;
                                }
                            }
                        }

                        reader.Close();
                        cn.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }

        private void updateMemStatus()
        {
            string lvl;
            if (currentUser.amountSpent > 5000 && !currentUser.membershipLevel.Equals("None"))
            {
                lvl = "Silver";
                updateMemLvl(lvl);
            }
            else if (currentUser.amountSpent > 20000 && !currentUser.membershipLevel.Equals("None"))
            {
                lvl = "Gold";
                updateMemLvl(lvl);
            }
        }

        private void updateMemLvl(string lvl)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateAccountMembershipLevel", cn))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                        cmd.Parameters.Add("@memLvl", SqlDbType.VarChar, 15).Value = lvl;


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
        //forgot pass
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword pass = new frmForgotPassword();
            pass.ShowDialog();
        }
    }
}
