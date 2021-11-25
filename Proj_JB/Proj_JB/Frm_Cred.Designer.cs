
namespace Proj_JB
{
    partial class Frm_Cred
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cred));
            this.Tmr_Cred = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Cred = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Pbx_Logo2 = new System.Windows.Forms.PictureBox();
            this.Pbx_Logo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr_Cred
            // 
            this.Tmr_Cred.Interval = 3000;
            this.Tmr_Cred.Tick += new System.EventHandler(this.Tmr_Cred_Tick);
            // 
            // Lbl_Cred
            // 
            this.Lbl_Cred.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cred.Font = new System.Drawing.Font("Ubuntu Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Cred.Location = new System.Drawing.Point(212, 31);
            this.Lbl_Cred.Name = "Lbl_Cred";
            this.Lbl_Cred.Size = new System.Drawing.Size(222, 69);
            this.Lbl_Cred.TabIndex = 0;
            this.Lbl_Cred.Text = "Créditos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Shanti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(149, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 360);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desenvolvedores: \r\n\r\nAlexsander de Oliveira\r\nRudney Forti Souza\r\nSuyan Rocha Vida" +
    "l\r\n\r\nOrientadores:\r\nDorotea Vilanova Garcia\r\nJoão Inácio da Silva Filho\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Shanti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label2.Location = new System.Drawing.Point(703, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 480);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label3.Location = new System.Drawing.Point(846, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Referências";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Proj_JB.Properties.Resources.logobi;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(441, 642);
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
            this.pictureBox3.Location = new System.Drawing.Point(876, 642);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // Pbx_Logo2
            // 
            this.Pbx_Logo2.BackColor = System.Drawing.Color.White;
            this.Pbx_Logo2.Image = global::Proj_JB.Properties.Resources.logo;
            this.Pbx_Logo2.Location = new System.Drawing.Point(582, 605);
            this.Pbx_Logo2.Name = "Pbx_Logo2";
            this.Pbx_Logo2.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo2.TabIndex = 32;
            this.Pbx_Logo2.TabStop = false;
            // 
            // Pbx_Logo1
            // 
            this.Pbx_Logo1.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Logo1.Image = global::Proj_JB.Properties.Resources.logostos;
            this.Pbx_Logo1.InitialImage = null;
            this.Pbx_Logo1.Location = new System.Drawing.Point(730, 605);
            this.Pbx_Logo1.Name = "Pbx_Logo1";
            this.Pbx_Logo1.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo1.TabIndex = 31;
            this.Pbx_Logo1.TabStop = false;
            // 
            // Frm_Cred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proj_JB.Properties.Resources.Bg;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Pbx_Logo2);
            this.Controls.Add(this.Pbx_Logo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Cred);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cred";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caça Palavras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tmr_Cred;
        private System.Windows.Forms.Label Lbl_Cred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Pbx_Logo2;
        private System.Windows.Forms.PictureBox Pbx_Logo1;
    }
}