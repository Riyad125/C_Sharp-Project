using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phamacy_Management_System
{
    public partial class SplashScreenFrm : Form
    {
        public SplashScreenFrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              probar1.Value++;
            if (probar1.Value >= 50)
            {
                timer1.Enabled = false;
                this.Hide();
                LoginFrm LoginFrm = new LoginFrm();
                LoginFrm.Show();

            }
            }

        private void probar1_Click(object sender, EventArgs e)
        {

      
        }

        private void SplashScreenFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
