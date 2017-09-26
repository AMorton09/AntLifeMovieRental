using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AntLifeF2Team9
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            comboBox1.Text = "Blue";

        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
        }
        protected override void OnLoad(EventArgs e)
        {
            
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmEmployee emp = new frmEmployee();
           
            emp.ShowDialog();
            this.Close();

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Gray")
            {
                globalClass.BackColor = "LightSlateGray";
                this.BackColor = Color.LightSlateGray;
            }
            else if (comboBox1.Text == "Blue")
            {
                globalClass.BackColor = "CornflowerBlue";
                this.BackColor = Color.CornflowerBlue;
            }
            else if (comboBox1.Text == "Navajo")
            {
                globalClass.BackColor = "NavajoWhite";
                this.BackColor = Color.NavajoWhite;
            }
            else if (comboBox1.Text == "Green")
            {
                globalClass.BackColor = "MediumSeaGreen";
                this.BackColor = Color.DarkGreen;
            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
