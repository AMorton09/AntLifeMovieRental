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
    public partial class frmEmployee : Form
    {
        
        User currentUser = new User();
        
        
       
        public frmEmployee()
        {
            InitializeComponent();
            
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            currentUser = (User)this.Tag;
            
            frmManageEmp manage = new frmManageEmp();
            manage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageInventory manageInv = new frmManageInventory();
            manageInv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            frmSettings settings = new frmSettings();
            settings.ShowDialog();
            Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin logins = new frmLogin();
            logins.ShowDialog();
            Close();
        }
      
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color;
        }
        //reports
        private void button2_Click(object sender, EventArgs e)
        {
            frmReports report = new frmReports();
            report.ShowDialog();
        }
    }
}
