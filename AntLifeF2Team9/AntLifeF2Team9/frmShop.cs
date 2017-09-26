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
    public partial class frmShop : Form
    {
        List<Product> productList = new List<Product>();
        List<Product> cartItems = new List<Product>();
        List<Product> productList2 = new List<Product>();
        User currentUser = new User();
        frmCart cart = new frmCart();
        bool currentUserAlreadySelected = false;
        bool oldEnoughAlc = false;
        bool oldEnoughTob = false;

        public frmShop()
        {
            InitializeComponent();
            addCategories();
            
        }

        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;



        private void frmShop_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

            currentUser = (User)Tag;

            getProducts();
            try
            {
                productList2 = productList;
                dataGridViewProducts.DataSource = productList;
                dataGridViewProducts.Columns.Remove("maxStock");
                dataGridViewProducts.Columns.Remove("reorderPoint");
                dataGridViewProducts.Columns.Remove("isHazardous");
                dataGridViewProducts.Columns.Remove("expDate");
                dataGridViewProducts.Columns.Remove("numsold");
                dataGridViewProducts.Columns.Remove("numInCart");
                dataGridViewProducts.Columns.Remove("detailID");
                dataGridViewProducts.Columns.Remove("reorderAmount");
                dataGridViewProducts.Columns.Remove("receiptID");
                dataGridViewProducts.Columns.Remove("amountOrdered");
                dataGridViewProducts.Columns.Remove("lastSold");
                currentUserAlreadySelected = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }

        private void addCategories()
        {
            List<string> categories = new List<string>();
            categories.Add("Select A Category...");
            categories.Add("Alcohol");
            categories.Add("Tobacco");
            categories.Add("Household");
            categories.Add("Electronics");
            categories.Add("Sporting Goods");
            categories.Add("Food");
            comboBoxCategories.DataSource = categories;
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> selectedProductsList = new List<Product>();
            foreach (Product prod in productList)
            {
                if (prod.category.Equals(comboBoxCategories.Text))
                {
                    selectedProductsList.Add(prod);
                   
                }
                
            }
            if (comboBoxCategories.Text.Equals("Select A Category..."))
            {
                dataGridViewProducts.DataSource = productList2;
                if (!currentUserAlreadySelected)
                {
                    try
                    {
                        dataGridViewProducts.Columns.Remove("maxStock");
                        dataGridViewProducts.Columns.Remove("reorderPoint");
                        dataGridViewProducts.Columns.Remove("isHazardous");
                        dataGridViewProducts.Columns.Remove("expDate");
                        dataGridViewProducts.Columns.Remove("numsold");
                   
                        dataGridViewProducts.Columns.Remove("reorderAmount");
                        dataGridViewProducts.Columns.Remove("lastSold");
                        currentUserAlreadySelected = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
                    }
                }
            }
            else
            {


                dataGridViewProducts.DataSource = selectedProductsList;
                try
                {
                    dataGridViewProducts.Columns.Remove("maxStock");
                    dataGridViewProducts.Columns.Remove("reorderPoint");
                    dataGridViewProducts.Columns.Remove("isHazardous");
                    dataGridViewProducts.Columns.Remove("expDate");
                    dataGridViewProducts.Columns.Remove("numsold");
                    dataGridViewProducts.Columns.Remove("numInCart");
                    dataGridViewProducts.Columns.Remove("detailID");
                    dataGridViewProducts.Columns.Remove("reorderAmount");
                    dataGridViewProducts.Columns.Remove("receiptID");
                    dataGridViewProducts.Columns.Remove("amountOrdered");
                    dataGridViewProducts.Columns.Remove("lastSold");
                    currentUserAlreadySelected = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
                }
                currentUserAlreadySelected = false;
            }
            }
        

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            frmDOB dobCheck = new frmDOB();
            Product addedProduct = new Product();
            addedProduct = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
           
                if (addedProduct.category.Equals("Alcohol") && !oldEnoughAlc)
                {
                    dobCheck.ShowDialog();
                    if (Convert.ToDateTime(dobCheck.Tag) < DateTime.Today.AddYears(-21))
                    {
                    
                        oldEnoughAlc = true;
                        oldEnoughTob = true;
                        addToDb(addedProduct, Convert.ToInt32(textBoxQty.Text));
                    
                        MessageBox.Show(addedProduct.productName + " Has been added to your cart");
                    }
                    else
                    {
                        MessageBox.Show("I'm sorry you do not meet the age requirement to purchase " + addedProduct.productName);

                    }
                }
                else if (addedProduct.category.Equals("Tobacco")&&!oldEnoughTob)
                {
                    dobCheck.ShowDialog();
                    if (Convert.ToDateTime(dobCheck.Tag) < DateTime.Today.AddYears(-19) && Convert.ToDateTime(dobCheck.Tag) != Convert.ToDateTime(0000-01-01))
                    {
                        oldEnoughTob = true;
                        addToDb(addedProduct, Convert.ToInt32(textBoxQty.Text));
                        MessageBox.Show(addedProduct.productName + " Has been added to your cart");
                    }
                    else
                    {
                        MessageBox.Show("I'm sorry you do not meet the age requirement to purchase " + addedProduct.productName);

                    }
                }
                else 
                {

                    addToDb(addedProduct, Convert.ToInt32(textBoxQty.Text));
                    MessageBox.Show(addedProduct.productName + " Has been added to your cart");
                }
          
        }

        private void addToDb(Product prod, int numberAdded)
        {
            prod.numInCart = numberAdded;
            if (!checkIfInCart(prod))
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_AddToCart", cn))
                        {
                           

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                            cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                            cmd.Parameters.Add("@productName", SqlDbType.VarChar, 100).Value = prod.productName;
                            cmd.Parameters.Add("@productDescription", SqlDbType.VarChar, 255).Value = prod.productDesc;
                            cmd.Parameters.Add("@productCategory", SqlDbType.VarChar, 50).Value = prod.category;
                            cmd.Parameters.Add("@price", SqlDbType.VarChar, 20).Value = prod.price;
                            cmd.Parameters.Add("@Qty", SqlDbType.Int, 100).Value = prod.numInCart;
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
            else if (checkIfInCart(prod))
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_UpdateCartQty", cn))
                        {
                           

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                            cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                            cmd.Parameters.Add("@Qty", SqlDbType.Int, 100).Value = prod.numInCart;
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
        }
        private void buttonViewCart_Click(object sender, EventArgs e)
        {
            Hide();
            cart.Tag = currentUser;
            cart.ShowDialog();
            Close();
        }

        private void getProducts()
        {
            productList.Clear();
            dataGridViewProducts.DataSource = null;
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

                                productList.Add(prod);
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
            dataGridViewProducts.DataSource = productList;
        }
        Product selectedProd = new Product();
        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            


        }

        private bool checkIfInCart(Product addedItem)
        {
            cartItems.Clear();
            getCart();
            foreach (Product prod in cartItems)
            {
                if (addedItem.productID.Equals(prod.productID))
                {
                    return true;
                }
            }

            return false;
        }

        private void getCart()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetUserCart", cn))
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
                                prod.numInCart = (int)reader["numInCart"];


                                double tempPriceDouble;
                                Double.TryParse(tempPrice, out tempPriceDouble);
                                prod.price = tempPriceDouble;



                                cartItems.Add(prod);
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

        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textBoxQty.Text) >= selectedProd.numStock)
            {
                MessageBox.Show("You have reached the maximum available quantity for that item.");
            }
            else
            {
                textBoxQty.Text = (Convert.ToInt32(textBoxQty.Text) + 1).ToString();
            }

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxQty.Text = (Convert.ToInt32(textBoxQty.Text) - 1).ToString();
            if (Convert.ToInt32(textBoxQty.Text) == 0)
            {
                textBoxQty.Text="1";

            }
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            selectedProd = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
            textBoxQty.Text = "1";
        }
    }
}
