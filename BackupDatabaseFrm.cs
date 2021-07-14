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
    public partial class BackupDatabaseFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        public BackupDatabaseFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brwoseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                backuptxt.Text = dig.SelectedPath;
                backupBtn.Enabled = true;
            }
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string database = cn.Database.ToString();
                if (backuptxt.Text == string.Empty)
                {
                    MessageBox.Show("Please select backup file");
                }
                else
                {
                    cn.Open();
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + backuptxt.Text + "\\" + "Database" + "." + DateTime.Now.ToString("yyyy-MM-dd-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, cn))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Database backup done successfully");
                        this.Close();
                    }
                }
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
