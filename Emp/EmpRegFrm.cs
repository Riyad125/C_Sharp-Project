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
using System.Text.RegularExpressions;

namespace Phamacy_Management_System
{
    public partial class EmpRegFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        string getPerm;
        public EmpRegFrm()
        {
            InitializeComponent();
            this.empRegRegbtn.Enabled = false;
        }

        private void vaildateRegbtn()
        {

            this.empRegRegbtn.Enabled = ((empRegNametxt.Text.Length != 0) && (empRegAddtxt.Text.Length != 0) && (empRegPhone1txt.Text.Length != 0) && (empRegSSNtxt.Text.Length != 0) && (empRegQualftxt.Text.Length != 0) && (empRegPasstxt.Text.Length != 0));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void EmpRegFrm_Load(object sender, EventArgs e)
        {
            try
            {

               // textBox1.Text = DateTime.Now.ToString("yyyy/MM/dd");
                cmd = new SqlCommand("select max(empId)+1 as empId from emp", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                empRegIdtxt.Text = dr["empId"].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                cn.Close();
            }

        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empAddPhone2btn_Click(object sender, EventArgs e)
        {
            if (empAddPhone2btn.Text == "+")
            {
                empRegPhone2txt.Visible = true;
                empAddPhone2btn.Text = "-";
            }
            else
            {
                empAddPhone2btn.Text = "+";
                empRegPhone2txt.Visible = false;
            }
        }

        private void empRegRegbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mangPermrdb.Checked == true)
                {
                    getPerm = "Manager";
                }
                else
                {
                    getPerm = "Employee";
                }

                cn.Open();
                cmd = new SqlCommand("insert into emp(empName,empAdd,empBdate,empPhone1,empPhone2,empSSN,empEmail,empQualf,empPass,empPerm) values ('" + empRegNametxt.Text + "','" + empRegAddtxt.Text + "', '" + empRegBdatePicker.Text + "', '" + empRegPhone1txt.Text + "', '" + empRegPhone2txt.Text + "'," + empRegSSNtxt.Text + " ,'" + empRegEmailtxt.Text + "','" + empRegQualftxt.Text + "','" + empRegPasstxt.Text + "','" + getPerm + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee registered in the pharmacy system successfully");
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

        private void mangPermrdb_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void empRegNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void empRegAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }



        private void empRegEmailtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void empRegQualftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void empRegPasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void empPhonesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('+') > -1)
            {
                e.Handled = true;
            }
        }

        private void empRegSSNtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textValidatingEvent(object sender, CancelEventArgs e)
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
            vaildateRegbtn();
        }

        private void textChangedEvent(object sender, EventArgs e)
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
            vaildateRegbtn();
        }

        private void empRegEmailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void empRegEmailtxt_MouseLeave(object sender, EventArgs e)
        {

        }

        private void empRegEmailtxt_Leave(object sender, EventArgs e)
        {

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(empRegEmailtxt.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.empRegEmailtxt,"Please set Valid Email Address");
                return;
            }
        }

        private void empRegIdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
