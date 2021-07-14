using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phamacy_Management_System
{
    public partial class DebtRegFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        public DebtRegFrm()
        {
            InitializeComponent();
            this.debtRegRegbtn.Enabled = false;
        }

        private void validateDebtRegbtn()
        {
            this.debtRegRegbtn.Enabled = ((debtRegNametxt.Text.Length != 0) && (debtRegAddtxt.Text.Length != 0) && (debtRegPhone1txt.Text.Length != 0) && (debtRegISSNtxt.Text.Length != 0) && (debtRegMaxDebttxt.Text.Length != 0));
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void debtRegCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                          
        }

        private void debtAddPhone2btn_Click(object sender, EventArgs e)
        {
            if (debtAddPhone2btn.Text == "+")
            {
                debtRegPhone2txt.Visible = true;
                debtAddPhone2btn.Text = "-";
            }
            else
            {
                debtAddPhone2btn.Text = "+";
                debtRegPhone2txt.Visible = false;
            }
        }

        private void debtRegRegbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into debt(debtName,debtAdd,debtPhone1,debtPhone2,debtSSN,maxDebt,debtPend,debtPay) values ('" + debtRegNametxt.Text + "','" + debtRegAddtxt.Text + "', '" + debtRegPhone1txt.Text + "', '" + debtRegPhone2txt.Text + "', " + debtRegISSNtxt.Text + ",'" + debtRegMaxDebttxt.Text + "','" + debtRegMaxDebttxt.Text + "','0')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Debtor registered in the pharmacy system successfully");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void DebtRegFrm_Load(object sender, EventArgs e)
        {

        }

        private void debtRegNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void debtRegAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void debtPhonesKeyPraess(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('+') > -1)
            {
                e.Handled = true;
            }
        }

        private void debtRegISSNtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void debtMoneyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void debtRegTextValidating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            validateDebtRegbtn();


        }

        private void debtRegTextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            validateDebtRegbtn();
        }
    }
}
