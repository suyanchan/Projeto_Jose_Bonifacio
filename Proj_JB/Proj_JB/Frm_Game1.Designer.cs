
namespace Proj_JB
{
    partial class Frm_Game1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Game1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Player 1",
            "2:32"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Player 2",
            "3:23"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Player 3",
            "4:56"}, -1);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Texto = new System.Windows.Forms.Label();
            this.Pbx_Logo1 = new System.Windows.Forms.PictureBox();
            this.Pnl_CP = new System.Windows.Forms.Panel();
            this.Pbx_Art3 = new System.Windows.Forms.PictureBox();
            this.Pbx_Rnk = new System.Windows.Forms.PictureBox();
            this.Btn_Nv_Jg = new System.Windows.Forms.Button();
            this.Lbl_Tmr = new System.Windows.Forms.Label();
            this.Lbl_Cont = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Tmr_Cont = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lv_Ranking = new System.Windows.Forms.ListView();
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Art3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Rnk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proj_JB.Properties.Resources.Bg_Txts;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(768, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 409);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Texto
            // 
            this.Lbl_Texto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.Lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Texto.Location = new System.Drawing.Point(790, 115);
            this.Lbl_Texto.Name = "Lbl_Texto";
            this.Lbl_Texto.Size = new System.Drawing.Size(237, 363);
            this.Lbl_Texto.TabIndex = 1;
            // 
            // Pbx_Logo1
            // 
            this.Pbx_Logo1.BackColor = System.Drawing.Color.White;
            this.Pbx_Logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Logo1.Image = global::Proj_JB.Properties.Resources.logo;
            this.Pbx_Logo1.InitialImage = null;
            this.Pbx_Logo1.Location = new System.Drawing.Point(790, 604);
            this.Pbx_Logo1.Name = "Pbx_Logo1";
            this.Pbx_Logo1.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo1.TabIndex = 8;
            this.Pbx_Logo1.TabStop = false;
            // 
            // Pnl_CP
            // 
            this.Pnl_CP.BackgroundImage = global::Proj_JB.Properties.Resources.Bg_CP;
            this.Pnl_CP.Location = new System.Drawing.Point(22, 17);
            this.Pnl_CP.Name = "Pnl_CP";
            this.Pnl_CP.Size = new System.Drawing.Size(722, 692);
            this.Pnl_CP.TabIndex = 10;
            // 
            // Pbx_Art3
            // 
            this.Pbx_Art3.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Art3.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Art3.Image")));
            this.Pbx_Art3.Location = new System.Drawing.Point(1071, 452);
            this.Pbx_Art3.Name = "Pbx_Art3";
            this.Pbx_Art3.Size = new System.Drawing.Size(257, 257);
            this.Pbx_Art3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Art3.TabIndex = 11;
            this.Pbx_Art3.TabStop = false;
            // 
            // Pbx_Rnk
            // 
            this.Pbx_Rnk.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Rnk.Image = global::Proj_JB.Properties.Resources.Bg_Rank;
            this.Pbx_Rnk.Location = new System.Drawing.Point(1071, 156);
            this.Pbx_Rnk.Name = "Pbx_Rnk";
            this.Pbx_Rnk.Size = new System.Drawing.Size(257, 267);
            this.Pbx_Rnk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Rnk.TabIndex = 12;
            this.Pbx_Rnk.TabStop = false;
            // 
            // Btn_Nv_Jg
            // 
            this.Btn_Nv_Jg.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Nv_Jg.BackgroundImage = global::Proj_JB.Properties.Resources.Btn_Nv_Jg;
            this.Btn_Nv_Jg.FlatAppearance.BorderSize = 0;
            this.Btn_Nv_Jg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Nv_Jg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Nv_Jg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nv_Jg.Location = new System.Drawing.Point(1102, 30);
            this.Btn_Nv_Jg.Name = "Btn_Nv_Jg";
            this.Btn_Nv_Jg.Size = new System.Drawing.Size(205, 83);
            this.Btn_Nv_Jg.TabIndex = 14;
            this.Btn_Nv_Jg.UseVisualStyleBackColor = false;
            this.Btn_Nv_Jg.Click += new System.EventHandler(this.Btn_Nv_Jg_Click);
            // 
            // Lbl_Tmr
            // 
            this.Lbl_Tmr.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tmr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Tmr.Location = new System.Drawing.Point(936, 39);
            this.Lbl_Tmr.Name = "Lbl_Tmr";
            this.Lbl_Tmr.Size = new System.Drawing.Size(96, 34);
            this.Lbl_Tmr.TabIndex = 22;
            this.Lbl_Tmr.Text = "00 : 00";
            // 
            // Lbl_Cont
            // 
            this.Lbl_Cont.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Cont.Location = new System.Drawing.Point(776, 40);
            this.Lbl_Cont.Name = "Lbl_Cont";
            this.Lbl_Cont.Size = new System.Drawing.Size(45, 33);
            this.Lbl_Cont.TabIndex = 23;
            this.Lbl_Cont.Text = "0";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Total.Location = new System.Drawing.Point(809, 40);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(92, 33);
            this.Lbl_Total.TabIndex = 24;
            this.Lbl_Total.Text = "/ 00";
            // 
            // Tmr_Cont
            // 
            this.Tmr_Cont.Enabled = true;
            this.Tmr_Cont.Interval = 1000;
            this.Tmr_Cont.Tick += new System.EventHandler(this.Tmr_Cont_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Proj_JB.Properties.Resources.logobi;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(790, 519);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Proj_JB.Properties.Resources.logofund;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(920, 519);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Proj_JB.Properties.Resources.logostos;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(920, 604);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Palavras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Acertos / Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(921, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tempo percorrido";
            // 
            // Lv_Ranking
            // 
            this.Lv_Ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.Lv_Ranking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lv_Ranking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nome,
            this.col_tmp});
            this.Lv_Ranking.Font = new System.Drawing.Font("Ubuntu Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Ranking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lv_Ranking.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lv_Ranking.HideSelection = false;
            this.Lv_Ranking.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.Lv_Ranking.Location = new System.Drawing.Point(1092, 265);
            this.Lv_Ranking.MultiSelect = false;
            this.Lv_Ranking.Name = "Lv_Ranking";
            this.Lv_Ranking.Size = new System.Drawing.Size(215, 124);
            this.Lv_Ranking.TabIndex = 44;
            this.Lv_Ranking.UseCompatibleStateImageBehavior = false;
            this.Lv_Ranking.View = System.Windows.Forms.View.Details;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 150;
            // 
            // col_tmp
            // 
            this.col_tmp.Text = "Tempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.label4.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label4.Location = new System.Drawing.Point(1145, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ranking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.label5.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label5.Location = new System.Drawing.Point(1134, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Melhores jogadores";
            // 
            // Frm_Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proj_JB.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lv_Ranking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Lbl_Texto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Lbl_Cont);
            this.Controls.Add(this.Btn_Nv_Jg);
            this.Controls.Add(this.Pbx_Rnk);
            this.Controls.Add(this.Pbx_Art3);
            this.Controls.Add(this.Pnl_CP);
            this.Controls.Add(this.Pbx_Logo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Tmr);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Game1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caça Palavras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Game1_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Game1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Art3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Rnk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Texto;
        private System.Windows.Forms.PictureBox Pbx_Logo1;
        private System.Windows.Forms.Panel Pnl_CP;
        private System.Windows.Forms.PictureBox Pbx_Art3;
        private System.Windows.Forms.PictureBox Pbx_Rnk;
        private System.Windows.Forms.Button Btn_Nv_Jg;
        private System.Windows.Forms.Label Lbl_Tmr;
        private System.Windows.Forms.Label Lbl_Cont;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Timer Tmr_Cont;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView Lv_Ranking;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_tmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

