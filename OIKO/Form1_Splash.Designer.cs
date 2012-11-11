namespace Oiko
{
    partial class Form1_Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Splash));
            this.progressBar_Splash = new System.Windows.Forms.ProgressBar();
            this.timer_Splash = new System.Windows.Forms.Timer(this.components);
            this.label_Sobre_Text2 = new System.Windows.Forms.Label();
            this.label_Sobre_Text3 = new System.Windows.Forms.Label();
            this.label_Sobre_Text1 = new System.Windows.Forms.Label();
            this.pictureBox_Sobre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobre)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_Splash
            // 
            this.progressBar_Splash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Splash.Location = new System.Drawing.Point(0, 297);
            this.progressBar_Splash.Name = "progressBar_Splash";
            this.progressBar_Splash.Size = new System.Drawing.Size(520, 10);
            this.progressBar_Splash.TabIndex = 1;
            // 
            // timer_Splash
            // 
            this.timer_Splash.Enabled = true;
            this.timer_Splash.Tick += new System.EventHandler(this.timer_Splash_Tick);
            // 
            // label_Sobre_Text2
            // 
            this.label_Sobre_Text2.AutoSize = true;
            this.label_Sobre_Text2.BackColor = System.Drawing.Color.Transparent;
            this.label_Sobre_Text2.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sobre_Text2.ForeColor = System.Drawing.Color.DimGray;
            this.label_Sobre_Text2.Location = new System.Drawing.Point(1, 246);
            this.label_Sobre_Text2.Name = "label_Sobre_Text2";
            this.label_Sobre_Text2.Size = new System.Drawing.Size(168, 40);
            this.label_Sobre_Text2.TabIndex = 9;
            this.label_Sobre_Text2.Text = "Oiko 1.0";
            // 
            // label_Sobre_Text3
            // 
            this.label_Sobre_Text3.AutoSize = true;
            this.label_Sobre_Text3.BackColor = System.Drawing.Color.Transparent;
            this.label_Sobre_Text3.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sobre_Text3.Location = new System.Drawing.Point(7, 278);
            this.label_Sobre_Text3.Name = "label_Sobre_Text3";
            this.label_Sobre_Text3.Size = new System.Drawing.Size(243, 18);
            this.label_Sobre_Text3.TabIndex = 10;
            this.label_Sobre_Text3.Text = "Seu Gerenciador Financeiro Pessoal";
            // 
            // label_Sobre_Text1
            // 
            this.label_Sobre_Text1.AutoSize = true;
            this.label_Sobre_Text1.BackColor = System.Drawing.Color.Transparent;
            this.label_Sobre_Text1.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sobre_Text1.Location = new System.Drawing.Point(7, 233);
            this.label_Sobre_Text1.Name = "label_Sobre_Text1";
            this.label_Sobre_Text1.Size = new System.Drawing.Size(133, 18);
            this.label_Sobre_Text1.TabIndex = 12;
            this.label_Sobre_Text1.Text = "Seja Bem Vindo ao";
            // 
            // pictureBox_Sobre
            // 
            this.pictureBox_Sobre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Sobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Sobre.Image = global::Oiko.Properties.Resources.MiniLogoOiko;
            this.pictureBox_Sobre.Location = new System.Drawing.Point(242, 1);
            this.pictureBox_Sobre.Name = "pictureBox_Sobre";
            this.pictureBox_Sobre.Size = new System.Drawing.Size(307, 309);
            this.pictureBox_Sobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobre.TabIndex = 13;
            this.pictureBox_Sobre.TabStop = false;
            // 
            // Form1_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 307);
            this.Controls.Add(this.label_Sobre_Text3);
            this.Controls.Add(this.progressBar_Splash);
            this.Controls.Add(this.pictureBox_Sobre);
            this.Controls.Add(this.label_Sobre_Text1);
            this.Controls.Add(this.label_Sobre_Text2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_Splash;
        private System.Windows.Forms.Timer timer_Splash;
        private System.Windows.Forms.Label label_Sobre_Text2;
        private System.Windows.Forms.Label label_Sobre_Text3;
        private System.Windows.Forms.Label label_Sobre_Text1;
        private System.Windows.Forms.PictureBox pictureBox_Sobre;
    }
}