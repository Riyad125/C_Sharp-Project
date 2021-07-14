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
    public partial class CashRcptFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlDataReader dr2;
        double payment = 0.0;
        double pending = 0.0;
        DataTable dt = new DataTable();
        string debtName = "";
        public CashRcptFrm()
        {
            InitializeComponent();
            this.rcptSavebtn.Enabled = false;
        }
        void cashRcptSaveBtnValidate()
        {
            rcptSavebtn.Enabled = ((rcptDebtNametxt.Text.Trim() != "") && (rcptPaytxt.Text.Trim() != "") && (rcptPendtxt.Text.Trim() != "") && (rcptMaxDebttxt.Text.Trim() != "") && (rcptDebtorPaymenttxt.Text.Trim() != ""));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CashRcptFrm_Load(object sender, EventArgs e)
        {
            rcptDatelbl.Text = DateTime.Now.ToString();
            try
            {
                cmd = new SqlCommand("select max(rcptId)+1 as rcptId from rcpt", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                recptNolbl.Text = dr["rcptId"].ToString();



                dr.Close();
                cn.Close();

                /// auto complete item name ///
                cmd = new SqlCommand("SELECT debtName FROM debt", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                rcptDebtNametxt.AutoCompleteCustomSource = MyCollection;
                dr.Close();
                /// auto complete code ends here ///

                cmd2 = new SqlCommand("select emp.empId,empName from emp inner join empLogin on emp.empId=empLogin.empId", cn);
                dr2 = cmd2.ExecuteReader();
                dr2.Read();
                rcptEmpNametxt.Text = dr2["empName"].ToString();
                rcptEmpIdtxt.Text = dr2["empId"].ToString();
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

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //debtName = rcptDebtNametxt.Text;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select debtId,debtPay,debtPend,maxDebt,debtPay,debtPend from debt where debtName='" + rcptDebtNametxt.Text + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                rcptDebtIdtxt.Text = dr["debtId"].ToString();
                rcptPaytxt.Text = dr["debtPay"].ToString();
                rcptPendtxt.Text = dr["debtPend"].ToString();
                rcptMaxDebttxt.Text = dr["maxDebt"].ToString();
                payment = Convert.ToDouble(dr["debtPay"].ToString());
                pending = Convert.ToDouble(dr["debtPend"].ToString());

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

        private void rcptCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtnValidating(object sender, EventArgs e)
        {
            cashRcptSaveBtnValidate();
        }

        private void rcptSavebtn_Click(object sender, EventArgs e)
        {
            try
            {

                double debtorPayment = Convert.ToDouble(rcptDebtorPaymenttxt.Text);
                payment -= debtorPayment;
                pending = Convert.ToDouble(rcptMaxDebttxt.Text) - payment;
                cn.Open();
                cmd = new SqlCommand("SET IDENTITY_INSERT rcpt on insert into rcpt (rcptId,rcptDate,empId,empName,debtId,debtName,debtorPayment) values('" + recptNolbl.Text + "','" + rcptDatelbl.Text + "','" + rcptEmpIdtxt.Text + "','" + rcptEmpNametxt.Text + "','" + rcptDebtIdtxt.Text + "','" + rcptDebtNametxt.Text + "','" + rcptDebtorPaymenttxt.Text + "') ", cn);
                cmd.ExecuteNonQuery();
                cmd2 = new SqlCommand("update debt set debtPay=" + payment + ",debtPend=" + pending + "", cn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Cash receipt saved successfully");
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
    }
}
