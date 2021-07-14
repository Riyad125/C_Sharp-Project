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
    public partial class EditItemFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;



        SqlDataAdapter da;
        SqlDataAdapter da2;
      
        SqlDataReader dr2;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();



        string buyDflt = "";
        string sellDflt = "";
        string z;
        public EditItemFrm()
        {
            InitializeComponent();
            this.itemShowInfobtn.Enabled = false;


            addItemCompcomb.SelectedIndexChanged -= addItemCompcomb_SelectedIndexChanged;
            da = new SqlDataAdapter("select compId,compName from comp", cn);
            da.Fill(dt);
            addItemCompcomb.DataSource = dt;
            addItemCompcomb.DisplayMember = "compName";
            addItemCompcomb.ValueMember = "compId";
            addItemCompcomb.SelectedIndexChanged += addItemCompcomb_SelectedIndexChanged;
           

          
        }

        private void validateShowInfobtn()
        {
            this.itemShowInfobtn.Enabled = ((itemName.Text.Length != 0) || (itemBarcode.Text.Length!=0));
        }
        private void EditItemFrm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(794, 175);
            try //Auto complete atemption for company names
            {
                cmd = new SqlCommand("SELECT itmTrdName FROM item", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                itemName.AutoCompleteCustomSource = MyCollection;
                /// auto complete code ends here ///
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

        private void itemShowInfobtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(850, 650);
                cmd = new SqlCommand("select itmBar, itmTrdName, itmScName, compId, compName, delId, delName, pack, tab, pill, piece, packBP, packSP, tabBP, tabSP, pieceBP, pieceSP, pillBP, pillSP, exdate, packQuant, tabQuant, pieceQuant, pillQuant, buyDflt, selDflt  from item where itmTrdName='" + itemName.Text + "' or itmBar='" + itemBarcode.Text + "'", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                z = dr["itmBar"].ToString();
                addItemBartxt.Text = dr["itmBar"].ToString();
                addItemTrdNametxt.Text = dr["itmTrdName"].ToString();
                addItemScNametxt.Text = dr["itmScName"].ToString();
            //    addItemCompcomb. = dr["compName"].ToString();
              //  addItemCompcomb.Text = dr["compName"].ToString();
            //   addItemCompcomb.SelectedIndex = 1;
           //   addItemDelcomb.Text = dr["delName"].ToString();
              //  addItemCompcomb.Text = dr["compName"].ToString();
        //   addItemDelcomb.Items.Add(dr["delName"].ToString());
                addExDatedtp.Value = Convert.ToDateTime(dr["exdate"].ToString());
                pillnum.Value = Convert.ToInt32(dr["pill"].ToString());
                tabnum.Value = Convert.ToInt32(dr["tab"].ToString());
                packnum.Value = Convert.ToInt32(dr["pack"].ToString());
                piecenum.Value = Convert.ToInt32(dr["piece"].ToString());
                pillBPtxt.Text = dr["pillBP"].ToString();
                tabBPtxt.Text = dr["tabBP"].ToString();
                packBPtxt.Text = dr["packBP"].ToString();
                pieceBPtxt.Text = dr["pieceBP"].ToString();
                pillSPtxt.Text = dr["pillSP"].ToString();
                tabSPtxt.Text = dr["tabSP"].ToString();
                packSPtxt.Text = dr["packSP"].ToString();
                pieceSPtxt.Text = dr["pieceSP"].ToString();
                buyDflt = dr["buyDflt"].ToString();
                sellDflt = dr["selDflt"].ToString();
                packQuanttxt.Text = dr["packQuant"].ToString();
                tabQuanttxt.Text = dr["tabQuant"].ToString();
                pillQuanttxt.Text = dr["pillQuant"].ToString();
                pieceQuanttxt.Text = dr["pieceQuant"].ToString();

                if (buyDflt == "buyDfltPillrdb")
                {
                    buyDfltPillrdb.Checked = true;
                }
                if (buyDflt == "buyDfltTabrdb")
                {
                    buyDfltTabrdb.Checked = true;
                }
                if (buyDflt == "buyDfltPackrdb")
                {
                    buyDfltPackrdb.Checked = true;
                }
                if (buyDflt == "buyDfltPiecerdb")
                {
                    buyDfltPiecerdb.Checked = true;
                }
                if (sellDflt == "sellDfltPillrdb")
                {
                    sellDfltPillrdb.Checked = true;
                }
                if (sellDflt == "sellDfltTabrdb")
                {
                    sellDfltTabrdb.Checked = true;
                }
                if (sellDflt == "sellDfltPackrdb")
                {
                    sellDfltPackrdb.Checked = true;
                }
                if (sellDflt == "sellDfltPiecerdb")
                {
                    sellDfltPiecerdb.Checked = true;
                }






            


            }
            catch 
            {
                MessageBox.Show("Invalid item barcode or name", "Incomplete info");
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
           
        }

      
        private void showInfoValidating(object sender, CancelEventArgs e)
        {
            
        }

        private void itemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=' ')
            {
                e.Handled = true;
            }
        }

        private void itemBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void addItemBartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void addItemTrdNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void addItemScNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void showInfoBtnValidation(object sender, EventArgs e)
        {
            validateShowInfobtn();
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

        private void addItemDelcomb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editItemUpdatebtn_Click(object sender, EventArgs e)
        {
           // cmd = new SqlCommand("update item set  ",cn);
        }

        private void editItemCanclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
