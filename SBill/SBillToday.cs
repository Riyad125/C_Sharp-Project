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

namespace Phamacy_Management_System.SBill
{
    public partial class SBillToday : Form
    {
        public SBillToday()
        {
            InitializeComponent();
        }

        private void SBillToday_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");


            SqlDataAdapter da9 = new SqlDataAdapter("SELECT sBilldet.sBillNo, sBill.sBillDate, sBill.sBillKind, sBill.empName, sBill.ttlCost, sBillDet.itmBar, sBillDet.itmUnit, sBillDet.itmPrice, sBillDet.quant,sBillDet.ttlPrice FROM  sBill INNER JOIN sBillDet ON sBillDet.sBillNo =  sBill.sBillNo ", cn);



            DataSet ds9 = new DataSet();
            da9.Fill(ds9, "sBill,sBilldet");

            SBill.SBillTodayRep obj = new SBill.SBillTodayRep();
            obj.SetDataSource(ds9.Tables["sBill,sBilldet"]);

            crystalReportViewer1.ReportSource = obj;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
