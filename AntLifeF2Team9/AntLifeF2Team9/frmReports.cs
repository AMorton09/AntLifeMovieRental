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
    public partial class frmReports : Form
    {
        List<Product> products = new List<Product>();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        List<Product> reorderedProducts = new List<Product>();
        List<Product> expItems = new List<Product>();
        List<User> allUsers = new List<User>();
        List<Product> sortedProd = new List<Product>();
        public frmReports()
        {
            InitializeComponent();
        }

        private void buttonEod_Click(object sender, EventArgs e)
        {
            products.Clear();

            getInventory();

            checkExpDate();

            products.Clear();

            getInventory();


            foreach (Product prod in products)
            {   
                    if (prod.numStock < prod.reorderPoint)
                    {
                        reorder(prod);
                        reorderedProducts.Add(prod);
                    }
               
            }
            createReorderedItemsReport();
        }

        private void reorder(Product prod)
        {
            int numOrdered = 1;
            for (int ctr = 1; ctr * prod.reorderAmount < prod.maxStock; ctr++)
            {
                numOrdered++;
            }
            prod.amountOrdered = numOrdered;
            if (!prod.category.Equals("Food"))
            {
                addToInvNorm(prod, numOrdered);
            }
            if (prod.category.Equals("Food"))
            {
                addToInvFood(prod, numOrdered);
            }
        }


        private void addToInvNorm(Product prod, int numOrdered)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_AddInventory", cn))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                        cmd.Parameters.Add("@orderAmount", SqlDbType.Int, 100).Value = prod.reorderAmount*numOrdered;


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

        private void addToInvFood(Product prod, int numOrdered)
        {
            string date= DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_AddInventoryFood", cn))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                        cmd.Parameters.Add("@orderAmount", SqlDbType.Int, 100).Value = prod.reorderAmount * numOrdered;
                        cmd.Parameters.Add("@expDate", SqlDbType.Date, 100).Value = date;

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
                                prod.lastSold = (DateTime)reader["lastSold"];
                                prod.numSold = (int)reader["numsold"];

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

        private void createReorderedItemsReport()
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments );
            string fileName = "Order" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path,FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                foreach (Product prod in reorderedProducts)
                {
                    file.WriteLine("Amount Ordered = "+prod.amountOrdered+" "+prod);
                }
               
                file.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }

        private void expItemsReport()
        {
            
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "ExpiredItems" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                //put in header
                foreach (Product prod in expItems)
                {
                    file.WriteLine("Number Expired "+prod.numStock.ToString()+" "+prod);
                }

                file.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }


        private void checkExpDate()
        {
            foreach (Product prod in products)
            {
                if (prod.expDate < DateTime.Now && prod.category.Equals("Food"))
                {
                    expItems.Add(prod);
                    removeExpItemFromDb(prod);
                    
                }
            }
            expItemsReport();
        }

        private void removeExpItemFromDb(Product prod)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_ExpiredItemRemoval", cn))
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


        private void frmReports_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
            getAllUsers();
        }

        private void buttonCurrentMem_Click(object sender, EventArgs e)
        {
           
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "CurrentMembers" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                foreach (User use in allUsers)
                {
                    if (!use.membershipLevel.Equals("None"))
                    {
                        file.WriteLine(use);
                    }
                }

                file.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
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

        private void buttonExpMem_Click(object sender, EventArgs e)
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "ExpiredMembers" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                foreach (User use in allUsers)
                {
                    if (!use.membershipLevel.Equals("None")&&Convert.ToDateTime(use.expDate)<DateTime.Now)
                    {
                        file.WriteLine(use);
                    }
                }

                file.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }

        private void buttonTopSellers_Click(object sender, EventArgs e)
        {
            products.Clear();
            getInventory();
            sortedProd = products.OrderByDescending(x => x.numSold).ToList();
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "Top Sellers" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                for (int ctr = 0; ctr<10;ctr++)
                {
                    
                        file.WriteLine(sortedProd[ctr]);
                    
                }

                file.Close();
                mystream.Close();
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

        private void buttonNotSoldInYear_Click(object sender, EventArgs e)
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "NotSoldInOneYear" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                foreach (Product prod in products)
                {
                    if (prod.lastSold<DateTime.Now.AddYears(-1))
                    {
                        file.WriteLine("Last Sold On = "+prod.lastSold.ToString("yyyy-MM-dd")+" "+ prod);
                    }
                }

                file.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }
    }
}
