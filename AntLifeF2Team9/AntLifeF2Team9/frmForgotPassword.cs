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
using System.Net.Mail;
using System.Net;


namespace AntLifeF2Team9
{
   
    public partial class frmForgotPassword : Form
    {
        User currentUser = new User();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        string code;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {

            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                buttonReset.Enabled = false;

            }
            else buttonReset.Enabled = true;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            getUser(textBoxEmail.Text);
            try
            {
                if (!currentUser.userID.Equals(0))
                {
                    MailAddress userMail = new MailAddress(textBoxEmail.Text, currentUser.firstName+" "+currentUser.lastName);
                    Random rng = new Random();
                    int resetCode = rng.Next(0, 999999);
                    code = resetCode.ToString("000000");
                    sendEmail(userMail,code);
                }
                else
                {
                    MessageBox.Show("This email does not exist. Please create an account.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please ensure that your email is in the correct format.");
            
            }
            
        }
        private void sendEmail(MailAddress userMail, string code)
        {
            MailAddress fromAddress = new MailAddress("AntLifeRecovery@gmail.com", "Ant Life Support");
            
            const string fromPassword = "#RollTide!";
            const string subject = "Password Recovery Code";
            string body = currentUser.firstName+" "+currentUser.lastName+" Your Password Reset Code is "+code.ToString()+" Please enter this code into the kiosk";

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (MailMessage message = new MailMessage(fromAddress, userMail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        private void getUser(string emailEntry)
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            string userEntry = textBoxNum1.Text + textBoxNum2.Text + textBoxNum3.Text + textBoxNum4.Text + textBoxNum5.Text + textBoxNum6.Text;
            if (userEntry.Equals(code))
            {
                frmChangePassword changePass = new frmChangePassword();
                changePass.Tag = currentUser;
                Hide();
                changePass.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect Code, Please Try Again...");
            }
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBoxNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxNum3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxNum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxNum5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNum5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxNum6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
