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
    public partial class Frm_Game2 : Form
    {
        public Frm_Game2()
        {
            InitializeComponent();
        }

        private void Frm_Game2_Load(object sender, EventArgs e)
        {

        }

        #region Botão Sair
        private void Frm_Game2_FormClosing(object sender, FormClosingEventArgs e)
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
