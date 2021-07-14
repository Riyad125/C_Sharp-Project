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

    public partial class CompEditFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        int delIdVar = 0;
        string z;
        public CompEditFrm()
        {
            InitializeComponent();
            this.compShowInfobtn.Enabled = false;
            this.compInfoUpdatebtn.Enabled = false;
            this.compInfoDeletebtn.Enabled = false;


        }

        private void validateShowInfobtn()
        {
            this.compShowInfobtn.Enabled = ((compNameShowInfotxt.Text.Length != 0) || (compIDShowInfotxt.Text.Length != 0));
        }
        private void validateDeletebtn()
        {
            this.compInfoDeletebtn.Enabled = ((compNameShowInfotxt.Text.Length != 0) || (compIDShowInfotxt.Text.Length != 0));
        }

        private void validateUpdatebtn()
        {
            this.compInfoUpdatebtn.Enabled = ((compEditNametxt.Text.Length != 0) && (compEditAddtxt.Text.Length != 0) && (compEditPhone1txt.Text.Length != 0));
        }
        private void CompEditFrm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(589, 180);

            AutoCompleteStringCollection LocalDataTable = new AutoCompleteStringCollection();

            compNameShowInfotxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            compNameShowInfotxt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            compNameShowInfotxt.AutoCompleteCustomSource = LocalDataTable;


            cn.Open();
            SqlCommand cmd = new SqlCommand("select compname from comp", cn);

            SqlDataReader rd2 = cmd.ExecuteReader();

            if (rd2.HasRows == true)
            {

                while (rd2.Read())
                {

                    LocalDataTable.Add(rd2[0].ToString());

                }

            }

            cn.Close();
        }

        private void compEditCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compShowInfobtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select compName,compAdd,compPhone1,compPhone2,compEmail,compid from comp where compName='" + compNameShowInfotxt.Text + "' or compId='" + compIDShowInfotxt.Text + "'", cn);
                this.Size = new Size(589, 520);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                z = dr["compid"].ToString();
                compEditNametxt.Text = dr["compName"].ToString();
                compEditAddtxt.Text = dr["compAdd"].ToString();
                compEditPhone1txt.Text = dr["compPhone1"].ToString();
                compEditPhone2txt.Text = dr["compPhone2"].ToString();
                compEditEmailtxt.Text = dr["compEmail"].ToString();
                dr.Close();

                da = new SqlDataAdapter("select delId,delName from del where compId=" + z + "", cn);
                da.Fill(dt);
                compDelcombox.DataSource = dt;
                compDelcombox.DisplayMember = "delName";
                compDelcombox.ValueMember = "delId";

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelRegFrm delRegFrm = new DelRegFrm();
            delRegFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delIdVar = Convert.ToInt32(compDelcombox.SelectedValue);
            DelEditFrm delEditFrm = new DelEditFrm(delIdVar);
            delEditFrm.Show();
        }

        private void compEditPhone2btn_Click(object sender, EventArgs e)
        {


        }

        private void compDelcombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compInfoUpdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("update comp set compName='" + compEditNametxt.Text + "',compAdd='" + compEditAddtxt.Text + "',compPhone1='" + compEditPhone1txt.Text + "',compPhone2='" + compEditPhone2txt.Text + "',compEmail='" + compEditEmailtxt.Text + "' where compid=" + z + "", cn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Company information updated successfully");
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

        private void compInfoDeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("delete from company where compId='" + compIDShowInfotxt.Text + "' or compName='" + compNameShowInfotxt.Text + "' ", cn);
                MessageBox.Show("Company deleted from system successfully");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("delete from del where delid='" + compDelcombox.SelectedValue + "' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delegate deleted from system successfully");

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

        private void compNameShowInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*  if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }*/
        }

        private void compIDShowInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void compEditNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void compEditAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ' ')
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

        private void compEditEmailtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('@') > -1)
            {
                e.Handled = true;
            }
        }

        private void compEditTextValidating(object sender, CancelEventArgs e)
        {
            validateShowInfobtn();
            validateDeletebtn();
        }

        private void compEditTextChanged(object sender, EventArgs e)
        {
            validateShowInfobtn();
            validateDeletebtn();
        }

        private void compInfoUpdateValidating(object sender, CancelEventArgs e)
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

        private void compInfoUpdateTextChanged(object sender, EventArgs e)
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
    }
}
