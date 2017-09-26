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
    public partial class frmCart : Form
    {
        User currentUser = new User();
        List<Product> cartList = new List<Product>();
        Checkout checkout = new Checkout();
        List<string> savedCards = new List<string>();
        frmAddNewCard addCard = new frmAddNewCard();
        List<Product> checkoutItems = new List<Product>();
        DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
        List<Product> inventory = new List<Product>();
        List<Product> purchasedItems = new List<Product>();
        Product selectedItem = new Product();

        const double FEDERAL_TAX = .06;
        const double STATE_TAX = .035;
        const double CANADIAN_DOLLAR_CONVERSION = 1.35;
        double orderTotal = 0;
        double subTotal = 0;
        double fedTax = 0;
        double stateTax = 0;
        int numItems = 0;
        int receiptID;

        public frmCart()
        {

            InitializeComponent();
        }
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;

        private void frmCart_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

            radioButton1.Select();
            buttonMinus.Enabled = false;
            buttonPlus.Enabled = false;
            comboBoxSavedCards.Enabled = false;
            buttonAddAnotherCard.Enabled = false;

            buttonCheckout.Enabled = false;
            currentUser = (User)Tag;
            checkout.Tag = currentUser;
            addCard.Tag = currentUser;
            getInventory();
            try
            {
                cartList.Clear();
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

                            

                                cartList.Add(prod);
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

            try
            {
                selectColumn.Name = "Add To Checkout";
                selectColumn.HeaderText = "Add To Checkout";
                selectColumn.Width = 50;
                selectColumn.ReadOnly = false;
                selectColumn.FillWeight = 10;
                dataGridViewCart.Columns.Add(selectColumn);
                dataGridViewCart.DataSource = cartList;
                dataGridViewCart.Columns.Remove("maxStock");
                dataGridViewCart.Columns.Remove("reorderPoint");
                dataGridViewCart.Columns.Remove("isHazardous");
                dataGridViewCart.Columns.Remove("expDate");
                dataGridViewCart.Columns.Remove("numsold");
                dataGridViewCart.Columns.Remove("numInCart");
                dataGridViewCart.Columns.Remove("detailID");
                dataGridViewCart.Columns.Remove("reorderAmount");
                dataGridViewCart.Columns.Remove("receiptID");
                dataGridViewCart.Columns.Remove("amountOrdered");
                dataGridViewCart.Columns.Remove("lastSold");
                currentUser = (User)Tag;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
            try
            {
                savedCards.Clear();
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetUserCards", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;


                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        string cardLastFour;
                        string cardType;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cardType = reader.GetString(9);
                                cardLastFour = reader.GetString(14);
                                savedCards.Add(cardType + " Ending in..." + cardLastFour);
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
            comboBoxSavedCards.DataSource = savedCards;
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = (Product)dataGridViewCart.CurrentRow.DataBoundItem;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            
            foreach (Product prod in checkoutItems)
            {
                foreach (Product inv in inventory)
                {
                    if (prod.productID.Equals(inv.productID) && inv.numStock >0 && prod.numInCart<= inv.numStock)
                    {
                        purchasedItems.Add(prod);
                        updateStock(prod);
                        numSoldUpdate(prod);
                        lastSoldUpdate(prod);
                        inv.numStock -= prod.numInCart;
                        buttonCheckout.Enabled = false;
                        removeFromCart(prod);
                    }
                    else if(prod.productID.Equals(inv.productID) && prod.numInCart > inv.numStock) 
                    {
                        MessageBox.Show("Were sorry we do not have "+prod.numInCart+" "+prod.productName+" In Stock");
                        numItems -= prod.numInCart;
                        subTotal -= (prod.price * prod.numInCart);
                        recalcTotals();
                        buttonCheckout.Enabled = false;
                    }

                    else if (prod.productID.Equals(inv.productID) && inv.numStock <= 0)
                    {
                        MessageBox.Show("Sorry the "+prod.productName+" is currently out of stock please check back later...");
                        numItems -= prod.numInCart;
                        subTotal -= (prod.price*prod.numInCart);
                        recalcTotals();
                        buttonCheckout.Enabled = false;
                    }
                    
                    
                }
                createReceipt();
                getReceiptID();
                createReceiptDetails();
                getInventory(); 
                             
            }
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateTotalSpent", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                        cmd.Parameters.Add("@totalSpent", SqlDbType.VarChar, 100).Value = orderTotal.ToString();

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
            createReceiptFile();
            reloadCart();
        }

        private void buttonAddAnotherCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCard.ShowDialog();
            this.Close();
        }

        private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        public void updateStock (Product prod)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateStockQty", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
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

        private void lastSoldUpdate(Product prod)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateLastSold", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                        cmd.Parameters.Add("@lastSold", SqlDbType.Date, 100).Value = DateTime.Now.ToString("yyyy-MM-dd");


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

        private void numSoldUpdate(Product prod)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_UpdateNumSold", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                        cmd.Parameters.Add("@numSold", SqlDbType.Int, 100).Value = prod.numInCart;


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


        private void buttonGetTotals_Click(object sender, EventArgs e)
        {

            subTotal = 0;
            stateTax = 0;
            fedTax = 0;
            orderTotal = 0;
            checkoutItems.Clear();
           
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (Convert.ToBoolean(row.Cells[selectColumn.Name].Value) == true)
                {
                    checkoutItems.Add((Product)row.DataBoundItem);
                }
            }

            foreach (Product prod in checkoutItems)
            {
                subTotal += prod.price * prod.numInCart;
                numItems += 1;
            }



            if (currentUser.membershipLevel.Equals("Bronze"))
            {
                subTotal -= (subTotal * .02);
                labelDiscountLevel.Text = "Current Membership Discount: 2%";
            }

            if (currentUser.membershipLevel.Equals("Silver"))
            {
                subTotal -= (subTotal * .035);
                labelDiscountLevel.Text = "Current Membership Discount: 3.5%";
            }
            if (currentUser.membershipLevel.Equals("Gold"))
            {
                subTotal -= (subTotal * .045);
                labelDiscountLevel.Text = "Current Membership Discount: 4.5%";
            }

            subTotal = Math.Round(subTotal,2);

            if (currentUser.country.Equals("Canada"))
            {
                fedTax = Math.Round((CANADIAN_DOLLAR_CONVERSION* subTotal) * FEDERAL_TAX, 2);
                stateTax = Math.Round((CANADIAN_DOLLAR_CONVERSION * subTotal) * STATE_TAX, 2);
                orderTotal = Math.Round((CANADIAN_DOLLAR_CONVERSION * subTotal) + fedTax + stateTax, 2);
                labelSubTotal.Text = "SubTotal: $(CAD) " + subTotal;
                labelFedTax.Text = "Federal Tax: $(CAD)" + fedTax;
                labelStateTax.Text = "State Tax: $(CAD)" + stateTax;
                labelGrandTotal.Text = "GrandTotal: $(CAD)" + orderTotal;
            }
            else if (currentUser.country.Equals("United States of America"))
            {
                fedTax = Math.Round(subTotal * FEDERAL_TAX, 2);
                stateTax = Math.Round(subTotal * STATE_TAX, 2);
                orderTotal = Math.Round(subTotal + fedTax + stateTax, 2);
                labelSubTotal.Text = "SubTotal: $" + subTotal;
                labelFedTax.Text = "Federal Tax: $" + fedTax;
                labelStateTax.Text = "State Tax: $" + stateTax;
                labelGrandTotal.Text = "GrandTotal: $" + orderTotal;
            }

            

           
            buttonCheckout.Enabled = true;
        }

        private void getInventory()
        {
            inventory.Clear();
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

                                inventory.Add(prod);
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

        private void recalcTotals()
        {
            if (currentUser.country.Equals("Canada"))
            {
                fedTax = Math.Round((CANADIAN_DOLLAR_CONVERSION * subTotal) * FEDERAL_TAX, 2);
                stateTax = Math.Round((CANADIAN_DOLLAR_CONVERSION * subTotal) * STATE_TAX, 2);
                orderTotal = Math.Round((CANADIAN_DOLLAR_CONVERSION * subTotal) + fedTax + stateTax, 2);
                labelSubTotal.Text = "SubTotal: $(CAD) " + subTotal;
                labelFedTax.Text = "Federal Tax: $(CAD)" + fedTax;
                labelStateTax.Text = "State Tax: $(CAD)" + stateTax;
                labelGrandTotal.Text = "GrandTotal: $(CAD)" + orderTotal;
            }
            else if (currentUser.country.Equals("United States of America"))
            {
                fedTax = Math.Round(subTotal * FEDERAL_TAX, 2);
                stateTax = Math.Round(subTotal * STATE_TAX, 2);
                orderTotal = Math.Round(subTotal + fedTax + stateTax, 2);
                labelSubTotal.Text = "SubTotal: $" + subTotal;
                labelFedTax.Text = "Federal Tax: $" + fedTax;
                labelStateTax.Text = "State Tax: $" + stateTax;
                labelGrandTotal.Text = "GrandTotal: $" + orderTotal;
            }
        }

        private void createReceipt()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_AddReceiptHeader", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                        cmd.Parameters.Add("@orderSubTotal", SqlDbType.VarChar, 25).Value = subTotal ;
                        cmd.Parameters.Add("@orderFederalTax", SqlDbType.VarChar, 25).Value = fedTax ;
                        cmd.Parameters.Add("@orderStateTax", SqlDbType.VarChar, 25).Value = stateTax;
                        cmd.Parameters.Add("@orderGrandTotal", SqlDbType.VarChar, 25).Value = orderTotal;

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

        private void getReceiptID()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_GetReceiptID", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                     

                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {

                            reader.Read();
                            receiptID = (int)reader["receiptID"];

                            
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


        private void createReceiptDetails()
        {
            foreach (Product prod in purchasedItems)
            {
                for (int ctr = 1; ctr <= prod.numInCart; ctr++)
                {

                    try
                    {
                        using (SqlConnection cn = new SqlConnection(_cnDB))
                        {

                            using (SqlCommand cmd = new SqlCommand("usp_AddReceiptDetail", cn))
                            {


                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                                cmd.Parameters.Add("@receiptID", SqlDbType.Int, 100).Value = receiptID;
                                cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = prod.productID;
                                cmd.Parameters.Add("@productName", SqlDbType.VarChar, 100).Value = prod.productName;
                                cmd.Parameters.Add("@productDescription", SqlDbType.VarChar, 255).Value = prod.productDesc;
                                cmd.Parameters.Add("@productCategory", SqlDbType.VarChar, 50).Value = prod.category;
                                cmd.Parameters.Add("@price", SqlDbType.VarChar, 20).Value = prod.price;
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
        }

        private void removeFromCart(Product prod)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_RemoveCartItem", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
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

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            Product removedItem = new Product();
            removedItem= (Product)dataGridViewCart.CurrentRow.DataBoundItem;
            if (removedItem.numInCart - Convert.ToInt32(textBoxQty.Text) > 0)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_UpdateCartQty", cn))
                        {


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                            cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = removedItem.productID;
                            cmd.Parameters.Add("@Qty", SqlDbType.Int, 100).Value = (-(Convert.ToInt32(textBoxQty.Text)));
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
            if (removedItem.numInCart - Convert.ToInt32(textBoxQty.Text) <= 0)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_RemoveCartItem", cn))
                        {


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                            cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = removedItem.productID;
   
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
            reloadCart();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
            frmCustomer cust = new frmCustomer();
            cust.Tag = currentUser;
            cust.ShowDialog();
            Close();
        }

        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxQty.Text) >= selectedItem.numInCart)
            {
                MessageBox.Show("You have reached the maximum available quantity in your cart for that item.");
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
                textBoxQty.Text = "1";

            }
           
        }

        private void reloadCart()
        {
            try
            {
                cartList.Clear();
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



                                cartList.Add(prod);
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
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cartList;
            try
            {
                selectColumn.Name = "Add To Checkout";
                selectColumn.HeaderText = "Add To Checkout";
                selectColumn.Width = 50;
                selectColumn.ReadOnly = false;
                selectColumn.FillWeight = 10;
                dataGridViewCart.Columns.Add(selectColumn);
                dataGridViewCart.DataSource = cartList;
                dataGridViewCart.Columns.Remove("maxStock");
                dataGridViewCart.Columns.Remove("reorderPoint");
                dataGridViewCart.Columns.Remove("isHazardous");
                dataGridViewCart.Columns.Remove("expDate");
                dataGridViewCart.Columns.Remove("numsold");
                dataGridViewCart.Columns.Remove("numInCart");
                dataGridViewCart.Columns.Remove("detailID");
                dataGridViewCart.Columns.Remove("reorderAmount");
                dataGridViewCart.Columns.Remove("receiptID");
                dataGridViewCart.Columns.Remove("amountOrdered");
                dataGridViewCart.Columns.Remove("lastSold");

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Product removedItem = new Product();
            if (dataGridViewCart.CurrentRow.DataBoundItem != null)
            {
                removedItem = (Product)dataGridViewCart.CurrentRow.DataBoundItem;
                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_RemoveCartItem", cn))
                        {


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@userID", SqlDbType.Int, 100).Value = currentUser.userID;
                            cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = removedItem.productID;

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
                reloadCart();
            }
        }

        private void createReceiptFile()
        {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "Receipt "+currentUser.firstName+" "+currentUser.lastName + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = Path.Combine(myDocsPath, fileName);
            try
            {
                FileStream mystream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter file = new StreamWriter(mystream);
                foreach (Product prod in purchasedItems)
                {
                    file.WriteLine("Number purchased " + prod.numInCart.ToString() + " " + prod);
                }

                file.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Exception : " + ex.Message.ToString());
            }
        }

        private void comboBoxSavedCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSavedCards.Text == "")
            {
                buttonCheckout.Enabled = false;
            }
            
        }

        private void dataGridViewCart_SelectionChanged(object sender, EventArgs e)
        {
            buttonCheckout.Enabled = false;

           // selectedItem = (Product)dataGridViewCart.CurrentRow.DataBoundItem;
            textBoxQty.Text = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxSavedCards.Enabled = false;
            buttonAddAnotherCard.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxSavedCards.Enabled = true;
            buttonAddAnotherCard.Enabled = true;
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                for (int i = 0; i < dataGridViewCart.RowCount; i++)
                {
                    dataGridViewCart.Rows[i].DataGridView[0, i].Value = true;
                    buttonCheckout.Enabled = false;
                }

            }else
            {
                for (int i = 0; i < dataGridViewCart.RowCount; i++)
                {
                    dataGridViewCart.Rows[i].DataGridView[0, i].Value = false;
                    buttonCheckout.Enabled = false;
                }
            }
        }
    }
}
