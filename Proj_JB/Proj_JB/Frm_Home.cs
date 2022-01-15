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
using Newtonsoft.Json;


namespace Proj_JB
{
    
    public partial class Frm_Home : Form
    {
        #region Variáveis Globais
        string gameDificult = "";
        public string jsonObject = Directory.GetCurrentDirectory();
        public IList<string> GlobalFases;
        int dificult;
        Thread md_frm;
        #endregion

        public Frm_Home()
        {
            InitializeComponent();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            Variaveis.Verif = false;
            
            
        }

        #region Classes e Leituras de Arquivo
        class Fases
        {
            public Bonifacio bonifacio { get; set; }
            public Independencia independencia { get; set; }
        }

        public class Bonifacio {
            public IList<string> facil { get; set; }
            public IList<string> medio { get; set; }
            public IList<string> dificil { get; set; }
        }

        public class Independencia
        {
            public IList<string> facil { get; set; }
            public IList<string> medio { get; set; }
            public IList<string> dificil { get; set; }
        }

        private void Read_file()
        {
            StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + "\\frases.json");
            string jsonString = r.ReadToEnd();
            Fases fases = JsonConvert.DeserializeObject<Fases>(jsonString);


            if (gameDificult == "Facil" && Rbt_JB.Checked == true)
            {
                GlobalFases = fases.bonifacio.facil;
                dificult = 15;
            }
            if (gameDificult == "Medio" && Rbt_JB.Checked == true)
            {
                GlobalFases = fases.bonifacio.medio;
                dificult = 20;
            }
            if (gameDificult == "Dificil" && Rbt_JB.Checked == true)
            {
                GlobalFases = fases.bonifacio.dificil;
                dificult = 25;
            }


            if (gameDificult == "Facil" && Rbt_I.Checked == true)
            {
                GlobalFases = fases.independencia.facil;
                dificult = 15;
            }
            if (gameDificult == "Medio" && Rbt_I.Checked == true)
            {
                GlobalFases = fases.independencia.medio;
                dificult = 20;
            }
            if (gameDificult == "Dificil" && Rbt_I.Checked == true)
            {
                GlobalFases = fases.independencia.dificil;
                dificult = 25;
            }
        }
        #endregion

        #region Buttons
        private void Btn_F_Click(object sender, EventArgs e)
        {
            gameDificult = "Facil";
            Esc_Frm();
        }

        private void Btn_M_Click(object sender, EventArgs e)
        {
            gameDificult = "Medio";
            Esc_Frm();
        }

        private void Btn_D_Click(object sender, EventArgs e)
        {
            gameDificult = "Dificil";
            Esc_Frm();
        }
        #endregion

        #region Navigate
        void Esc_Frm()
        {
            Read_file();

            Txt_Nm_Jog.Text = Variaveis.Nome;
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
            Application.Run(new Frm_Game2(GlobalFases, dificult));
        }


        private void Nv_frm1()
        {
            Application.Run(new Frm_Game1(GlobalFases, dificult));
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
