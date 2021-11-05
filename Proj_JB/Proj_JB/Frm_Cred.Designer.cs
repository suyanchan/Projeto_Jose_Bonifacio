
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
            this.Lbl_Cred.Location = new System.Drawing.Point(212, 65);
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
            this.label1.Location = new System.Drawing.Point(148, 171);
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
            this.label2.Location = new System.Drawing.Point(700, 171);
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
            this.label3.Location = new System.Drawing.Point(846, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Referências";
            // 
            // Frm_Cred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proj_JB.Properties.Resources.Bg;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tmr_Cred;
        private System.Windows.Forms.Label Lbl_Cred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}