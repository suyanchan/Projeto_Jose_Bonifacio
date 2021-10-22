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

namespace Proj_JB
{
    public partial class Frm_Game1 : Form
    {
        public Frm_Game1()
        {
            InitializeComponent();
        }

        private void Frm_Game_Load(object sender, EventArgs e)
        {

        }

        #region Botão Mudar Dificuldade
        private void Btn_Md_Dif_Click(object sender, EventArgs e)
        {
            Btn_Tip.Visible = false;
            Btn_Conf.Visible = true;
            Btn_Vol.Visible = true;
            Btn_Md_F.Visible = true;
            Btn_Md_M.Visible = true;
            Btn_Md_D.Visible = true;

        }
        #endregion

        #region Botão Voltar
        private void Btn_Vol_Click(object sender, EventArgs e)
        {
            Btn_Tip.Visible = true;
            Btn_Conf.Visible = false;
            Btn_Vol.Visible = false;
            Btn_Md_F.Visible = false;
            Btn_Md_M.Visible = false;
            Btn_Md_D.Visible = false;
        }
        #endregion

        #region Botão Sair
        private void Frm_Game1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Encerrando o Jogo...",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
                
        }

        #endregion

        #region Botão Novo Jogo
        private void Btn_Nv_Jg_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
    }
}
