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
    public partial class CompRegFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        public CompRegFrm()
        {
            InitializeComponent();
            this.compRegRegbtn.Enabled = false;
        }

        private void validateRegbtn()
        {
            this.compRegRegbtn.Enabled = ((compRegNametxt.Text.Length != 0) && (compRegAddtxt.Text.Length != 0) && (compRegPhone1txt.Text.Length != 0));
        }

        private void compRegCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compRegRegbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into comp(compName,compAdd,compPhone1,compPhone2,compEmail) values ('" + compRegNametxt.Text + "','" + compRegAddtxt.Text + "', '" + compRegPhone1txt.Text + "', '" + compRegPhone2txt.Text + "', '" + compRegEmailtxt.Text + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company registered in the pharmacy system successfully");
                DelRegFrm delRegFrm = new DelRegFrm();
                delRegFrm.Show();
                this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (compAddPhonebtn.Text == "+")
            {
                compRegPhone2txt.Visible = true;
                compAddPhonebtn.Text = "-";
            }
            else
            {
                compAddPhonebtn.Text = "+";
                compRegPhone2txt.Visible = false;
            }
        }

        private void CompRegFrm_Load(object sender, EventArgs e)
        {

        }

        private void compRegNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void compRegAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void compPhonesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('+') > -1)
            {
                e.Handled = true;
            }
        }

        private void compRegEmailtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('@') > -1)
            {
                e.Handled = true;
            }
        }

        private void compRegPhone1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void compRegValidating(object sender, CancelEventArgs e)
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
            validateRegbtn();


        }

        private void compRegTextChanged(object sender, EventArgs e)
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
            validateRegbtn();
        }
    }
}
