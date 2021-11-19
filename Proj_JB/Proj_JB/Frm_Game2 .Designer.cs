
namespace Proj_JB
{
    partial class Frm_Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Game2));
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_Tmr = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Nv_Jg = new System.Windows.Forms.Button();
            this.Pbx_Rnk = new System.Windows.Forms.PictureBox();
            this.Pbx_Art4 = new System.Windows.Forms.PictureBox();
            this.Pnl_CP = new System.Windows.Forms.Panel();
            this.Pbx_Logo2 = new System.Windows.Forms.PictureBox();
            this.Pbx_Logo1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Texto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Cont = new System.Windows.Forms.Label();
            this.Tmr_Cont2 = new System.Windows.Forms.Timer(this.components);
            this.Lv_Ranking = new System.Windows.Forms.ListView();
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Rnk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Art4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Total.Location = new System.Drawing.Point(809, 39);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(92, 33);
            this.Lbl_Total.TabIndex = 41;
            this.Lbl_Total.Text = "/ 00";
            // 
            // Lbl_Tmr
            // 
            this.Lbl_Tmr.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tmr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Tmr.Location = new System.Drawing.Point(956, 38);
            this.Lbl_Tmr.Name = "Lbl_Tmr";
            this.Lbl_Tmr.Size = new System.Drawing.Size(96, 34);
            this.Lbl_Tmr.TabIndex = 40;
            this.Lbl_Tmr.Text = "00 : 00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Proj_JB.Properties.Resources.deadline;
            this.pictureBox2.Location = new System.Drawing.Point(918, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
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
            this.Btn_Nv_Jg.TabIndex = 32;
            this.Btn_Nv_Jg.UseVisualStyleBackColor = false;
            this.Btn_Nv_Jg.Click += new System.EventHandler(this.Btn_Nv_Jg_Click);
            // 
            // Pbx_Rnk
            // 
            this.Pbx_Rnk.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Rnk.Image = global::Proj_JB.Properties.Resources.Bg_Rank;
            this.Pbx_Rnk.Location = new System.Drawing.Point(1071, 158);
            this.Pbx_Rnk.Name = "Pbx_Rnk";
            this.Pbx_Rnk.Size = new System.Drawing.Size(257, 267);
            this.Pbx_Rnk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Rnk.TabIndex = 30;
            this.Pbx_Rnk.TabStop = false;
            // 
            // Pbx_Art4
            // 
            this.Pbx_Art4.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Art4.Image = global::Proj_JB.Properties.Resources.Pbx_Art41;
            this.Pbx_Art4.Location = new System.Drawing.Point(1071, 452);
            this.Pbx_Art4.Name = "Pbx_Art4";
            this.Pbx_Art4.Size = new System.Drawing.Size(257, 257);
            this.Pbx_Art4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Art4.TabIndex = 29;
            this.Pbx_Art4.TabStop = false;
            // 
            // Pnl_CP
            // 
            this.Pnl_CP.BackgroundImage = global::Proj_JB.Properties.Resources.Bg_CP;
            this.Pnl_CP.Location = new System.Drawing.Point(22, 17);
            this.Pnl_CP.Name = "Pnl_CP";
            this.Pnl_CP.Size = new System.Drawing.Size(722, 692);
            this.Pnl_CP.TabIndex = 28;
            // 
            // Pbx_Logo2
            // 
            this.Pbx_Logo2.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Logo2.Location = new System.Drawing.Point(924, 604);
            this.Pbx_Logo2.Name = "Pbx_Logo2";
            this.Pbx_Logo2.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo2.TabIndex = 27;
            this.Pbx_Logo2.TabStop = false;
            // 
            // Pbx_Logo1
            // 
            this.Pbx_Logo1.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Logo1.Image = global::Proj_JB.Properties.Resources.logo;
            this.Pbx_Logo1.InitialImage = null;
            this.Pbx_Logo1.Location = new System.Drawing.Point(794, 604);
            this.Pbx_Logo1.Name = "Pbx_Logo1";
            this.Pbx_Logo1.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo1.TabIndex = 26;
            this.Pbx_Logo1.TabStop = false;
            // 
            // Lbl_Texto
            // 
            this.Lbl_Texto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.Lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Texto.Location = new System.Drawing.Point(790, 115);
            this.Lbl_Texto.Name = "Lbl_Texto";
            this.Lbl_Texto.Size = new System.Drawing.Size(237, 451);
            this.Lbl_Texto.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proj_JB.Properties.Resources.Bg_Txts;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(768, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 498);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Cont
            // 
            this.Lbl_Cont.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Cont.Location = new System.Drawing.Point(776, 39);
            this.Lbl_Cont.Name = "Lbl_Cont";
            this.Lbl_Cont.Size = new System.Drawing.Size(45, 33);
            this.Lbl_Cont.TabIndex = 42;
            this.Lbl_Cont.Text = "0";
            // 
            // Tmr_Cont2
            // 
            this.Tmr_Cont2.Enabled = true;
            this.Tmr_Cont2.Interval = 1000;
            this.Tmr_Cont2.Tick += new System.EventHandler(this.Tmr_Cont2_Tick);
            // 
            // Lv_Ranking
            // 
            this.Lv_Ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.Lv_Ranking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lv_Ranking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nome,
            this.col_tmp});
            this.Lv_Ranking.Font = new System.Drawing.Font("Ubuntu Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Ranking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Lv_Ranking.HideSelection = false;
            this.Lv_Ranking.Location = new System.Drawing.Point(1092, 180);
            this.Lv_Ranking.Name = "Lv_Ranking";
            this.Lv_Ranking.Size = new System.Drawing.Size(215, 225);
            this.Lv_Ranking.TabIndex = 43;
            this.Lv_Ranking.UseCompatibleStateImageBehavior = false;
            this.Lv_Ranking.View = System.Windows.Forms.View.List;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            // 
            // col_tmp
            // 
            this.col_tmp.Text = "Tempo";
            // 
            // Frm_Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proj_JB.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Lv_Ranking);
            this.Controls.Add(this.Btn_Nv_Jg);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Lbl_Tmr);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Pbx_Rnk);
            this.Controls.Add(this.Pbx_Art4);
            this.Controls.Add(this.Pnl_CP);
            this.Controls.Add(this.Pbx_Logo2);
            this.Controls.Add(this.Pbx_Logo1);
            this.Controls.Add(this.Lbl_Texto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Cont);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Game2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caça Palavras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Game2_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Game2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Rnk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Art4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label Lbl_Tmr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Nv_Jg;
        private System.Windows.Forms.PictureBox Pbx_Rnk;
        private System.Windows.Forms.PictureBox Pbx_Art4;
        private System.Windows.Forms.Panel Pnl_CP;
        private System.Windows.Forms.PictureBox Pbx_Logo2;
        private System.Windows.Forms.PictureBox Pbx_Logo1;
        private System.Windows.Forms.Label Lbl_Texto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Cont;
        private System.Windows.Forms.Timer Tmr_Cont2;
        private System.Windows.Forms.ListView Lv_Ranking;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_tmp;
    }
}

