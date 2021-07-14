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
    public partial class LoginFrm : Form
    {

        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        int id = 0;
        SqlDataReader dr;
        public LoginFrm()
        {
            InitializeComponent();
           
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {


        }

        private void LoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult logoutResult = MessageBox.Show("Do you want to logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (logoutResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {

                e.Cancel = false;
            }
        }

        private void empIdtxt_Enter(object sender, EventArgs e)
        {
            empIdtxt.Text = "";
        }

        private void empIdtxt_Leave(object sender, EventArgs e)
        {
            if (empIdtxt.Text.Trim()=="")
            empIdtxt.Text = "User ID";
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            passtxt.Text = "";
            passtxt.PasswordChar = '*';
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text.Trim() == "")
                passtxt.Text = "Password";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {



                id = Convert.ToInt32(empIdtxt.Text);
                cn.Open();
                SqlCommand cmd = new SqlCommand("select empId,empPass from emp where empId='" + empIdtxt.Text + "' and empPass='" + passtxt.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into empLogin (empId,empPerm) select empId,empPerm from emp where empId='" + empIdtxt.Text + "'", cn);
                    cmd2.ExecuteNonQuery();
                    MainFrm mainfrm = new MainFrm(id);
                    mainfrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User ID or password invalid or incorrect", "Invalid ID or password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                MessageBox.Show("Empty User ID or Password", "Employee incomplete info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
            }
            
            
        }
    }
}
