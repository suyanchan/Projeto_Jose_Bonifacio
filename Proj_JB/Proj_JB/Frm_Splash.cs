using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_JB
{
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
            Tmr_Spl.Start();
        }



        private void Tmr_Spl_Tick(object sender, EventArgs e)
        {
            Tmr_Spl.Stop();
            Frm_Home f = new Frm_Home();
            f.Show();
            this.Close();
        }
    }
}
