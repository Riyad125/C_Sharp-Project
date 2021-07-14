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
    public partial class AddItemFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlDataReader dr;
        SqlDataReader dr2;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        string buyDfltVar = "";
        string sellDfltVar = "";
        public AddItemFrm()
        {
            InitializeComponent();
            addItemCompcomb.SelectedIndexChanged -= addItemCompcomb_SelectedIndexChanged;
            da = new SqlDataAdapter("select compId,compName from comp", cn);
            da.Fill(dt);
            addItemCompcomb.DataSource = dt;
            addItemCompcomb.DisplayMember = "compName";
            addItemCompcomb.ValueMember = "compId";
            addItemCompcomb.SelectedIndexChanged += addItemCompcomb_SelectedIndexChanged;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddItemFrm_Load(object sender, EventArgs e)
        {

        }

        private void addItemBartxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemAddbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (buyDfltPillrdb.Checked == true)
                {
                    buyDfltVar = "buyDfltPillrdb";
                }
                 if (buyDfltTabrdb.Checked == true)
                {
                    buyDfltVar = "buyDfltTabrdb";
                }
                 if (buyDfltPackrdb.Checked == true)
                {
                    buyDfltVar = "buyDfltPackrdb";
                }
                 if (buyDfltPiecerdb.Checked == true)
                {
                    buyDfltVar = "buyDfltPiecerdb";
                }
                 if (sellDfltPillrdb.Checked == true)
                {
                    sellDfltVar = "sellDfltPillrdb";
                }
                 if (sellDfltTabrdb.Checked == true)
                {
                    sellDfltVar = "sellDfltTabrdb";
                }
                 if (sellDfltPackrdb.Checked == true)
                {
                    sellDfltVar = "sellDfltPackrdb";
                }
                 if (sellDfltPiecerdb.Checked == true)
                {
                    sellDfltVar = "sellDfltPiecerdb";
                }


                 cn.Open();
                 SqlCommand cmd = new SqlCommand("insert into item(itmBar,itmTrdName,itmScName,exdate,compId,compName,delId,delName,pill,tab,pack,piece,buyDflt,selDflt,packQuant,pillQuant,tabQuant,pieceQuant) values (" + addItemBartxt.Text + ",'" + addItemTrdNametxt.Text + "', '" + addItemScNametxt.Text + "', '" + addExDatedtp.Text + "','" + addItemCompcomb.SelectedValue + "','" + addItemCompcomb.Text + "','" + addItemDelcomb.SelectedValue + "','" + addItemDelcomb.Text + "', '" + pillnum.Value + "','" + tabnum.Value + "','" + packnum.Value + "','" + piecenum.Value + "','" + buyDfltVar + "','" + sellDfltVar + "','" + packQuanttxt.Text + "','" + pillQuanttxt.Text + "','" + tabQuanttxt.Text + "','" + pieceQuanttxt.Text + "')", cn);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Item registered in the pharmacy system successfully");

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

        private void addItemBartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=' ')
            {
                e.Handled = true;
            }
        }

        private void itmNamesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-' && e.KeyChar!=' ')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar!=' ')
            {
                e.Handled = true;
            }
        }

        private void addItemCompcomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                try
            {
                dt2.Clear();
                da2 = new SqlDataAdapter("select delId,delName from del where compId=" + addItemCompcomb.SelectedValue + " ", cn);
                da2.Fill(dt2);
                addItemDelcomb.DataSource = dt2;
                addItemDelcomb.DisplayMember = "delname";
                addItemDelcomb.ValueMember = "delid";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addItemCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
