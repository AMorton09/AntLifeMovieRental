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
    public partial class Checkout : Form
    {
        User currentUser = new User();
        frmAddNewCard addCard = new frmAddNewCard();
        
        public Checkout()
        {
            InitializeComponent();
        }
        List<string> savedCards = new List<string>();
        private string _cnDB = AntLifeF2Team9.Properties.Settings.Default.F2T9ConnectionString;

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color; currentUser = (User)Tag;
            labelOrderSubTotal.Text = "Order Total: " + orderTotal.ToString();
            
        }
        
        

        public double orderTotal { get; set; }
        public int numItems { get; set; }
        


        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void comboBoxSavedCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
