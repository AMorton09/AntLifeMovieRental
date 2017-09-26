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
    public partial class frmDOB : Form
    {
        public frmDOB()
        {
            InitializeComponent();
        }
        private void frmDOB_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            buttonAccept.Enabled = false;
            Color color = Color.FromName(globalClass.BackColor);
            this.BackColor = color; loadComboBoxes();
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
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Tag = textBoxYear.Text + "-" + comboBoxMonth.Text + "-" + comboBoxDay.Text;
            Close();
        }
        #region Event Handler

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

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxYear.Text) > 1900)
            {
                buttonAccept.Enabled = true;
            }
            else
                buttonAccept.Enabled = false;

        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

    }
}
