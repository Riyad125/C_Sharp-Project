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
    public partial class CompViewFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public CompViewFrm()
        {
            InitializeComponent();
            //da = new SqlDataAdapter("select comp.compId as ID,comp.compName as 'Name',comp.compAdd as 'Address',comp.compPhone1 as 'Phone',comp.compPhone2 as 'Phone 2',comp.compEmail as 'Email',del.delName as 'Delegate' from comp inner join del on comp.compId=del.compId", cn);
            //da.Fill(dt);
            //compViewdgv.DataSource = dt;
        }

        private void CompViewFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.comp' table. You can move, or remove it, as needed.
            this.compTableAdapter.Fill(this.pharmacyDataSet.comp);
            // TODO: This line of code loads data into the 'pharmacyDataSet.comp' table. You can move, or remove it, as needed.
         //   this.compTableAdapter.Fill(this.pharmacyDataSet.comp);
            // TODO: This line of code loads data into the 'pharmacyDataSet.comp' table. You can move, or remove it, as needed.
        //    this.compTableAdapter.Fill(this.pharmacyDataSet.comp);
            // TODO: This line of code loads data into the 'pharmacyDataSet.comp' table. You can move, or remove it, as needed.
         //   this.compTableAdapter.Fill(this.pharmacyDataSet.comp);
          
        }

        private void CompViewFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void compBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           ;

        }

        private void compBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
          

        }

        private void compBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void compDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void compBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.compBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // compDataGridView.DataSource = compBindingSource.SELECT_SEARCH_EMPLOYEES(txtSEARCH.Text);
        }

        private void compDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
