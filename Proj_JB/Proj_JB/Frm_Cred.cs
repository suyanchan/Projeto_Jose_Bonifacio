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
    public partial class Frm_Cred : Form
    {
        public Frm_Cred()
        {
            InitializeComponent();
            Tmr_Cred.Start();
        }

        private void Tmr_Cred_Tick(object sender, EventArgs e)
        {
            Tmr_Cred.Stop();
            Variaveis.Verif2 = true;
            Variaveis.Verif = true;
            Application.Exit();
        }


    }
}
