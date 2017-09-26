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
using System.IO;

namespace AntLifeF2Team9
{
    public partial class frmCustomer : Form
    {
        User currentUser = new User();

        frmAddMembership addCard = new frmAddMembership();
        frmShop shop = new frmShop();
        frmCart cart = new frmCart();

        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;

        public frmCustomer()
        {
            InitializeComponent();
           
           
            
        }

        private void buttonAddMembership_Click(object sender, EventArgs e)
        {

            Hide();
            addCard.Tag = currentUser;
            addCard.ShowDialog();
            Close();
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            shop.Tag = currentUser;
            shop.ShowDialog();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;



            currentUser = (User)this.Tag;
            reloadUser();
            cart.Tag = currentUser;
            labelCustName.Text = currentUser.firstName + " " + currentUser.lastName;
            if (currentUser.amountSpent > 0)
            {
                if (currentUser.membershipLevel.Equals("None")) progressBarLvl.Maximum = 0;

                if (currentUser.membershipLevel.Equals("Bronze")) progressBarLvl.Maximum = 5000;

                if (currentUser.membershipLevel.Equals("Silver")) progressBarLvl.Maximum = 20000;

                if (currentUser.membershipLevel.Equals("Gold")) progressBarLvl.Maximum = 20000;

                if (currentUser.membershipLevel.Equals("Bronze") || currentUser.membershipLevel.Equals("Silver") || currentUser.membershipLevel.Equals("Gold"))
                {
                    lblXp.Text += " " + currentUser.amountSpent.ToString();
                    lblLvl.Text += " " + currentUser.membershipLevel;
                    lblNext.Text += " " + (progressBarLvl.Maximum - currentUser.amountSpent);
                }
                else
                {
                    lblLvl.Text += " " + currentUser.membershipLevel + " Purchase a membership \nin order to recieve rewards!";
                    lblNext.Text = "";
                    lblXp.Text = "";
                }
                if (currentUser.membershipLevel.Equals("Gold"))
                {
                    lblNext.Text = "XP Until NextLevel: MAX";
                }
                if (currentUser.membershipLevel.Equals("Bronze") || currentUser.membershipLevel.Equals("Silver") || currentUser.membershipLevel.Equals("Gold")) progressBarLvl.Value = Convert.ToInt32(Math.Floor(currentUser.amountSpent));
            }
        }

        private void buttonViewCart_Click(object sender, EventArgs e)
        {
            Hide();
            cart.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
            
            
        }
        //return
        private void button3_Click(object sender, EventArgs e)
        {
            frmReturn ret = new frmReturn();
            ret.Tag = currentUser;
            ret.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void reloadUser()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetUser", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = currentUser.email;


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

    }
}
