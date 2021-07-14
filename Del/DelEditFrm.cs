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
    public partial class DelEditFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        int delIdent;
        public DelEditFrm(int delIdVar)
        {
            InitializeComponent();
            this.delUpdatebtn.Enabled = false;
            delIdent = delIdVar; 
        }

        private void validateDelUpdatebtn()
        {
            this.delUpdatebtn.Enabled = ((delEditNametxt.Text.Length != 0) && (delEditAddtxt.Text.Length != 0) && (delEditPhone1txt.Text.Length != 0));
        }
        private void delEditPhone2btn_Click(object sender, EventArgs e)
        {
        }

        private void DelEditFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select delName,delAdd,delPhone1,delPhone2 from del where delId= '" + Convert.ToInt32(delIdent) + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                delEditNametxt.Text = dr["delName"].ToString();
                delEditAddtxt.Text = dr["delAdd"].ToString();
                delEditPhone1txt.Text = dr["delPhone1"].ToString();
                delEditPhone2txt.Text = dr["delPhone2"].ToString();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
        }

        public string delId { get; set; }

        private void delUpdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update del set delName='" + delEditNametxt.Text + "',delAdd='" + delEditAddtxt.Text + "',delPhone1='" + delEditPhone1txt.Text + "',delPhone2='" + delEditPhone2txt.Text + "'", cn);
                MessageBox.Show("Delegate information updated successfully");
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

        private void delDeletebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void delCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delEditNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void delEditAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void delPhonesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('+') > -1)
            {
                e.Handled = true;
            }
        }

        private void delUpdateTextValidating(object sender, CancelEventArgs e)
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
            validateDelUpdatebtn();
        }

        private void delUpdateTextChanged(object sender, EventArgs e)
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
            validateDelUpdatebtn();
        }
    }
}
