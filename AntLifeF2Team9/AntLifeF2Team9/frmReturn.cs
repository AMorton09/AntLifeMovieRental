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
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
        }

        User currentUser = new User();
        List<Product> purchasedItems = new List<Product>();
        Product prod = new Product();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        const double FEDERAL_TAX = .06;
        const double STATE_TAX = .035;

        private void frmReturn_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

            currentUser = (User)Tag;
            getPurchases();
            buttonReturn.Enabled = false;
            dataGridViewPurchases.DataSource = purchasedItems;
        }


        private void getPurchases()
        {
            dataGridViewPurchases.DataSource = null;
            purchasedItems.Clear();
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetPurchases", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;

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
                                prod.detailID = (int)reader["detailID"];
                                prod.receiptID = (int)reader["receiptID"];

                                double tempPriceDouble;
                                Double.TryParse(tempPrice, out tempPriceDouble);
                                prod.price = tempPriceDouble;



                                purchasedItems.Add(prod);
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
            
            dataGridViewPurchases.DataSource = purchasedItems;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            removeDetail();
            updateAmmountSpent();
            updateReceiptHeader();
            if (!checkBoxDefect.Checked)
            {
                updateStock();
            }
            getPurchases();
        }

        private void dataGridViewPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prod = (Product)dataGridViewPurchases.CurrentRow.DataBoundItem;
            buttonReturn.Enabled = true;
        }
        public void updateStock()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_ReturnToStock", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                       


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
        private void removeDetail()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_RemoveFromDetail", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@detailID", SqlDbType.Int, 100).Value = prod.detailID;

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

        private void updateAmmountSpent()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateTotalSpent", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                     
                        cmd.Parameters.Add("@totalSpent", SqlDbType.VarChar, 100).Value = -(prod.price+(prod.price*FEDERAL_TAX)+(prod.price*STATE_TAX));

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

        //finish me
        private void updateReceiptHeader()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateReceiptHeader", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@receiptID", SqlDbType.Int, 100).Value = prod.receiptID;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                        cmd.Parameters.Add("@orderGrandTotal", SqlDbType.VarChar, 25).Value = -(prod.price + (prod.price * FEDERAL_TAX) + (prod.price * STATE_TAX));
                        cmd.Parameters.Add("@orderSubTotal", SqlDbType.VarChar, 25).Value = -(prod.price);
                        cmd.Parameters.Add("@orderFederalTax", SqlDbType.VarChar, 25).Value = -(prod.price * FEDERAL_TAX);
                        cmd.Parameters.Add("@orderStateTax", SqlDbType.VarChar, 25).Value = -(prod.price * STATE_TAX);
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
