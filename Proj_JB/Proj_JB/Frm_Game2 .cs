using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Proj_JB
{
    public partial class Frm_Game2 : Form
    {

        #region Variaveis Globais
        IList<string> fases;
        int FraseAtualIndex;
        IList<string> palavras;
        int tableDificult;
        string fraseAtual;
        string selectedWord = "";
        int finished_words;
        List<List<Button>> table = new List<List<Button>>();
        List<List<ButtonInformation>> buttonsInfo = new List<List<ButtonInformation>>();
        private Stopwatch stopwatch;

        private class ButtonInformation
        {
            public int xPosition { get; set; }
            public int yPosition { get; set; }
            public bool selected { get; set; }
            public char value { get; set; }
            public bool isResponse { get; set; }
            public string originsWord { get; set; }
        }

        private class PalavrasInseridas
        {
            public string palavra { get; set; }
            public List<int> positionsX { get; set; }
            public List<int> positionsY { get; set; }
            public int orientation { get; set; }
        }
        #endregion

        public Frm_Game2(IList<string> importFases, int dificult)
        {
            InitializeComponent();
            fases = importFases;
            tableDificult = dificult;
            generate_new_phrase();
            Fim_Jogo();
        }

        #region Load
        private void Frm_Game2_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }
        #endregion

        #region Buttons Logic

        private void Select_button(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] arrayPosition = btn.Name.Split(':');

            int positionX = Int32.Parse(arrayPosition[0]);
            int positionY = Int32.Parse(arrayPosition[1]);

            bool isResponse = buttonsInfo[positionX][positionY].isResponse;

            buttonsInfo[positionX][positionY].selected = true;

            if (isResponse)
            {
                string[] originsWord = buttonsInfo[positionX][positionY].originsWord.Split(':');
                List<string> filteredWords = originsWord.Where(word => word != "").ToList();

                if (selectedWord == "")
                {
                    selectedWord = buttonsInfo[positionX][positionY].originsWord;
                    onOkSelect(positionX, positionY);
                }
                else
                {
                    if (filteredWords.Contains(selectedWord.Split(':').Where(word => word != "").ToList()[0]))
                    {
                        onOkSelect(positionX, positionY);
                    }
                    else
                    {
                        table[positionX][positionY].Image = Proj_JB.Properties.Resources.ErrorSelect;
                        onErrorSelect(positionX, positionY);
                    }
                }
            }
            else
            {
                table[positionX][positionY].Image = Proj_JB.Properties.Resources.ErrorSelect;
                onErrorSelect(positionX, positionY);
            }

        }

        private void onErrorSelect(int positionX, int positionY)
        {

            selectedWord = "";

            for (int c = 0; c < tableDificult; c++)
            {
                for (int i = 0; i < tableDificult; i++)
                {
                    if (buttonsInfo[c][i].selected == true)
                    {
                        buttonsInfo[c][i].selected = false;
                        table[c][i].Image = Proj_JB.Properties.Resources.Bg_Txts;
                    }
                }
            }
        }

        private void onOkSelect(int positionX, int positionY)
        {

            string[] originsWord = buttonsInfo[positionX][positionY].originsWord.Split(':');
            List<string> filteredWords = originsWord.Where(word => word != "").ToList();

            bool isSameWord = false;

            foreach (string word in selectedWord.Split(':').Where(word => word != ""))
            {
                if (filteredWords.Contains(word))
                {
                    isSameWord = true;
                }
            }

            int selected = 0;

            List<string> wordSelectedList = selectedWord.Split(':').Where(word => word != "").ToList();

            if (wordSelectedList.Count == 0) return;

            string wordSelected = wordSelectedList[0];

            if (isSameWord)
            {
                table[positionX][positionY].Image = Proj_JB.Properties.Resources.OKSelect;

                for (int c = 0; c < tableDificult; c++)
                {
                    for (int i = 0; i < tableDificult; i++)
                    {
                        if (buttonsInfo[c][i].selected && buttonsInfo[c][i].originsWord != "" && buttonsInfo[c][i].originsWord.Split(':').Where(word => word != "").ToArray()[0] == wordSelected)
                        {
                            selected++;
                        }
                    }
                }
            }

            if (wordSelected.Length == selected)
            {

                bool hasRemovedString = false;

                for (int c = 0; c < tableDificult; c++)
                {
                    for (int i = 0; i < tableDificult; i++)
                    {
                        if (buttonsInfo[c][i].selected && buttonsInfo[c][i].isResponse && buttonsInfo[c][i].originsWord != "")
                        {
                            if (buttonsInfo[c][i].originsWord.Split(':').Where(word => word != "").ToArray()[0] == wordSelected)
                            {

                                string origin = buttonsInfo[c][i].originsWord;

                                List<string> removedString = origin.Split(':').Where(word => word != "").Skip(1).ToList();
                                buttonsInfo[c][i].originsWord = String.Join(":", removedString.ToArray());
                                selectedWord = "";
                                hasRemovedString = true;
                                buttonsInfo[c][i].selected = false;
                            }
                        }
                    }
                }

                if (hasRemovedString)
                {
                    finished_words++;
                    Lbl_Cont.Text = finished_words.ToString();
                }

            }
        }
        #endregion

        #region Generate Phrases
        private void generate_new_phrase()
        {

            FraseAtualIndex = new Random().Next(0, fases.Count);
            fraseAtual = fases[FraseAtualIndex];
            palavras = fraseAtual
                                .Replace(",", "")
                                .Replace("\"", "")
                                .Replace("'", "")
                                .Replace(".", "")
                                .Replace(":", "")
                                .Replace(";", "")
                                .Replace("-", " ")
                                .ToUpper()
                                .Split(' ')
                                .Where(palavra => palavra.Length > 4 && palavra.Length < tableDificult)
                                .Distinct()
                                .OrderBy(x => new Random().Next())
                                .ToArray();

            string[] sortedStrings = palavras.ToArray();
            //Array.Sort(sortedStrings, (x, y) => y.Length.CompareTo(x.Length));

            palavras = sortedStrings.Length > 10 ? sortedStrings.ToList().GetRange(0, 10) : sortedStrings.ToList();

            Lbl_Total.Text = "/ " + palavras.Count.ToString();
            Lbl_Texto.Text = fraseAtual;


            Generate_Table();
            Render_Phrases();
            Generate_Random();


        }
        #endregion

        #region Generate Random
        private void Generate_Random()
        {
            for (int c = 0; c < tableDificult; c++)
            {
                for (int i = 0; i < tableDificult; i++)
                {
                    if (buttonsInfo[c][i].value != ' ') continue;


                    buttonsInfo[c][i].xPosition = c;
                    buttonsInfo[c][i].yPosition = i;
                    buttonsInfo[c][i].isResponse = false;

                    buttonsInfo[c][i].value = (char)new Random().Next('A', 'Z');
                    table[c][i].Text = buttonsInfo[c][i].value.ToString();
                    Thread.Sleep(20);
                }
            }

        }
        #endregion

        #region Render_Phrases
        private void Render_Phrases()
        {
            List<PalavrasInseridas> palavrasInseridas = new List<PalavrasInseridas>();
            int attempts = 0;

            for (int c = 0; c < palavras.Count; c++)
            {
                int xPositionToLocate = new Random().Next(0, tableDificult - palavras[c].Length);
                int yPositionToLocate;

                Thread.Sleep(10);
                int orientation = new Random().Next(0, 11);
                Thread.Sleep(10);

                if (orientation < 5)
                {
                    yPositionToLocate = new Random().Next(0, tableDificult);
                    Thread.Sleep(10);
                }
                else
                {
                    yPositionToLocate = new Random().Next(0, tableDificult - palavras[c].Length);
                    Thread.Sleep(10);
                    xPositionToLocate = new Random().Next(0, tableDificult);
                    Thread.Sleep(10);
                }

                if (palavrasInseridas.Count > 0)
                {
                    int conflicts;
                    do
                    {
                        conflicts = Locate_conficts(palavrasInseridas, palavras[c], xPositionToLocate, yPositionToLocate, orientation);
                        System.Diagnostics.Debug.WriteLine("Palavra: " + palavras[c] + "\n Conflitos: " + conflicts);
                        if (conflicts != 0)
                        {
                            if (orientation < 5)
                            {
                                yPositionToLocate = new Random().Next(0, tableDificult);
                                Thread.Sleep(10);
                            }
                            else
                            {
                                yPositionToLocate = new Random().Next(0, tableDificult - palavras[c].Length);
                                Thread.Sleep(10);
                                xPositionToLocate = new Random().Next(0, tableDificult);
                                Thread.Sleep(10);
                            }
                            attempts++;
                        }

                        //System.Diagnostics.Debug.WriteLine("Tentativa: " + attempts.ToString());
                        if (attempts > 10)
                        {
                            Clear_Table();
                            Render_Phrases();
                            return;
                        }
                    } while (conflicts != 0);

                }

                PalavrasInseridas palavraInserida = new PalavrasInseridas();
                List<int> positionXToInsert = new List<int>();
                List<int> positionYToInsert = new List<int>();

                char[] arrayLetters = palavras[c].ToCharArray();

                for (int j = 0; j < arrayLetters.Length; j++)
                {
                    if (orientation < 5)
                    {
                        buttonsInfo[xPositionToLocate + j][yPositionToLocate].value = arrayLetters[j];
                        buttonsInfo[xPositionToLocate + j][yPositionToLocate].xPosition = xPositionToLocate + j;
                        buttonsInfo[xPositionToLocate + j][yPositionToLocate].yPosition = yPositionToLocate;
                        buttonsInfo[xPositionToLocate + j][yPositionToLocate].isResponse = true;
                        buttonsInfo[xPositionToLocate + j][yPositionToLocate].originsWord += palavras[c] + ":";

                        table[xPositionToLocate + j][yPositionToLocate].Text = arrayLetters[j].ToString();

                        positionXToInsert.Add(xPositionToLocate + j);
                        positionYToInsert.Add(yPositionToLocate);
                    }
                    else
                    {
                        buttonsInfo[xPositionToLocate][yPositionToLocate + j].value = arrayLetters[j];
                        buttonsInfo[xPositionToLocate][yPositionToLocate + j].xPosition = xPositionToLocate;
                        buttonsInfo[xPositionToLocate][yPositionToLocate + j].yPosition = yPositionToLocate + j;
                        buttonsInfo[xPositionToLocate][yPositionToLocate + j].isResponse = true;
                        buttonsInfo[xPositionToLocate][yPositionToLocate + j].originsWord += palavras[c] + ":";

                        table[xPositionToLocate][yPositionToLocate + j].Text = arrayLetters[j].ToString();

                        positionXToInsert.Add(xPositionToLocate);
                        positionYToInsert.Add(yPositionToLocate + j);
                    }
                }


                palavraInserida.palavra = palavras[c];
                palavraInserida.orientation = orientation;
                palavraInserida.positionsX = positionXToInsert;
                palavraInserida.positionsY = positionYToInsert;
                System.Diagnostics.Debug.WriteLine("Inserida: " + palavraInserida.palavra + "\n");
                palavrasInseridas.Add(palavraInserida);
            }
        }
        #endregion

        #region ClearTable
        private void Clear_Table()
        {
            for (int c = 0; c < tableDificult; c++)
            {
                for (int i = 0; i < tableDificult; i++)
                {
                    table[c][i].Text = "";
                    table[c][i].Click -= (sender, EventArgs) => { Select_button(sender, EventArgs); };
                    buttonsInfo[c][i].value = ' ';
                    buttonsInfo[c][i].xPosition = 0;
                    buttonsInfo[c][i].yPosition = 0;
                    buttonsInfo[c][i].isResponse = false;
                    buttonsInfo[c][i].originsWord = "";
                }
            }

        }
        #endregion

        #region Locate_conficts

        private int Locate_conficts(List<PalavrasInseridas> listaAtual, string wordToValidation, int wordPositionX, int wordPositionY, int orientation)
        {

            int conflicts = 0;

            for (int c = 0; c < listaAtual.Count; c++)
            {

                // Informações das Palavras Ja Inseridas
                List<Char> actualLettersArray = listaAtual[c].palavra.ToCharArray().ToList();
                List<int> actualLettersPositionsX = listaAtual[c].positionsX;
                List<int> actualLettersPositionsY = listaAtual[c].positionsY;
                int initialActualWordPositionX = listaAtual[c].positionsX[0];
                int initialActualWordPositionY = listaAtual[c].positionsY[0];
                int finalActualWordPositionX = listaAtual[c].positionsX.Last();
                int finalActualWordPositionY = listaAtual[c].positionsY.Last();
                int actualOrientationWord = listaAtual[c].orientation;

                // Informações da Palavra a Ser Analisada
                List<Char> validateLetters = wordToValidation.ToCharArray().ToList();
                List<int> positionsXToValidate = new List<int>();
                List<int> positionsYToValidate = new List<int>();


                for (int p = 0; p < validateLetters.Count; p++)
                {
                    if (orientation < 5)
                    {
                        positionsXToValidate.Add(wordPositionX + p);
                        positionsYToValidate.Add(wordPositionY);
                    }
                    else
                    {
                        positionsXToValidate.Add(wordPositionX);
                        positionsYToValidate.Add(wordPositionY + p);
                    }
                }

                bool hasSameInitialPosition = initialActualWordPositionX == wordPositionX && initialActualWordPositionY == wordPositionY;
                bool hasSameFinalPosition =
                        finalActualWordPositionX == (orientation < 5 ? positionsXToValidate.Last() : wordPositionX)
                        &&
                        finalActualWordPositionY == (orientation > 5 ? positionsYToValidate.Last() : wordPositionY);

                bool hasSamePositionInitialFinal =
                        initialActualWordPositionX == (orientation < 5 ? positionsXToValidate.Last() : wordPositionX)
                        &&
                        initialActualWordPositionY == (orientation > 5 ? positionsYToValidate.Last() : wordPositionY);

                if (hasSameInitialPosition || hasSameFinalPosition || hasSamePositionInitialFinal) conflicts++;

                bool hasSameOrientation = (listaAtual[c].orientation < 5 && orientation < 5) || (listaAtual[c].orientation > 5 && orientation > 5);

                if (hasSameOrientation)
                {
                    if ((actualOrientationWord < 5 && orientation < 5) && (wordPositionX == initialActualWordPositionX)) conflicts++;
                    if ((actualOrientationWord > 5 && orientation > 5) && (wordPositionY == initialActualWordPositionY)) conflicts++;
                }

                for (int l = 0; l < actualLettersArray.Count; l++)
                {
                    char actualLetter = actualLettersArray[l];
                    int actualPositionX = actualLettersPositionsX[l];
                    int actualPositionY = actualLettersPositionsY[l];


                    for (int lv = 0; lv < validateLetters.Count; lv++)
                    {
                        char letterToValidate = validateLetters[lv];
                        int positionXToValidate = positionsXToValidate[lv];
                        int positionYToValidate = positionsYToValidate[lv];

                        if ((actualPositionX == positionXToValidate) && (actualPositionY == positionYToValidate))
                        {
                            if (!(actualLetter == letterToValidate)) conflicts++;
                        }
                    }
                }

            }

            return conflicts;
        }

        #endregion

        #region Generate Table
        private void Generate_Table()
        {
            int width = (Pnl_CP.Width / tableDificult) - 2;
            int height = (Pnl_CP.Height / tableDificult) - 1;

            int yMargin = 1;
            Font font = new Font("Arial", height / 3);

            for (int c = 0; c < tableDificult; c++)
            {
                int lineHeight = height;

                List<Button> row = new List<Button>();
                List<ButtonInformation> rowInfo = new List<ButtonInformation>();

                for (int i = 0; i < tableDificult; i++)
                {
                    ButtonInformation buttonInfo = new ButtonInformation();
                    buttonInfo.xPosition = i;
                    buttonInfo.yPosition = c;
                    buttonInfo.selected = false;
                    buttonInfo.value = ' ';
                    buttonInfo.isResponse = false;

                    rowInfo.Add(buttonInfo);

                    #region Button Config
                    Button button = new Button();
                    button.Name = c.ToString() + ":" + i.ToString();
                    button.Width = width;
                    button.Height = height;
                    button.Image = Proj_JB.Properties.Resources.Bg_Txts;
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.Transparent;
                    button.UseVisualStyleBackColor = false;
                    button.Font = font;
                    button.Click += new EventHandler(Select_button);

                    button.Location = new Point(1 + ((width + 2) * i), yMargin);

                    row.Add(button);
                    #endregion

                }

                table.Add(row);
                buttonsInfo.Add(rowInfo);
                yMargin = yMargin + lineHeight + 1;
            }

            for (int c = 0; c < tableDificult; c++)
            {
                for (int i = 0; i < tableDificult; i++)
                {
                    Pnl_CP.Controls.Add(table[c][i]);
                }
            }
        }
        #endregion

        #region Botão Sair
        private void Frm_Game2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Variaveis.Verif2 == true)
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

        #region Botão Novo Jogo
        private void Btn_Nv_Jg_Click(object sender, EventArgs e)
        {
            Frm_Home.ActiveForm.Activate();
            Variaveis.Verif2 = true;
            this.Close();
        }
        #endregion

        #region Fim do Jogo
        private void Fim_Jogo()
        {
            
            if (finished_words == palavras.Count)
            {
                string[] rk = new string[2];
                rk[0] = Variaveis.Nome;
                rk[1] = Lbl_Tmr.Text;
                stopwatch.Stop();

                ListViewItem l = new ListViewItem(rk);
                Lv_Ranking.Items.Add(l);
            }
        }
        #endregion

        #region Cronometro
        private void Tmr_Cont2_Tick(object sender, EventArgs e)
        {
            Lbl_Tmr.Text = $"{stopwatch.Elapsed:mm\\:ss}";
        }
        #endregion

    }
}
