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
    public partial class MainFrm : Form
    {

       


        SqlConnection cn = new SqlConnection("server=. ; database=pharmacy ; integrated security=true");

        int deleteById;

        public MainFrm(int id)
        {
            InitializeComponent();
            deleteById = id;
            
            timer1.Start();

        }

        private void employeeRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpRegFrm empRegFrm = new EmpRegFrm();
            empRegFrm.Show();
        }

        private void companyRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompRegFrm compRegFrm = new CompRegFrm();
            compRegFrm.Show();
        }

        private void debtorRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebtRegFrm debtRegFrm = new DebtRegFrm();
            debtRegFrm.Show();
        }

        private void editCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompEditFrm compEditFrm = new CompEditFrm();
            compEditFrm.Show();
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpEditFrm empEditFrm = new EmpEditFrm();
            empEditFrm.Show();
        }

        private void viewEmploiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpViewFrm empViewFrm = new EmpViewFrm();
            empViewFrm.Show();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("delete from empLogin where empId=" + deleteById + "", cn);
                cmd.ExecuteNonQuery();
                Application.Exit();
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

     

        private void MainFrm_Load(object sender, EventArgs e)
        {
            

            cn.Open();
            SqlCommand cmd = new SqlCommand("select empPerm from empLogin", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Employee")
            {
                employeeToolStripMenuItem.Visible = false;
                debtorRegisterationToolStripMenuItem.Visible = false;
                editDebtorToolStripMenuItem.Visible = false;
                cashReceiptToolStripMenuItem.Visible = false;

            }
            else
            {
                employeeToolStripMenuItem.Enabled = true;
                companyToolStripMenuItem.Enabled = true;
                debtorToolStripMenuItem.Enabled = true;
                itemToolStripMenuItem.Enabled = true;
                purchasingToolStripMenuItem.Enabled = true;
            }
        }

        private void viewCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompViewFrm compViewFrm = new CompViewFrm();
            compViewFrm.Show();
        }

        private void viewDebtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebtViewFrm debtViewFrm = new DebtViewFrm();
            debtViewFrm.Show();
        }

        private void viewBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    ViewBillFrm viewBillFrm = new ViewBillFrm();
        //    viewBillFrm.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemFrm addItemFrm = new AddItemFrm();
            addItemFrm.Show();
            ;
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItemFrm editItemFrm = new EditItemFrm();
            editItemFrm.Show();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItemsFrm viewItemsFrm = new ViewItemsFrm();
            viewItemsFrm.Show();
        }

        private void purchaseBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBillFrm pBillFrm = new PBillFrm();
            pBillFrm.Show();
        }

        private void sellingBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBillFrm sBillFrm = new SBillFrm();
            sBillFrm.Show();
        }

        private void cashReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashRcptFrm cashRcptFrm = new CashRcptFrm();
            cashRcptFrm.Show();
        }

        private void returnBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editDebtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebtEditFrm debtEditFrm = new DebtEditFrm();
            debtEditFrm.Show();
        }

        private void companyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comp.CompFrmRep CompFrmRep = new Comp.CompFrmRep();

            CompFrmRep.Show();
            
           

        }

        private void empolyeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_Rep_Frm Emp_Rep_Frm = new Emp_Rep_Frm();

            Emp_Rep_Frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backupDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupDatabaseFrm backupDatabaseFrm = new BackupDatabaseFrm();
            backupDatabaseFrm.Show();
        }

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreDatabaseFrm restoreDatabaseFrm = new RestoreDatabaseFrm();
            restoreDatabaseFrm.Show();
        }

        private void purchaseBillByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBillFrmByDateDay PBillFrmByDateDay = new PBillFrmByDateDay();

            PBillFrmByDateDay.Show();
        }

        private void purchaseBillTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBillFrmToday PBillFrmByDate = new PBillFrmToday();

            PBillFrmByDate.Show();
        }

        private void itemsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemsFrmRep itemsFrmRep1 = new itemsFrmRep();


            itemsFrmRep1.Show();
        }

        private void purchaseBillByDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            PBill.PBillFrmEmpRep PBillFrmEmpRep = new PBill.PBillFrmEmpRep();

        

            PBillFrmEmpRep.Show();
        }

        private void dEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Del.DelFrmRep DelFrmRep = new Del.DelFrmRep();

            DelFrmRep.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sellingBillTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBill.SBillToday SBillToday = new SBill.SBillToday();

            SBillToday.Show();
        }

        private void sellingBillByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBill.SBillByDate SBillByDate = new SBill.SBillByDate();

            SBillByDate.Show();
        }

        private void sellingBillByEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SBill.SBillByEmployee SBillByEmployee = new SBill.SBillByEmployee();

            SBillByEmployee.Show();
        }

        private void emplyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_Rep_Frm Emp_Rep_Frm = new Emp_Rep_Frm();

            Emp_Rep_Frm.Show();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Comp.CompFrmRep CompFrmRep = new Comp.CompFrmRep();

            CompFrmRep.Show();
        }

        private void specificDatePurchasesBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBillFrmByDateDay PBillFrmByDateDay = new PBillFrmByDateDay();

            PBillFrmByDateDay.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void todaySellingBilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBill.SBillToday SBillToday = new SBill.SBillToday();

            SBillToday.Show();
        }

        private void pBillTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBillFrmToday PBillFrmToday = new PBillFrmToday();

            PBillFrmToday.Show();
        }

        private void debtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Del.DelFrmRep DelFrmRep = new Del.DelFrmRep();

            DelFrmRep.Show();
        }

        private void purchasesBillByEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

              PBill.PBillFrmEmpRep PBillFrmEmpRep = new PBill.PBillFrmEmpRep();

              PBillFrmEmpRep.Show();
        }

        private void specificDateSellingBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBill.Form1 Form1 = new SBill.Form1();

            Form1.Show();
        }

        private void sellingBillByEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SBill.SBillByEmployee SBillByEmployee = new SBill.SBillByEmployee();

            SBillByEmployee.Show();
        }

        private void delegateRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DelRegFrm DelRegFrm = new DelRegFrm();

            DelRegFrm.Show();
        }

        private void editDelegateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewDelegateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Del.DelViewFrm DelViewFrm = new Del.DelViewFrm();

            DelViewFrm.Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Pharmacy Management System"
                + "\n"
                + "\n" + " Developed by  TH2 team"
              + "\n"
             + "\n" + "Amgad Abdulmajid Mohammed"
             + "\n" + "Mosaed Ahmed Mosaed"
             + "\n"
              + "\n"  + "Supervisor: Dr: Adel Salam"
              + "\n" + "Supervisor:  Eng: Abeer Balbahaith"
              + "\n"
   
     + "\n You can download a source code of this project at github.com : https://github.com/A3M-ADEN/"

               , "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            T1.Text =  DateTime.Now.ToString("hh:mm:ss tt");
            T2.Text =  DateTime.Now.ToString("yyyy/MM/dd");
            T3.Text =  new System.Globalization.CultureInfo("EG").DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void T2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pharmacy Management System"
              + "\n"
              + "\n" + " "
            + "\n"
           + "\n" + ""
           + "\n" + ""
           + "\n"
            + "\n" + ""
            + "\n" + ""
            + "\n"

   + "\n "

             , "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));
        }

        private void itemsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            itemsFrmRep itemsFrmRep = new itemsFrmRep();

            itemsFrmRep.Show();
        }

        private void T3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
