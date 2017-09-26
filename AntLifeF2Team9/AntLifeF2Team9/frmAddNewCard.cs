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
    public partial class frmAddNewCard : Form
    {
        User currentUser = new User();
        frmCreateAccount addAccount = new frmCreateAccount();
        frmAddMembership addMember = new frmAddMembership();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        public frmAddNewCard()
        {
            InitializeComponent();
            
        }
        #region methods for validation
        public bool nameCheck()
        {
            string textName = textBoxCardName.Text;

            if (textName != "")
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Name.", "Input Error");

                textBoxCardName.Clear();
                textBoxCardName.Focus();

                return false;
            }

        }
        public bool addressCheck()
        {
            string address = textBoxAddress.Text;

            if (address != "")
                return true;
            else

                MessageBox.Show("Please enter a valid Address.", "Input Error");

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
        public bool monthCheck()
        {
            int month = Convert.ToInt32(textBoxMonth.Text);

            if (month > 0 && month < 13)
                return true;
            else
            {

                MessageBox.Show("Please enter a valid Month,1-12.", "Input Error");

                textBoxMonth.Clear();
                textBoxMonth.Focus();

                return false;
            }
        }
        public bool yearCheck()
        {
            int year = Convert.ToInt32(textBoxYear.Text);

            if (year > 2015 && year < 2030)
                return true;
            else
            {

                MessageBox.Show("That card expiration year seems to be wrong.  Please check this.", "Input Error");

                textBoxYear.Clear();
                textBoxYear.Focus();

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
        public bool cardCheck()
        {
            if (textBoxCardNumber.Text.Length < 16)
                return true;
            else
            {
                try
                {
                    throw new Exception("Card number must be atleast 16 numbers.");
                }
                catch
                {
                    MessageBox.Show("Card number must be atleast 16 numbers.", "Input Error");
                }
                finally
                {
                    textBoxCardNumber.Clear();
                    textBoxCardNumber.Focus();
                }
                return false;
            }
        }
        public bool csvCheck()
        {
            if (textBoxCSV.Text.Length < 2)
                return true;
            else
            {
                try
                {
                    throw new Exception("CSV must be atleast 2 numbers");
                }
                catch
                {
                    MessageBox.Show("CSV must be atleast 2 numbers", "Input Error");
                }
                finally
                {
                    textBoxCSV.Clear();
                    textBoxCSV.Focus();
                }
                return false;
            }
        }
        #endregion
        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            currentUser = (User)this.Tag;
            #region validation variables
            bool validName = nameCheck();
            bool validAddress;
            bool validCity;
            bool validMonth;
            bool validYear;
            bool validCard;
            bool validCsv;
            bool goodToGo;

            if (validName)

                validAddress = addressCheck();
            else return;

            if (validAddress)
                validCity = cityCheck();
            else return;
            if (validCity)
                validMonth = monthCheck();
            else return;
            if (validMonth)
                validYear = yearCheck();
            else return;
            if (validYear)
                validCard = cardCheck();
            else return;
            if (validCard)
                validCsv = csvCheck();
            else return;
            if (validCsv)
                goodToGo = zipCheck();
            else return;
            #endregion
            
            


            if (goodToGo)
            {
                string nameOnCard = textBoxCardName.Text;
                string expDate = textBoxYear.Text + "-" + textBoxMonth.Text + "-01";
                string billingAddress = textBoxAddress.Text;
                string city = textBoxCity.Text;
                string zip = textBoxZip.Text;
                string state = comboBoxState.Text;
                string country = comboBoxCountry.Text;
                string cardType = comboBoxCards.Text;
                byte[] plainTxtCsv = Encoding.ASCII.GetBytes(textBoxCSV.Text);
                byte[] plainTxtCardNumber = Encoding.ASCII.GetBytes(textBoxCardNumber.Text);
                byte[] csvSalt = addAccount.CreateSalt();
                byte[] cardNumSalt = addAccount.CreateSalt();
                byte[] cardHashByte;
                byte[] csvHashByte;
                string csvHash;
                string cardNumberHash;
                string lastFour = textBoxCardNumber.Text.Substring(textBoxCardNumber.Text.Length - 4);
                cardHashByte = addAccount.EncryptSha256(plainTxtCardNumber, cardNumSalt);
                csvHashByte = addAccount.EncryptSha256(plainTxtCsv, csvSalt);

                csvHash = Convert.ToBase64String(csvHashByte);
                cardNumberHash = Convert.ToBase64String(cardHashByte);

                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_AddCard", cn))
                        {


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                            cmd.Parameters.Add("@nameOnCard", SqlDbType.VarChar, 100).Value = nameOnCard;
                            cmd.Parameters.Add("@expirationDate", SqlDbType.Date, 25).Value = expDate;
                            cmd.Parameters.Add("@billingAddress", SqlDbType.VarChar, 100).Value = billingAddress;
                            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
                            cmd.Parameters.Add("@zip", SqlDbType.VarChar, 7).Value = zip;
                            cmd.Parameters.Add("@state", SqlDbType.VarChar, 30).Value = state;
                            cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = country;
                            cmd.Parameters.Add("@cardType", SqlDbType.VarChar, 30).Value = cardType;
                            cmd.Parameters.Add("@csvHash", SqlDbType.VarChar, 256).Value = csvHash;
                            cmd.Parameters.Add("@csvSalt", SqlDbType.VarChar, 256).Value = Convert.ToBase64String(csvSalt);
                            cmd.Parameters.Add("@cardNumberSalt", SqlDbType.VarChar, 256).Value = Convert.ToBase64String(cardNumSalt);
                            cmd.Parameters.Add("@cardNumberHash", SqlDbType.VarChar, 256).Value = cardNumberHash;
                            cmd.Parameters.Add("@lastFour", SqlDbType.VarChar, 4).Value = lastFour;

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
                this.Hide();

                frmCart cart = new frmCart();
                cart.Tag = currentUser;
                cart.ShowDialog();
                this.Close();
            }
            return;
        }

        private void frmAddNewCard_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

            comboBoxCards.DataSource = addMember.dictCards.Keys.ToArray();
            comboBoxState.DataSource = addAccount.dictStates.Keys.ToArray();
            comboBoxCountry.DataSource = addAccount.dictCountry.Keys.ToArray();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text.Equals("CA"))
            {

                comboBoxState.DataSource = addAccount.dictProvinces.Keys.ToArray();
                labelState.Text = "Province";
                textBoxZip.MaxLength = 7;

            }
            if (comboBoxCountry.Text.Equals("US"))
            {
                comboBoxState.DataSource = addAccount.dictStates.Keys.ToArray();
                labelState.Text = "State";
                textBoxZip.MaxLength = 5;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            frmCart cart = new frmCart();
            cart.Tag = currentUser;
            cart.ShowDialog();
            this.Close();

        }

        private void textBoxCardName_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        
        }

        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
