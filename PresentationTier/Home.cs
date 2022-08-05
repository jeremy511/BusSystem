using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class Home : Form
    {
      
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {




        }


        private void btnAdminBus_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            AdminBus Adminbus = new AdminBus();
            Adminbus.Show();
        }

        private void btnAdminDriver_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            AdminDriver AdminDriver = new AdminDriver();
            AdminDriver.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            AdminJourney AdminJourney = new AdminJourney();
            AdminJourney.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            AdminTrip AdminTrip = new AdminTrip();
            AdminTrip.Show();
        }
    }
}
