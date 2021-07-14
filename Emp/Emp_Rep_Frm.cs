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
    public partial class Emp_Rep_Frm : Form
    {
        public Emp_Rep_Frm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Emp_Rep_Frm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
            SqlDataAdapter da9 = new SqlDataAdapter("SELECT empid, empname, empadd, empPhone1,empperm,empemail FROM emp", cn);
            DataSet ds9 = new DataSet();
            da9.Fill(ds9, "emp");

            Emp.Emp_Rep obj = new Emp.Emp_Rep();
            obj.SetDataSource(ds9.Tables["emp"]);

            crystalReportViewer1.ReportSource = obj;

            //crystalReportViewer1.ReportSource = new Emp_Rep_Frm();




            //SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");
            //SqlDataAdapter da9 = new SqlDataAdapter("SELECT empid, empname, empadd, empPhone1,empperm FROM emp", cn);
            //DataSet ds9 = new DataSet();
            //da9.Fill(ds9, "emp");

            //Emp_Rep obj = new Emp_Rep();
            //obj.SetDataSource(ds9.Tables["emp"]);

            //crystalReportViewer1.ReportSource = obj;
        }
    }
}
