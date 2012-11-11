namespace Oiko
{
    partial class Form2_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Login));
            this.label_Login_Text1 = new System.Windows.Forms.Label();
            this.label_Login_Text2 = new System.Windows.Forms.Label();
            this.button_Login_Entrar = new System.Windows.Forms.Button();
            this.button_Login_Cancelar = new System.Windows.Forms.Button();
            this.timer_Login = new System.Windows.Forms.Timer(this.components);
            this.label_Login_Usuario = new System.Windows.Forms.Label();
            this.textBox_Login_Usuario = new System.Windows.Forms.TextBox();
            this.label_Login_Senha = new System.Windows.Forms.Label();
            this.textBox_Login_Senha = new System.Windows.Forms.TextBox();
            this.pictureBox_Sobre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobre)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Login_Text1
            // 
            this.label_Login_Text1.AutoSize = true;
            this.label_Login_Text1.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Text1.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Text1.Location = new System.Drawing.Point(6, 26);
            this.label_Login_Text1.Name = "label_Login_Text1";
            this.label_Login_Text1.Size = new System.Drawing.Size(168, 40);
            this.label_Login_Text1.TabIndex = 1;
            this.label_Login_Text1.Text = "Oiko 1.0";
            // 
            // label_Login_Text2
            // 
            this.label_Login_Text2.AutoSize = true;
            this.label_Login_Text2.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Text2.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Text2.Location = new System.Drawing.Point(12, 58);
            this.label_Login_Text2.Name = "label_Login_Text2";
            this.label_Login_Text2.Size = new System.Drawing.Size(215, 18);
            this.label_Login_Text2.TabIndex = 2;
            this.label_Login_Text2.Text = "Gerenciador Financeiro Pessoal";
            // 
            // button_Login_Entrar
            // 
            this.button_Login_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Entrar.Location = new System.Drawing.Point(15, 259);
            this.button_Login_Entrar.Name = "button_Login_Entrar";
            this.button_Login_Entrar.Size = new System.Drawing.Size(70, 23);
            this.button_Login_Entrar.TabIndex = 7;
            this.button_Login_Entrar.Text = "Entrar";
            this.button_Login_Entrar.UseVisualStyleBackColor = true;
            this.button_Login_Entrar.Click += new System.EventHandler(this.button_Login_Entrar_Click);
            // 
            // button_Login_Cancelar
            // 
            this.button_Login_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Cancelar.Location = new System.Drawing.Point(101, 259);
            this.button_Login_Cancelar.Name = "button_Login_Cancelar";
            this.button_Login_Cancelar.Size = new System.Drawing.Size(70, 23);
            this.button_Login_Cancelar.TabIndex = 8;
            this.button_Login_Cancelar.Text = "Cancelar";
            this.button_Login_Cancelar.UseVisualStyleBackColor = true;
            this.button_Login_Cancelar.Click += new System.EventHandler(this.button_Login_Cancelar_Click);
            // 
            // timer_Login
            // 
            this.timer_Login.Enabled = true;
            this.timer_Login.Interval = 1500;
            // 
            // label_Login_Usuario
            // 
            this.label_Login_Usuario.AutoSize = true;
            this.label_Login_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_Login_Usuario.Location = new System.Drawing.Point(13, 143);
            this.label_Login_Usuario.Name = "label_Login_Usuario";
            this.label_Login_Usuario.Size = new System.Drawing.Size(58, 16);
            this.label_Login_Usuario.TabIndex = 3;
            this.label_Login_Usuario.Text = "Usuário:";
            // 
            // textBox_Login_Usuario
            // 
            this.textBox_Login_Usuario.Location = new System.Drawing.Point(14, 160);
            this.textBox_Login_Usuario.Name = "textBox_Login_Usuario";
            this.textBox_Login_Usuario.Size = new System.Drawing.Size(196, 20);
            this.textBox_Login_Usuario.TabIndex = 4;
            // 
            // label_Login_Senha
            // 
            this.label_Login_Senha.AutoSize = true;
            this.label_Login_Senha.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_Login_Senha.Location = new System.Drawing.Point(14, 202);
            this.label_Login_Senha.Name = "label_Login_Senha";
            this.label_Login_Senha.Size = new System.Drawing.Size(50, 16);
            this.label_Login_Senha.TabIndex = 5;
            this.label_Login_Senha.Text = "Senha:";
            // 
            // textBox_Login_Senha
            // 
            this.textBox_Login_Senha.Location = new System.Drawing.Point(15, 219);
            this.textBox_Login_Senha.Name = "textBox_Login_Senha";
            this.textBox_Login_Senha.Size = new System.Drawing.Size(196, 20);
            this.textBox_Login_Senha.TabIndex = 6;
            this.textBox_Login_Senha.UseSystemPasswordChar = true;
            this.textBox_Login_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Login_Senha_KeyPress);
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
            this.pictureBox_Sobre.TabIndex = 26;
            this.pictureBox_Sobre.TabStop = false;
            // 
            // Form2_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 307);
            this.Controls.Add(this.pictureBox_Sobre);
            this.Controls.Add(this.label_Login_Text2);
            this.Controls.Add(this.button_Login_Cancelar);
            this.Controls.Add(this.button_Login_Entrar);
            this.Controls.Add(this.textBox_Login_Senha);
            this.Controls.Add(this.label_Login_Senha);
            this.Controls.Add(this.textBox_Login_Usuario);
            this.Controls.Add(this.label_Login_Usuario);
            this.Controls.Add(this.label_Login_Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login_Text1;
        private System.Windows.Forms.Label label_Login_Text2;
        private System.Windows.Forms.Button button_Login_Entrar;
        private System.Windows.Forms.Button button_Login_Cancelar;
        private System.Windows.Forms.Timer timer_Login;
        private System.Windows.Forms.Label label_Login_Usuario;
        private System.Windows.Forms.TextBox textBox_Login_Usuario;
        private System.Windows.Forms.Label label_Login_Senha;
        private System.Windows.Forms.TextBox textBox_Login_Senha;
        private System.Windows.Forms.PictureBox pictureBox_Sobre;
    }
}