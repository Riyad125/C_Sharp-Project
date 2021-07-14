using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phamacy_Management_System.Del
{
    public partial class DelViewFrm : Form
    {
        public DelViewFrm()
        {
            InitializeComponent();
        }

        private void delBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          //  this.Validate();
         //   this.delBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.pharmacyDataSet1);

        }

        private void DelViewFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.del' table. You can move, or remove it, as needed.
            this.delTableAdapter.Fill(this.pharmacyDataSet.del);
            // TODO: This line of code loads data into the 'pharmacyDataSet.del' table. You can move, or remove it, as needed.
          //  this.delTableAdapter.Fill(this.pharmacyDataSet.del);
            // TODO: This line of code loads data into the 'pharmacyDataSet1.del' table. You can move, or remove it, as needed.
           // this.delTableAdapter.Fill(this.pharmacyDataSet1.del);

        }

        private void delBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void delBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.delBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }
    }
}
