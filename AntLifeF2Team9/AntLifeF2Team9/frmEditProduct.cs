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
    public partial class frmEditProduct : Form
    {
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;
        
        Product editedProd = new Product();

        public frmEditProduct()
        {
            InitializeComponent();
        }
        #region methods for validation
        public bool nameCheck()
        {
            string textNameF = textBoxName.Text;

            if (textNameF.Length > 3)
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Product Name(Atleast 3 Characters).", "Input Error");

                textBoxName.Clear();
                textBoxName.Focus();

                return false;
            }

        }
        public bool descCheck()
        {
            string desc = textBoxName.Text;

            if (desc.Length > 6)
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Product Description(Atleast 6 Characters).", "Input Error");

                textBoxDesc.Clear();
                textBoxDesc.Focus();

                return false;
            }

        }
        public bool catCheck()
        {
            string cat = textBoxCategory.Text;

            if (cat.Length > 3)
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Category(Atleast 3 Characters).", "Input Error");

                textBoxCategory.Clear();
                textBoxCategory.Focus();

                return false;
            }

        }
        public bool priceCheck()
        {
            string prc = textBoxCategory.Text;

            if (prc != "")
                return true;
            else
            {
                MessageBox.Show("Please enter a valid Price.", "Input Error");

                textBoxPrice.Clear();
                textBoxPrice.Focus();

                return false;
            }
        }
        public bool curStockCheck()
        {
            if (textBoxNumStock.Text != "")
            {
                int prc = Convert.ToInt32(textBoxNumStock.Text);
                if (prc < 0)
                {
                    MessageBox.Show("Please enter a valid Current Stock.", "Input Error");

                    textBoxNumStock.Clear();
                    textBoxNumStock.Focus();
                    return false;
                }
                else return true;
            }
            else MessageBox.Show("Please enter a valid Current Stock.", "Input Error");
            return false;
        }
        public bool maxStockCheck()
        {
            if (textBoxMaxStock.Text != "")
            {
                int prc = Convert.ToInt32(textBoxMaxStock.Text);
                if (prc < 0)
                {
                    MessageBox.Show("Please enter a valid Max Stock.", "Input Error");

                    textBoxMaxStock.Clear();
                    textBoxMaxStock.Focus();
                    return false;
                }
                else return true;
            }
            else MessageBox.Show("Please enter a valid Max Stock.", "Input Error");
            return false;
        }
        public bool reorderAmtStockCheck()
        {
            if (textBoxReorder.Text != "")
            {
                int ramt = Convert.ToInt32(textBoxReorder.Text);
                if (ramt < 0)
                {
                    MessageBox.Show("Please enter a valid Reorder Point.", "Input Error");

                    textBoxReorder.Clear();
                    textBoxReorder.Focus();
                    return false;
                }
                else return true;
            }else
                MessageBox.Show("Please enter a valid Reorder Point.", "Input Error");
            return false;
        }
        public bool reAmtStockCheck()
        {
            if (textBoxReorderAmount.Text != "")
            {
                int amt = Convert.ToInt32(textBoxReorderAmount.Text);
                if (amt < 0)
                {
                    MessageBox.Show("Please enter a valid Reorder Amount.", "Input Error");

                    textBoxReorderAmount.Clear();
                    textBoxReorderAmount.Focus();
                    return false;
                }
                else return true;
            }
            else
                MessageBox.Show("Please enter a valid Reorder Amount.", "Input Error");
            return false;
        }

        #endregion

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            #region ErrorHandling
            bool validName = nameCheck();
            bool validDesc;
            bool validCat;
            bool validPrice;
            bool validCur;
            bool validMax;
            bool validMin;
            bool goodToGo;

            if (validName)
                validDesc = descCheck();
            else return;
            if (validDesc)
                validCat = catCheck();
            else return;
            if (validCat)
                validPrice = priceCheck();
            else return;
            if (validPrice)
                validCur = curStockCheck();
            else return;
            if (validCur)
                validMax = maxStockCheck();
            else return;
            if (validMax)
                validMin = reorderAmtStockCheck();
            else return;
            if (validMin)
                goodToGo = reAmtStockCheck();
            else return;
            #endregion
            if (goodToGo)
            {
                string hazard;
                string date;
                if (checkBoxExpDate.Checked) date = textBoxExpYear.Text + "-" + comboBoxMonth.Text + "-" + comboBoxDay.Text;
                else date = "0001-01-01";
                if (checkBoxHazard.Checked)
                {
                    hazard = "Yes";
                }
                else
                {
                    hazard = "No";
                }

                try
                {
                    using (SqlConnection cn = new SqlConnection(_cnDB))
                    {

                        using (SqlCommand cmd = new SqlCommand("usp_EditProduct", cn))
                        {



                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@productID", SqlDbType.Int, 100).Value = editedProd.productID;
                            cmd.Parameters.Add("@productName", SqlDbType.VarChar, 100).Value = textBoxName.Text;
                            cmd.Parameters.Add("@productDescription", SqlDbType.VarChar, 255).Value = textBoxDesc.Text;
                            cmd.Parameters.Add("@productCategory", SqlDbType.VarChar, 50).Value = textBoxCategory.Text;
                            cmd.Parameters.Add("@price", SqlDbType.VarChar, 20).Value = textBoxPrice.Text;
                            cmd.Parameters.Add("@expirationDate", SqlDbType.Date, 25).Value = date;
                            cmd.Parameters.Add("@isHazardous", SqlDbType.VarChar, 3).Value = hazard;
                            cmd.Parameters.Add("@numberInStock", SqlDbType.Int, 7).Value = textBoxNumStock.Text;
                            cmd.Parameters.Add("@maxStock", SqlDbType.Int, 30).Value = textBoxMaxStock.Text;
                            cmd.Parameters.Add("@reorderPoint", SqlDbType.Int, 50).Value = textBoxReorder.Text;
                            cmd.Parameters.Add("@reorderAmount", SqlDbType.Int, 50).Value = textBoxReorderAmount.Text;



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
                frmManageInventory invMng = new frmManageInventory();
                Hide();
                invMng.ShowDialog();
                Close();
            }
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {

            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;

            editedProd = (Product)Tag;
            textBoxCategory.Text = editedProd.category;
            textBoxDesc.Text = editedProd.productDesc;
            textBoxMaxStock.Text = editedProd.maxStock.ToString();
            textBoxName.Text = editedProd.productName;
            textBoxNumStock.Text = editedProd.numStock.ToString();
            textBoxPrice.Text = editedProd.price.ToString();
            textBoxReorder.Text = editedProd.reorderPoint.ToString();
            if (editedProd.isHazardous) checkBoxHazard.Checked = true;
            loadComboBoxes();
        }
        private void loadComboBoxes()
        {
            List<string> months = new List<string>();
            List<string> days = new List<string>();

            for (int i = 1; i <= 31; i++)
            {
                days.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                months.Add(i.ToString());
            }

            comboBoxDay.DataSource = days;
            comboBoxMonth.DataSource = months;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> days = new List<string>();
            int currentMonth = Convert.ToInt32(comboBoxMonth.Text);
            switch (currentMonth)
            {
                case 1:
                    {
                        days.Clear();
                        for (int i = 1; i <= 31; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 2:
                    {
                        days.Clear();
                        for (int i = 1; i <= 29; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 3:
                    {
                        days.Clear();
                        for (int i = 1; i <= 31; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 4:
                    {
                        days.Clear();
                        for (int i = 1; i <= 30; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 5:
                    {
                        days.Clear();
                        for (int i = 1; i <= 31; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 6:
                    {
                        days.Clear();
                        for (int i = 1; i <= 30; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 7:
                    {
                        days.Clear();
                        for (int i = 1; i <= 31; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 8:
                    {
                        days.Clear();
                        for (int i = 1; i <= 31; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 9:
                    {
                        days.Clear();
                        for (int i = 1; i <= 30; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 10:
                    {
                        days.Clear();
                        for (int i = 1; i <= 31; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 11:
                    {
                        days.Clear();
                        for (int i = 1; i <= 30; i++)
                        {
                            days.Add(i.ToString());
                        }
                        comboBoxDay.DataSource = days;
                    }
                    break;
                case 12:
                    days.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        days.Add(i.ToString());
                    }
                    comboBoxDay.DataSource = days;
                    break;
                default:
                    for (int i = 1; i <= 31; i++)
                    {
                        days.Clear();
                        days.Add(i.ToString());
                    }
                    comboBoxDay.DataSource = days;
                    break;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            frmManageInventory invMng = new frmManageInventory();
            Hide();
            invMng.ShowDialog();
            Close();
        }

        private void textBoxExpYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxNumStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxMaxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxReorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxReorderAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
