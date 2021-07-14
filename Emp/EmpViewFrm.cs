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
    public partial class EmpViewFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        SqlCommand cmd;
        SqlDataReader dr10;

        public EmpViewFrm()
        {
            InitializeComponent();
            this.empViewdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            da = new SqlDataAdapter("select empId as ID,empName as 'NAME' ,empAdd as 'ADDRESS',empBdate as 'BIRTH DATE',empPhone1 as 'PHONE',empEmail as 'EMAIL',empSSN as 'SSN' from emp", cn);
            da.Fill(dt);
            empViewdgv.DataSource=dt;
        }

        private void EmpViewFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void EmpViewFrm_Load(object sender, EventArgs e)
        {
        



            try //
            {
                this.txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

                this.empViewdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                empViewcmbo.Items.Add("All Employees");
                empViewcmbo.Items.Add("Mangers");
                empViewcmbo.Items.Add("Employees");
                empViewcmbo.SelectedIndex = empViewcmbo.FindStringExact("All Employees");



                
                cmd = new SqlCommand("SELECT empname FROM emp", cn);
                cn.Open();
                dr10= cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr10.Read())
                {
                    MyCollection.Add(dr10.GetString(0));
                }
                txtSearch.AutoCompleteCustomSource = MyCollection;
                /// auto complete code ends here ///
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
              //  dr10.Close();
            }



        }

        private void empViewdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empViewcmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empViewcmbo.SelectedIndex == 0)
            {
                empViewdgv.DataSource = null;
                empViewdgv.Rows.Clear();
                dt.Clear();
                da = new SqlDataAdapter("select empId as ID,empName as 'Name' ,empAdd as 'Address',empBdate as 'Birth date',empPhone1 as 'Phone',empEmail as 'Email',empSSN as 'SSN' from emp", cn);
                da.Fill(dt);
                empViewdgv.DataSource = dt;
            }
            else if (empViewcmbo.SelectedIndex == 1)
            {
                empViewdgv.DataSource = null;
                empViewdgv.Rows.Clear();
                dt.Clear();
                da = new SqlDataAdapter("select empId as ID,empName as 'Name' ,empAdd as 'Address',empBdate as 'Birth date',empPhone1 as 'Phone',empEmail as 'Email',empSSN as 'SSN' from emp where empPerm='Manager'", cn);
                da.Fill(dt);
                empViewdgv.DataSource = dt;
               
            }
            else if (empViewcmbo.SelectedIndex == 2)
            {
                empViewdgv.DataSource = null;
                empViewdgv.Rows.Clear();
                dt.Clear();
                da = new SqlDataAdapter("select empId as ID,empName as 'Name' ,empAdd as 'Address',empBdate as 'Birth date',empPhone1 as 'Phone',empEmail as 'Email',empSSN as 'SSN' from emp where empPerm='Employee'", cn);
                da.Fill(dt);
                empViewdgv.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //empViewdgv.DataSource = null;
            //empViewdgv.Rows.Clear();
            //dt.Clear();
            //da = new SqlDataAdapter("select empId as ID,empName as 'Name' ,empAdd as 'Address',empBdate as 'Birth date',empPhone1 as 'Phone',empPhone2 as 'Phone 2',empEmail as 'Email',empSSN as 'SSN',empQualf as 'Qualification' from emp where empname= '" + txtSearch.Text + "' ", cn);
            //da.Fill(dt);
            //empViewdgv.DataSource = dt;

            
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            empViewdgv.DataSource = null;
            empViewdgv.Rows.Clear();
            dt.Clear();
            da = new SqlDataAdapter("select empId as ID,empName as 'Name' ,empAdd as 'Address',empBdate as 'Birth date',empPhone1 as 'Phone',empEmail as 'Email',empSSN as 'SSN' from emp where empname= '" + txtSearch.Text + "' ", cn);
            da.Fill(dt);
            empViewdgv.DataSource = dt;
        }

        private void txtSearch_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!txtSearch.AcceptsReturn)
                {
                    Searchbtn.PerformClick();
                }
            }
        }
    }
}
