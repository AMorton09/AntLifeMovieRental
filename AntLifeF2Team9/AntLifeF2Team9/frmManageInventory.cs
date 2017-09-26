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
    public partial class frmManageInventory : Form
    {
        List<Product> products = new List<Product>();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        public frmManageInventory()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
           
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageInventory_Load(object sender, EventArgs e)
        {
            getInventory();
            dataGridViewInv.DataSource = products;
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

        }

        private void getInventory()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetAllProducts", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;

                        cn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Product prod = new Product();

                                prod.productID = (int)reader["productID"];
                                prod.productName = (string)reader["productName"];
                                prod.productDesc = (string)reader["productDescription"];
                                prod.category = (string)reader["productCategory"];
                                string tempPrice = (string)reader["price"];
                                prod.expDate = (DateTime)reader["expirationDate"];
                                string tempHazard = (string)reader["isHazardous"];
                                prod.numStock = (int)reader["numberInStock"];
                                prod.maxStock = (int)reader["maxStock"];
                                prod.reorderPoint = (int)reader["reorderPoint"];
                                prod.reorderAmount = (int)reader["reorderAmount"];
                                double tempPriceDouble;
                                Double.TryParse(tempPrice, out tempPriceDouble);
                                prod.price = tempPriceDouble;

                                if (tempHazard.Equals("Yes"))
                                {
                                    prod.isHazardous = true;
                                }
                                if (tempHazard.Equals("No"))
                                {
                                    prod.isHazardous = false;
                                }

                                products.Add(prod);
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

        private void toolStripButtonAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            addProduct.ShowDialog();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Product removedProd = new Product();
            removedProd = (Product)dataGridViewInv.CurrentRow.DataBoundItem;
            dataGridViewInv.DataSource = null;


            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_RemoveProduct", cn))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = removedProd.productID;


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

            products.Clear();
            
            getInventory();
            dataGridViewInv.DataSource = products;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            frmEditProduct frmEdit = new frmEditProduct();
            frmEdit.Tag = (Product)dataGridViewInv.CurrentRow.DataBoundItem;
            Hide();
            frmEdit.ShowDialog();
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
