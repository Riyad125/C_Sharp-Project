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
    public partial class DelRegFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public DelRegFrm()
        {
            InitializeComponent();
            this.delRegbtn.Enabled = false;
            da = new SqlDataAdapter("select compId,compName from comp",cn);
            da.Fill(dt);
            compcmbo.DataSource = dt;
            compcmbo.DisplayMember = "compName";
            compcmbo.ValueMember = "compId";
        }

        private void validateDelRegbtn()
        {
            this.delRegbtn.Enabled = ((delRegNametxt.Text.Length != 0) && (delRegAddtxt.Text.Length != 0) && (delRegPhone1txt.Text.Length != 0));
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
               
        }

        private void delAddPhone2btn_Click(object sender, EventArgs e)
        {
            if (delAddPhone2btn.Text == "+")
            {
                delRegPhone2txt.Visible = true;
                delAddPhone2btn.Text = "-";
            }
            else
            {
                delAddPhone2btn.Text = "+";
                delRegPhone2txt.Visible = false;
            }
        }

        private void DelRegFrm_Load(object sender, EventArgs e)
        {

        }

        private void delRegbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into del(delName,delAdd,delPhone1,delPhone2,compId) values ('" + delRegNametxt.Text + "','" + delRegAddtxt.Text + "', '" + delRegPhone1txt.Text + "', '" + delRegPhone2txt.Text + "', '" + compcmbo.SelectedValue + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delegate registered in the pharmacy system successfully");
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

        private void delRegNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void delRegAddtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void delRegTextValidating(object sender, CancelEventArgs e)
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
            validateDelRegbtn();


        }

        private void delRegTextChanged(object sender, EventArgs e)
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
            validateDelRegbtn();
        }
    }
}
