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
        #region Variáveis Globais


        #endregion

        public Frm_Home()
        {
            InitializeComponent();

        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            Variaveis.Verif = false;
            
        }

        #region Botão Fácil
        private void Btn_F_Click(object sender, EventArgs e)
        {
            Esc_Frm();

        }
        #endregion

        #region Botão Médio
        private void Btn_M_Click(object sender, EventArgs e)
        {
            Esc_Frm();
        }
        #endregion

        #region Botão Difícil
        private void Btn_D_Click(object sender, EventArgs e)
        {
            Esc_Frm();
        }

        #endregion

        #region Função Escolher História
        void Esc_Frm()
        {
            
            if (Rbt_JB.Checked == true)
            {
                Frm_Game1 f = new Frm_Game1();
                f.Show();
             }
            else if (Rbt_I.Checked == true)
            {
                Frm_Game2 f = new Frm_Game2();
                f.Show();               

            }
        }
        #endregion

        #region Botão Sair
        private void Frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Variaveis.Verif == true)
            {
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("Deseja Sair?", "Encerrando o Jogo...",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }

                else
                {
                    Frm_Cred f = new Frm_Cred();
                    f.Show();
                    
                    
                }
            }
            
        }


        #endregion


    }
}
