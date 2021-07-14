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
    public partial class DebtEditFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        double payment = 0.0;
        double pending = 0.0;
        public DebtEditFrm()
        {
            InitializeComponent();
            this.debtShowInfobtn.Enabled = false;
            this.debtInfoUpdatebtn.Enabled = false;
            this.debtInfoDeletebtn.Enabled = false;
        }

        private void vaidateShowInfobtn()
        {
            this.debtShowInfobtn.Enabled = ((debtNameShowInfotxt.Text.Length != 0) || (debtIDShowInfotxt.Text.Length != 0));
        }
        private void vaidateDeletebtn()
        {
            this.debtInfoDeletebtn.Enabled = ((debtNameShowInfotxt.Text.Length != 0) || (debtIDShowInfotxt.Text.Length != 0));
        }
        private void vaildateDebtUpdatebtn()
        {
            this.debtInfoUpdatebtn.Enabled = ((debtEditNametxt.Text.Length != 0) && (debtEditAddtxt.Text.Length != 0) && (debtEditPhone1txt.Text.Length != 0) && (debtEditIDcardtxt.Text.Length != 0) && (debtEditMaxDebttxt.Text.Length != 0));
        }
        private void debtEditCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DebtEditFrm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(553, 150);
            try //Auto complete atemption for company names
            {
                cmd = new SqlCommand("SELECT debtName FROM debt", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                debtNameShowInfotxt.AutoCompleteCustomSource = MyCollection;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
                dr.Close();
            }
        }

        private void debtShowInfobtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select debtName,debtAdd,debtPhone1,debtPhone2,debtSSN,maxDebt,debtPay from debt where debtName='" + debtNameShowInfotxt.Text + "' or debtId='" + debtIDShowInfotxt.Text + "'", cn);
                this.Size = new Size(553, 430);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                debtEditNametxt.Text = dr["debtName"].ToString();
                debtEditAddtxt.Text = dr["debtAdd"].ToString();
                debtEditPhone1txt.Text = dr["debtPhone1"].ToString();
                debtEditPhone2txt.Text = dr["debtPhone2"].ToString();
                debtEditIDcardtxt.Text = dr["debtSSN"].ToString();
                debtEditMaxDebttxt.Text = dr["maxDebt"].ToString();
                payment = Convert.ToDouble(dr["debtPay"].ToString());
               
            }
            catch 
            {
                this.Size = new Size(553, 116);
                MessageBox.Show("Invalid debtor ID or name", "Incomplete info");
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void debtInfoUpdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                double newMaxDebt = Convert.ToDouble(debtEditMaxDebttxt.Text);
                pending = newMaxDebt - payment;
                cn.Open();
                cmd = new SqlCommand("update debt set debtName='" + debtEditNametxt.Text + "',debtAdd='" + debtEditAddtxt.Text + "',debtPhone1='" + debtEditPhone1txt.Text + "',debtPhone2='" + debtEditPhone2txt.Text + "',debtSSN='" + debtEditIDcardtxt.Text + "',maxDebt='" + debtEditMaxDebttxt.Text + "',debtPend=" + pending + "", cn);
                MessageBox.Show("Debtor information updated successfully");
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

        private void debtInfoDeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("delete from debt where debtId='" + debtIDShowInfotxt.Text + "' or debtName='" + debtNameShowInfotxt + "' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Debtor deleted from system successfully");

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

        private void debtNameShowInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void debtIDShowInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void debtEditNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void debtEditAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void debtPhonesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && (sender as TextBox).Text.IndexOf('+') > -1)
            {
                e.Handled = true;
            }
        }

        private void debtEditIDcardtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void debtShowInfoValidating(object sender, CancelEventArgs e)
        {
            
        }

        private void debtShowInfoTextChanged(object sender, EventArgs e)
        {

        }

        private void debtUpdateValidating(object sender, CancelEventArgs e)
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
            vaildateDebtUpdatebtn();

        }

        private void debtUpdateTextChanged(object sender, EventArgs e)
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
            vaildateDebtUpdatebtn();
        }

        private void showInfoBtnValidation(object sender, EventArgs e)
        {
            vaidateShowInfobtn();
            vaidateDeletebtn();
        }
    }
}
