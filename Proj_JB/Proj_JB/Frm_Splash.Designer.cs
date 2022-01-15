
namespace Proj_JB
{
    partial class Frm_Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_Frase = new System.Windows.Forms.Label();
            this.Pbx_Logo1 = new System.Windows.Forms.PictureBox();
            this.Pbx_Logo2 = new System.Windows.Forms.PictureBox();
            this.Tmr_Spl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Proj_JB.Properties.Resources.JB_Sig;
            this.pictureBox1.Location = new System.Drawing.Point(346, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Proj_JB.Properties.Resources.DP_Sig;
            this.pictureBox2.Location = new System.Drawing.Point(346, 421);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(634, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_Frase
            // 
            this.Lbl_Frase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Frase.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Frase.Font = new System.Drawing.Font("Signika Negative", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Frase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Lbl_Frase.Location = new System.Drawing.Point(114, 87);
            this.Lbl_Frase.Name = "Lbl_Frase";
            this.Lbl_Frase.Size = new System.Drawing.Size(1114, 106);
            this.Lbl_Frase.TabIndex = 2;
            this.Lbl_Frase.Text = resources.GetString("Lbl_Frase.Text");
            this.Lbl_Frase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pbx_Logo1
            // 
            this.Pbx_Logo1.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Logo1.InitialImage = null;
            this.Pbx_Logo1.Location = new System.Drawing.Point(734, 589);
            this.Pbx_Logo1.Name = "Pbx_Logo1";
            this.Pbx_Logo1.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo1.TabIndex = 27;
            this.Pbx_Logo1.TabStop = false;
            // 
            // Pbx_Logo2
            // 
            this.Pbx_Logo2.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Logo2.Image = global::Proj_JB.Properties.Resources.logo;
            this.Pbx_Logo2.Location = new System.Drawing.Point(494, 589);
            this.Pbx_Logo2.Name = "Pbx_Logo2";
            this.Pbx_Logo2.Size = new System.Drawing.Size(103, 105);
            this.Pbx_Logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo2.TabIndex = 28;
            this.Pbx_Logo2.TabStop = false;
            // 
            // Tmr_Spl
            // 
            this.Tmr_Spl.Interval = 5000;
            this.Tmr_Spl.Tick += new System.EventHandler(this.Tmr_Spl_Tick);
            // 
            // Frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proj_JB.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Pbx_Logo2);
            this.Controls.Add(this.Pbx_Logo1);
            this.Controls.Add(this.Lbl_Frase);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caça Palavras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_Frase;
        private System.Windows.Forms.PictureBox Pbx_Logo1;
        private System.Windows.Forms.PictureBox Pbx_Logo2;
        private System.Windows.Forms.Timer Tmr_Spl;
    }
}