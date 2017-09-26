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
    public partial class frmCreateAccount : Form
    {
        public Dictionary<string, string> dictStates = new Dictionary<string, string>();
        public Dictionary<string, string> dictCountry = new Dictionary<string, string>();
        public Dictionary<string, string> dictProvinces = new Dictionary<string, string>();
        List<User> allUsers = new List<User>();
        #region Account Creation

        public frmCreateAccount()
        {
            InitializeComponent();
            addStates();
            comboBoxStates.DataSource = dictStates.Keys.ToArray();
            addCountry();
            comboBoxCountry.DataSource = dictCountry.Keys.ToArray();
            addProvince();
        }
        public void addStates()
        {
            dictStates.Add("AL", "Alabama");
            dictStates.Add("AK", "Alaska");
            dictStates.Add ("AZ", "Arizona");
            dictStates.Add ("AR", "Arkansas");
            dictStates.Add ("CA", "California");
            dictStates.Add ("CO", "Colorado");
            dictStates.Add ("CT", "Connecticut");
            dictStates.Add ("DE", "Delaware");
            dictStates.Add ("DC", "District Of Columbia");
            dictStates.Add ("FL", "Florida");
            dictStates.Add ("GA", "Georgia");
            dictStates.Add ("HI", "Hawaii");
            dictStates.Add ("ID", "Idaho");
            dictStates.Add ("IL", "Illinois");
            dictStates.Add ("IN", "Indiana");
            dictStates.Add ("IA", "Iowa");
            dictStates.Add ("KS", "Kansas");
            dictStates.Add ("KY", "Kentucky");
            dictStates.Add ("LA", "Louisiana");
            dictStates.Add ("ME", "Maine");
            dictStates.Add ("MD", "Maryland");
            dictStates.Add ("MA", "Massachusetts");
            dictStates.Add ("MI", "Michigan");
            dictStates.Add ("MN", "Minnesota");
            dictStates.Add ("MS", "Mississippi");
            dictStates.Add ("MO", "Missouri");
            dictStates.Add ("MT", "Montana");
            dictStates.Add ("NE", "Nebraska");
            dictStates.Add ("NV", "Nevada");
            dictStates.Add ("NH", "New Hampshire");
            dictStates.Add ("NJ", "New Jersey");
            dictStates.Add ("NM", "New Mexico");
            dictStates.Add ("NY", "New York");
            dictStates.Add ("NC", "North Carolina");
            dictStates.Add ("ND", "North Dakota");
            dictStates.Add ("OH", "Ohio");
            dictStates.Add ("OK", "Oklahoma");
            dictStates.Add ("OR", "Oregon");
            dictStates.Add ("PA", "Pennsylvania");
            dictStates.Add ("RI", "Rhode Island");
            dictStates.Add ("SC", "South Carolina");
            dictStates.Add ("SD", "South Dakota");
            dictStates.Add ("TN", "Tennessee");
            dictStates.Add ("TX", "Texas");
            dictStates.Add ("UT", "Utah");
            dictStates.Add ("VT", "Vermont");
            dictStates.Add ("VA", "Virginia");
            dictStates.Add ("WA", "Washington");
            dictStates.Add ("WV", "West Virginia");
            dictStates.Add ("WI", "Wisconsin");
            dictStates.Add ("WY", "Wyoming");
            
        }

        public void addCountry()
        {
            dictCountry.Add("US", "United States of America");
            dictCountry.Add("CA", "Canada");
        }
        public void addProvince()
        {
            dictProvinces.Add("AB", "Alberta");
            dictProvinces.Add("BC", "British Columbia");
            dictProvinces.Add("MB", "Manitoba");
            dictProvinces.Add("NB", "New Brunswick");
            dictProvinces.Add("NL", "Newfoundland and Labrador");
            dictProvinces.Add("NS", "Nova Scotia");
            dictProvinces.Add("ON", "Ontario");
            dictProvinces.Add("PE", "Prince Edwards Island");
            dictProvinces.Add("QC", "Quebec");
            dictProvinces.Add("SK", "Saskatchewan");
            dictProvinces.Add("NW Territories", "Northwest Territories");
            dictProvinces.Add("Nunavut", "Nunavut");
            dictProvinces.Add("Yukon", "Yukon");
        }
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        #endregion
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
            if (textBoxPassword.Text.Length > 7)
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
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            string date = DateTime.Today.ToString("yyyy-MM-dd");
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
                if (!checkIfExist())
                {
                    fName = textBoxFirstName.Text;
                    lName = textBoxLastName.Text;
                    address = textBoxAddress.Text;
                    city = textBoxCity.Text;
                    if (comboBoxCountry.Text == "US")
                    {
                        state = dictStates[comboBoxStates.Text];
                    }
                    else
                    {
                        state = dictProvinces[comboBoxStates.Text];
                    }

                    confirmPassword = textBoxConfirmPassword.Text;
                    confirmEmail = textBoxConfirmEmail.Text;

                    zip = textBoxZip.Text;
                    country = dictCountry[comboBoxCountry.Text];
                    email = textBoxEmail.Text;
                    plainTxtPassword = textBoxPassword.Text;



                    passwordSaltByte = CreateSalt();
                    byte[] plainTxtPasswordByte = Encoding.ASCII.GetBytes(plainTxtPassword);
                    byte[] saltByte = CreateSalt();
                    passwordHashByte = EncryptSha256(plainTxtPasswordByte, saltByte);
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
                                    cmd.Parameters.Add("@employee", SqlDbType.VarChar, 3).Value = "No";
                                    cmd.Parameters.Add("@expDate", SqlDbType.Date, 20).Value = date;
                                    cmd.Parameters.Add("@amountSpent", SqlDbType.VarChar, 3).Value = "0";
                                    cn.Open();
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Account "+email+ " created.");
                                    cn.Close();
                                    this.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
                        }

                    }
                    else if (!plainTxtPassword.Equals(confirmPassword) || !email.Equals(confirmEmail))
                    {
                        MessageBox.Show("Please check your pass and email and ensure that they match");
                    }
                }
                else
                {
                    MessageBox.Show("Email Already Exists");
                }
            }
        }
        #endregion
        #region salting
        public byte[] CreateSalt()
        {
            //creates byte array of 64 bits to store salt
            byte[] salt = new byte[64];

            //creates new instance of the pseudo random number generator to create the salt
            RNGCryptoServiceProvider saltGen = new RNGCryptoServiceProvider();
            
            // populates the byte array with the salt
            saltGen.GetBytes(salt);

            //returns the salt as a binary array
            return salt;
        } 
        public byte[] EncryptSha256(byte[] plainText, byte[] salt)
        {
            // creates instance of SHA 256 encryption algorithm
            HashAlgorithm algorithm = new SHA256Managed();

            //concatinates the password with the salt into one byte array 
            byte[] saltedPlainTxt = plainText .Concat(salt).ToArray();

            //hashes and returns the password 
            return algorithm.ComputeHash(saltedPlainTxt);
        }
        #endregion
        #region form load
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
        }

        #endregion
        #region Events

        private void comboBoxStates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text.Equals("CA"))
            {

                comboBoxStates.DataSource = dictProvinces.Keys.ToArray();
                labelState.Text = "Province";
                textBoxZip.MaxLength = 7;

            }
            if (comboBoxCountry.Text.Equals("US"))
            {
                comboBoxStates.DataSource = dictStates.Keys.ToArray();
                labelState.Text = "State";
                textBoxZip.MaxLength = 5;

            }
        }
       

        private void textBoxFirstName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBoxZip_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (comboBoxCountry.Text.Equals("US"))
            {
                e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
        }
        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        private void textBoxZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private bool checkIfExist()
        {
            getAllUsers();
            foreach (User use in allUsers)
            {
                if (use.email.ToUpper().Equals(textBoxEmail.Text.ToUpper()))
                {
                   
                    return true;
                }
             
            }
            return false;
        }

        private void getAllUsers()
        {
            allUsers.Clear();
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetAllAccounts", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;

                        cn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                User tempUser = new User();

                                tempUser.userID = reader.GetInt32(0);
                                tempUser.firstName = reader.GetString(1);
                                tempUser.lastName = reader.GetString(2);
                                tempUser.address = reader.GetString(3);
                                tempUser.city = reader.GetString(4);
                                tempUser.zip = reader.GetString(5);
                                tempUser.state = reader.GetString(6);
                                tempUser.country = reader.GetString(7);
                                tempUser.email = reader.GetString(8);
                                tempUser.passwordHash = reader.GetString(9);
                                tempUser.passwordSalt = reader.GetString(10);
                                tempUser.membershipLevel = reader.GetString(11);
                                string employeeString = reader.GetString(12);
                                tempUser.expDate = Convert.ToString(reader.GetDateTime(13));
                                tempUser.amountSpent = Convert.ToDouble(reader["amountSpent"]);
                                if (employeeString.Equals("No"))
                                {
                                    tempUser.employee = false;
                                }
                                else if (employeeString.Equals("Yes"))
                                {
                                    tempUser.employee = true;
                                }
                                allUsers.Add(tempUser);
                            }
                        }


                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }
    }
}
