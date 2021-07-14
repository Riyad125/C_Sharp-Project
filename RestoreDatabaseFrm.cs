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
    public partial class RestoreDatabaseFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        public RestoreDatabaseFrm()
        {
            InitializeComponent();
            this.restoreBtn.Enabled = false;
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restoretxt.Text = dlg.FileName;
                restoreBtn.Enabled = true;
            }
        }

        private void RestoreDatabaseFrm_Load(object sender, EventArgs e)
        {

        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            string database = cn.Database.ToString();
            try
            {
                cn.Open();
                string sqlres1 = string.Format("USE MASTER ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand command1 = new SqlCommand(sqlres1, cn);
                command1.ExecuteNonQuery();

                string sqlres2 = "RESTORE DATABASE [" + database + "] FROM DISK='" + restoretxt.Text + "' WITH REPLACE";
                SqlCommand command2 = new SqlCommand(sqlres2, cn);
                command2.ExecuteNonQuery();

                string sqlres3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand command3 = new SqlCommand(sqlres3, cn);
                command3.ExecuteNonQuery();


                MessageBox.Show("Database restore done successfully");
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
    }
}
