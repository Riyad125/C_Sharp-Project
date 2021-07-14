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
    public partial class SBillFrm : Form
    {
        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlDataAdapter da;

        SqlDataAdapter da2;
        SqlDataReader dr;
        SqlDataReader dr2;

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        SqlDataAdapter da4;
        SqlDataReader dr4;
        DataTable dt4 = new DataTable();
        SqlDataAdapter da5;
        SqlDataReader dr5;
        DataTable dt5 = new DataTable();

        SqlDataAdapter da6;
        SqlDataReader dr6;
        DataTable dt6 = new DataTable();



        int packet = 0;
        int table = 0;
        int pill = 0;
        int piece = 0;
        double packBP = 0.0;
        double tabBP = 0.0;
        double pillBP = 0.0;
        double pieceBP = 0.0;
        double packQuant = 0.0;
        double tabQuant = 0.0;
        double pillQuant = 0;
        double pieceQuant = 0;

        string sempid;
        string sdebtid;
        string sbillkindd;
        
        public SBillFrm()
        {
            //this.sBillSellbtn.Enabled = false;
            InitializeComponent();
            this.sBillAddItembtn.Enabled = false;
            createDataTable();
            unitItemsAdd();


            da5 = new SqlDataAdapter(" select empname,empid from emp where empid = ( select  min(empid)  from emplogin )", cn);
            da5.Fill(dt5);
            sBillEmpNametxt.Text = dt5.Rows[0]["empname"].ToString();

            sempid = dt5.Rows[0]["empid"].ToString();


            sbillkindd = "cash";


        }
        void clearItemsText()
        {
            sBillItemBartxt.Clear();
            sBillItemNametxt.Clear();
            itemUnitcmbo.SelectedItem = -1;
            itemQuanttxt.Clear();
            itemPricetxt.Clear();
            itemTtlPricetxt.Clear();
        }
        void createDataTable()
        {
            dt.Columns.Add("ITEM BARCODE");
            dt.Columns.Add("ITEM NAME");
            dt.Columns.Add("UNIT");
            dt.Columns.Add("QUANTITY");
            dt.Columns.Add("PRICE");
            dt.Columns.Add("TOTAL PRICE");
            dt.Columns.Add("packQuant");
            dt.Columns.Add("tabQuant");
            dt.Columns.Add("pillQuant");
            dt.Columns.Add("pieceQuant");
            sBilldgv.DataSource = dt;
        }
        void validateAddItembtn()
        {
            this.sBillAddItembtn.Enabled = ((sBillItemBartxt.Text.Length != 0) && (itemQuanttxt.Text.Length != 0) && (itemPricetxt.Text.Length != 0)) || ((sBillItemNametxt.Text.Length != 0) && (itemQuanttxt.Text.Length != 0) && (itemPricetxt.Text.Length != 0));
        }
        void calcTotalPrice()
        {
            itemTtlPricetxt.Text = (Convert.ToInt32(itemQuanttxt.Text) * Convert.ToDouble(itemPricetxt.Text)).ToString();
        }
       

        private void sBillPostrdb_CheckedChanged(object sender, EventArgs e)
        {
            if (sBillPostrdb.Checked == true)
            {
                sbillkindd = "Post Paid";

                label4.Visible = true;
                sBillDebtNamecmbo.Visible = true;
                label8.Visible = true;
                maxDebtlbl.Visible = true;
                label9.Visible = true;
                pendinglbl.Visible = true;


                dt2.Clear();
                da2 = new SqlDataAdapter("select debtid,debtname from debt  ", cn);
                da2.Fill(dt2);
                sBillDebtNamecmbo.DataSource = dt2;
                sBillDebtNamecmbo.DisplayMember = "debtname";

                sBillDebtNamecmbo.ValueMember = "debtid";



                sdebtid = Convert.ToString(sBillDebtNamecmbo.SelectedValue);
             



            }
            else
            {
                label4.Visible = false;
                sBillDebtNamecmbo.Visible = false;
                label8.Visible = false;
                maxDebtlbl.Visible = false;
                label9.Visible = false;
                pendinglbl.Visible = false;
            }
        }
        void unitItemsAdd()
        {


            itemUnitcmbo.Items.Add("Packet");
            itemUnitcmbo.Items.Add("Table");
            itemUnitcmbo.Items.Add("Pill");
            itemUnitcmbo.Items.Add("Piece");
        }
        private void SBillFrm_Load(object sender, EventArgs e)
        {
            try
            {


               
                sBilldgv.Columns["packQuant"].Visible = false;
                sBilldgv.Columns["tabQuant"].Visible = false;
                sBilldgv.Columns["pillQuant"].Visible = false;
               sBilldgv.Columns["pieceQuant"].Visible = false;




                sBillDatelbl.Text = DateTime.Now.ToString();

                cn.Open();
                
                cmd2 = new SqlCommand("SELECT COALESCE(max(sbillno),0) AS sbillno from sbill", cn);

                dr = cmd2.ExecuteReader();
                dr.Read();
                sBillNolbl.Text = Convert.ToString(Convert.ToInt32(dr["sbillno"]) + 1); 
             
                dr.Close();
             





                AutoCompleteStringCollection LocalDataTable = new AutoCompleteStringCollection();

                sBillItemBartxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                sBillItemBartxt.AutoCompleteSource = AutoCompleteSource.CustomSource;

                sBillItemBartxt.AutoCompleteCustomSource = LocalDataTable;


                //cn.Open();
                SqlCommand cmd = new SqlCommand("select itmbar from item", cn);

                SqlDataReader rd2 = cmd.ExecuteReader();

                if (rd2.HasRows == true)
                {

                    while (rd2.Read())
                    {

                        LocalDataTable.Add(rd2[0].ToString());

                    }

                }


                cn.Close();




               // AutoCompleteStringCollection LocalDataTable = new AutoCompleteStringCollection();

                sBillItemNametxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                sBillItemNametxt.AutoCompleteSource = AutoCompleteSource.CustomSource;

                sBillItemNametxt.AutoCompleteCustomSource = LocalDataTable;


                cn.Open();
                SqlCommand cmd3  = new SqlCommand("select itmtrdname from item", cn);

                SqlDataReader rd3 = cmd3.ExecuteReader();

                if (rd3.HasRows == true)
                {

                    while (rd3.Read())
                    {

                        LocalDataTable.Add(rd3[0].ToString());

                    }

                }

                cn.Close();



                







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

        private void sBilldgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sBillItemBartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void sBillItemNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void itemQuanttxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void itemPricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void calcTotalPriceOnTextChanged(object sender, EventArgs e)
        {
            if (itemQuanttxt.Text.Length != 0 && itemPricetxt.Text.Length != 0)
            {
                calcTotalPrice();
            }
            else
            {
                itemTtlPricetxt.Clear();
            }
        }

        private void addItembtnValidating(object sender, CancelEventArgs e)
        {
            validateAddItembtn();
        }

        private void sBillDatelbl_Click(object sender, EventArgs e)
        {

        }

        private void sBillAddItembtn_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select pack,tab,pill,piece from item where itmbar='" + sBillItemBartxt.Text + "'", cn);

            cn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            string pack;
            string tab;
            string pill;
            string piece;



            pack = dr["pack"].ToString();
            tab = dr["tab"].ToString();
            pill = dr["pill"].ToString();
            piece = dr["piece"].ToString();

            dr.Close();
            cn.Close();



            if (itemUnitcmbo.SelectedIndex == 0)
            {


                
                packQuant = (Convert.ToDouble(pack) / Convert.ToDouble(pack)) * Convert.ToInt32(itemQuanttxt.Text);
                tabQuant = (Convert.ToDouble(pack) / Convert.ToDouble(tab)) * Convert.ToInt32(itemQuanttxt.Text);
                pillQuant = (Convert.ToDouble(pack) / Convert.ToDouble(pill)) * Convert.ToInt32(itemQuanttxt.Text);


            }

            else if (itemUnitcmbo.SelectedIndex == 1)
            {


            
                packQuant = (Convert.ToDouble(tab) / Convert.ToDouble(pack)) * Convert.ToInt32(itemQuanttxt.Text);
                tabQuant = (Convert.ToDouble(tab) / Convert.ToDouble(tab)) * Convert.ToInt32(itemQuanttxt.Text);
                pillQuant = (Convert.ToDouble(tab) / Convert.ToDouble(pill)) * Convert.ToInt32(itemQuanttxt.Text);


            }

            else if (itemUnitcmbo.SelectedIndex == 2)
            {



                packQuant = (Convert.ToDouble(pill) / Convert.ToDouble(pack)) * Convert.ToInt32(itemQuanttxt.Text);
                tabQuant = (Convert.ToDouble(pill) / Convert.ToDouble(tab)) * Convert.ToInt32(itemQuanttxt.Text);
                pillQuant = (Convert.ToDouble(pill) / Convert.ToDouble(pill)) * Convert.ToInt32(itemQuanttxt.Text);


            }
            else if (itemUnitcmbo.SelectedIndex == 3)
            {
               

                pieceQuant = (Convert.ToDouble(piece) * Convert.ToInt32(itemQuanttxt.Text));


            }

















            DataRow r = dt.NewRow();
            r[0] = sBillItemBartxt.Text;
            r[1] = sBillItemNametxt.Text;
            r[2] = itemUnitcmbo.SelectedItem;
            r[3] = itemQuanttxt.Text;
            r[4] = itemPricetxt.Text;
            r[5] = itemTtlPricetxt.Text;
            r[6] = packQuant;
            r[7] = tabQuant;
            r[8] = pillQuant;
            r[9] = pieceQuant;

            dt.Rows.Add(r);
            sBilldgv.DataSource = dt;
            clearItemsText();
            sBillTtlCostlbl.Text = (from DataGridViewRow row in sBilldgv.Rows where row.Cells[5].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
        }

        private void sBilldgv_Validating(object sender, CancelEventArgs e)
        {
         //   this.sBillSellbtn.Enabled = sBilldgv.Rows.Count > 1;
        }

        private void sBilldgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemUnitcmbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sBillEmpNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sBillItemBartxt_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void sBillItemNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sBillItemBartxt_Leave(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select itmtrdname from item where itmBar =" + sBillItemBartxt.Text + " ", cn);
            
            dr = cmd.ExecuteReader();
            dr.Read();
            sBillItemNametxt.Text = dr["itmtrdname"].ToString();

            sBillItemNametxt.ReadOnly = true;
            cn.Close();
        
        }

        private void sBillNolbl_Click(object sender, EventArgs e)
        {

        }

        private void sBillSellbtn_Click(object sender, EventArgs e)
        {
            try
            {


            if (sBillCashrdb.Checked == true)
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT sbill oN insert into sBill ( sBillNo, sBillDate, sBillKind, empId, empName, ttlCost) values (" + sBillNolbl.Text + ",' 2016-10-10','" + sbillkindd + "'," + sempid + " ,'" + sBillEmpNametxt.Text + "',"+ sBillTtlCostlbl.Text +")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                

            }



            else

            {

                cn.Open();

                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT sbill oN insert into sBill ( sBillNo, sBillDate, sBillKind, empId, empName, debtId, debtName, ttlCost) values (" + sBillNolbl.Text + ",' 2016-10-10','" + sbillkindd + "'," + sempid + " ,'" + sBillEmpNametxt.Text + "'," + sdebtid + ",'" + sBillDebtNamecmbo.Text + "', " + sBillTtlCostlbl.Text + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }



            cn.Open();

                for (int i = 0; i < sBilldgv.Rows.Count; i++)
                {








                    cmd = new SqlCommand("insert into sbilldet( sBillNo, itmBar, itmUnit, itmPrice, quant, ttlPrice) values ( " + sBillNolbl.Text + ", " + sBilldgv.Rows[i].Cells["Item Barcode"].Value.ToString() + ",'" + sBilldgv.Rows[i].Cells["Unit"].Value.ToString() + "'," + sBilldgv.Rows[i].Cells["Price"].Value.ToString() + "," + sBilldgv.Rows[i].Cells["Quantity"].Value.ToString() + "," + sBilldgv.Rows[i].Cells["Total Price"].Value.ToString() + ")", cn);
                    cmd.ExecuteNonQuery();



                    cmd = new SqlCommand("select  packQuant, tabQuant, pieceQuant, pillQuant from item where itmbar= " + sBilldgv.Rows[i].Cells["Item Barcode"].Value.ToString() + " ", cn);

                    cmd = new SqlCommand("update item set   packQuant= ( packQuant) -   " + sBilldgv.Rows[i].Cells["packQuant"].Value.ToString() + " , tabQuant= ( tabQuant) -  " + sBilldgv.Rows[i].Cells["tabQuant"].Value.ToString() + " , pieceQuant= ( pieceQuant) -   " + sBilldgv.Rows[i].Cells["pieceQuant"].Value.ToString() + ", pillQuant= ( pillQuant) -   " + sBilldgv.Rows[i].Cells["pillQuant"].Value.ToString() + "  where itmbar=" + sBilldgv.Rows[i].Cells["Item Barcode"].Value.ToString() + " ", cn);
                    cmd.ExecuteNonQuery();



                }
                MessageBox.Show("Saved successfully");

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
 

        private void sBillTtlCostlbl_Click(object sender, EventArgs e)
        {

        }

        private void sBillPostrdb_TextChanged(object sender, EventArgs e)
        {

        }

        private void sBillPostrdb_KeyPress(object sender, KeyPressEventArgs e)
        {
            

                
        }

        private void sBillDebtNamecmbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sBillCashrdb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sBillItemNametxt_Leave(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select itmbar from item where itmtrdname = '" + sBillItemNametxt.Text + " ' ", cn);

            dr = cmd.ExecuteReader();
            dr.Read();
            sBillItemBartxt.Text = dr["itmbar"].ToString();
            sBillItemBartxt.ReadOnly = true;
            cn.Close();
        }

        private void sBilldgv_SelectionChanged(object sender, EventArgs e)
        {
            sBillSellbtn.Enabled = sBilldgv.Rows.Count > 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
