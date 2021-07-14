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
    public partial class DebtViewFrm : Form
    {
        
        public DebtViewFrm()
        {
            InitializeComponent();
           

        }

        private void DebtViewFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.debt' table. You can move, or remove it, as needed.
            this.debtTableAdapter.Fill(this.pharmacyDataSet.debt);
            
        }

        private void debtViewdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void delDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void debtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.debtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }
    }
}
