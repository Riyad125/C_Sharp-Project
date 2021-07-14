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
    public partial class EmpEditFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        string getPerm;
        string getEmpPerm;
        string z;
        public EmpEditFrm()
        {
            InitializeComponent();
          //  this.empShowInfobtn.Enabled = false;
            this.empInfoUpdatebtn.Enabled = false;
            this.empInfoDeletebtn.Enabled = false;
        }

        private void validateShowInfobtn()
        {
            this.empShowInfobtn.Enabled = ((empIDShowInfotxt.Text.Length != 0) || (empNameShowInfotxt.Text.Length != 0));

        }
        private void validateDeletebtn()
        {
            this.empInfoDeletebtn.Enabled = ((empIDShowInfotxt.Text.Length != 0) || (empNameShowInfotxt.Text.Length != 0));

        }

        private void validateUpdatebtn()
        {
            this.empInfoUpdatebtn.Enabled = ((empEditNametxt.Text.Length != 0) && (empEditAddtxt.Text.Length != 0) && (empEditPhone1txt.Text.Length != 0) && (empEditSSNtxt.Text.Length != 0) && (empEditQualftxt.Text.Length != 0) && (empEditPasstxt.Text.Length != 0));

        }
        private void EmpEditFrm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(649, 180);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empShowInfobtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select empName,empAdd,empBdate,empPhone1,empPhone2,empEmail,empQualf,empSSN,empId,empPass,empPerm,empid from emp where empId='" + empIDShowInfotxt.Text + "' or empName='" + empNameShowInfotxt.Text + "'", cn);
                this.Size = new Size(649, 650);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                z = dr["empid"].ToString();
                empEditNametxt.Text = dr["empName"].ToString();
                empEditAddtxt.Text = dr["empAdd"].ToString();
                empEditBdatePicker.Text = dr["empBdate"].ToString();
                empEditPhone1txt.Text = dr["empPhone1"].ToString();
                empEditPhone2txt.Text = dr["empPhone2"].ToString();
                empEditEmailtxt.Text = dr["empEmail"].ToString();
                empEditQualftxt.Text = dr["empQualf"].ToString();
                empEditSSNtxt.Text = dr["empSSN"].ToString();
                empEditIdtxt.Text = dr["empId"].ToString();
                empEditPasstxt.Text = dr["empPass"].ToString();
                getEmpPerm = dr["empPerm"].ToString();

                if (getEmpPerm == "Manager")
                {
                    mangPermrdb.Checked = true;
                }
                else
                {
                    employPermrdb.Checked = true;
                }
                dr.Close();
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

        }

        private void empInfoDeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from emp  where empid =" + z + " ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted from system successfully");
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

        private void empInfoUpdatebtn_Click(object sender, EventArgs e)
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

                cmd = new SqlCommand("update emp set empName='" + empEditNametxt.Text + "',empAdd='" + empEditAddtxt.Text + "',empBdate='" + empEditBdatePicker.Text + "',empPhone1='" + empEditPhone1txt.Text + "',empPhone2='" + empEditPhone2txt.Text + "',empEmail='" + empEditEmailtxt.Text + "',empSSN='" + empEditSSNtxt.Text + "',empQualf='" + empEditQualftxt.Text + "' ,emppass='" + empEditPasstxt.Text + "',empPerm='" + getPerm + "'  where empid =" + z + " ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee information updated successfully");
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

        private void empIDShowInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void empNameShowInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void empEditNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void empEditAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }



        private void empEditEmailtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('@') > -1)
            {
                e.Handled = true;
            }
        }

        private void empEditQualftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void empEditPasstxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void empPhonesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && (sender as TextBox).Text.IndexOf('+') > -1)
            {
                e.Handled = true;
            }
        }

        private void empEditSSNtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ShowInfoTextValidating(object sender, CancelEventArgs e)
        {
            validateShowInfobtn();
            validateDeletebtn();
        }

        private void showInfoTextValidating(object sender, EventArgs e)
        {
            validateShowInfobtn();
            validateDeletebtn();
        }

        private void empInfoTextValidating(object sender, CancelEventArgs e)
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
            validateUpdatebtn();
        }

        private void empInfoTextChanged(object sender, EventArgs e)
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
            validateUpdatebtn();
        }

        private void EmpEditFrm_Validating(object sender, CancelEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
