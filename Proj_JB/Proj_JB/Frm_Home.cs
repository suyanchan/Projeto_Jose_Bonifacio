using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Proj_JB
{
    public partial class Frm_Home : Form
    {

        Thread md_frm;

        public Frm_Home()
        {
            InitializeComponent();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void Btn_F_Click(object sender, EventArgs e)
        {
            Esc_Frm();

        }

        void Esc_Frm()
        {
            
            if (Rbt_JB.Checked == true)
            {
                md_frm = new Thread(Nv_frm1);
                md_frm.SetApartmentState(ApartmentState.STA);
                md_frm.Start();
            }
            else if (Rbt_I.Checked == true)
            {
                md_frm = new Thread(Nv_frm2);
                md_frm.SetApartmentState(ApartmentState.STA);
                md_frm.Start();
            }
        }

        private void Nv_frm2()
        {
            Application.Run(new Frm_Game2());
        }

        private void Nv_frm1()
        {
            Application.Run(new Frm_Game1());
        }

        #region Botão Sair
        private void Frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Encerrando o Jogo...",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
                
            
        }
        #endregion
    }
}
