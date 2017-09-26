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
    public partial class frmManageEmp : Form
    {
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        List<User> employees = new List<User>();
        List<User> allUsers = new List<User>();
        frmEditEmployee editEmp = new frmEditEmployee();
        public frmManageEmp()
        {
            InitializeComponent();
        }

        private void frmManageEmp_Load(object sender, EventArgs e)
        {
            getEmployees();
            dataGridViewEmployees.DataSource = employees;
            dataGridViewEmployees.Columns.Remove("passwordHash");
            dataGridViewEmployees.Columns.Remove("passwordSalt");
            dataGridViewEmployees.Columns.Remove("membershipLevel");
            dataGridViewEmployees.Columns.Remove("employee");
            dataGridViewEmployees.Columns.Remove("expDate");
            dataGridViewEmployees.Columns.Remove("amountSpent");

            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

        }

        private void getEmployees()
        {
           

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
                                User emp = new User();
                                emp.userID = reader.GetInt32(0);
                                emp.firstName = reader.GetString(1);
                                emp.lastName = reader.GetString(2);
                                emp.address = reader.GetString(3);
                                emp.city = reader.GetString(4);
                                emp.zip = reader.GetString(5);
                                emp.state = reader.GetString(6);
                                emp.country = reader.GetString(7);
                                emp.email = reader.GetString(8);
                                emp.passwordHash = reader.GetString(9);
                                emp.passwordSalt = reader.GetString(10);
                                emp.membershipLevel = reader.GetString(11);
                                string employeeString = reader.GetString(12);
                                emp.expDate = Convert.ToString(reader.GetDateTime(13));
                                emp.amountSpent = Convert.ToDouble(reader["amountSpent"]);
                                if (employeeString.Equals("No"))
                                {
                                    emp.employee = false;
                                }
                                else if (employeeString.Equals("Yes"))
                                {
                                    emp.employee = true;
                                }
                                allUsers.Add(emp);
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

            foreach (User empl in allUsers)
            {
                if (empl.employee)
                {
                    employees.Add(empl);
                }
            }

        }

        

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        //Add Button
        private void toolStripButtonAddEmployee_Click_1(object sender, EventArgs e)
        {
            Hide();

            frmAddNewEmployee newEmp = new frmAddNewEmployee();
            newEmp.ShowDialog();
            Close();
        }
        
        //Edit Button

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        //Remove Button
        private void toolStripButtonRemove_Click_1(object sender, EventArgs e)
        {
            User removedUser = new User();
            removedUser = (User)dataGridViewEmployees.CurrentRow.DataBoundItem;
            dataGridViewEmployees.DataSource = null;


            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_RemoveAccount", cn))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = removedUser.userID;


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

            allUsers.Clear();
            employees.Clear();
            getEmployees();
            dataGridViewEmployees.DataSource = employees;

        }








      #region for accidental clicks
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        private void toolStripButtonAddEmployee_Click(object sender, EventArgs e)
        {
           
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {

        }




        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmEmployee = new frmEmployee();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {

            editEmp.Tag = (User)dataGridViewEmployees.CurrentRow.DataBoundItem;
            Hide();
            editEmp.ShowDialog();
            Close();
        }
    }
}
