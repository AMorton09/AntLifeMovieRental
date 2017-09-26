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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        User currentUser = new User();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        frmCreateAccount create = new frmCreateAccount();
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
            currentUser = (User)Tag;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxConfirm.Text!=textBoxPass.Text)
            {
                MessageBox.Show("Those Passwords Dont Match!");
            }else if(textBoxPass.Text.Length<8)
            {
                MessageBox.Show("That Password is Not Long Enough(8 Characters)");
            }else
            {
                changePass();

                Close();
            }
            
        }
        private void changePass()
        {

            byte[] passwordEntryByte = Encoding.ASCII.GetBytes(textBoxPass.Text);
            byte[] saltByte = create.CreateSalt();
            byte[] shaPass = create.EncryptSha256(passwordEntryByte,saltByte);

            string passwordSalt = Convert.ToBase64String(saltByte);
            string passwordHash = Convert.ToBase64String(shaPass);
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_ChangePass", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                        cmd.Parameters.Add("@passwordHash", SqlDbType.VarChar, 256).Value =passwordHash;
                        cmd.Parameters.Add("@passwordSalt", SqlDbType.VarChar, 256).Value = passwordSalt;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           
            Close();
        }
    }
}
