namespace Oiko
{
    partial class Login
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
            this.label_Login_Text1 = new System.Windows.Forms.Label();
            this.label_Login_Text2 = new System.Windows.Forms.Label();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            this.label_Login_Usuario = new System.Windows.Forms.Label();
            this.textBox_Login_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Login_Senha = new System.Windows.Forms.TextBox();
            this.label_Login_Senha = new System.Windows.Forms.Label();
            this.button_Login_Entrar = new System.Windows.Forms.Button();
            this.button_Login_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Login_Text1
            // 
            this.label_Login_Text1.AutoSize = true;
            this.label_Login_Text1.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Text1.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Text1.Location = new System.Drawing.Point(6, 10);
            this.label_Login_Text1.Name = "label_Login_Text1";
            this.label_Login_Text1.Size = new System.Drawing.Size(168, 40);
            this.label_Login_Text1.TabIndex = 9;
            this.label_Login_Text1.Text = "Oiko 1.0";
            // 
            // label_Login_Text2
            // 
            this.label_Login_Text2.AutoSize = true;
            this.label_Login_Text2.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Text2.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_Text2.Location = new System.Drawing.Point(12, 42);
            this.label_Login_Text2.Name = "label_Login_Text2";
            this.label_Login_Text2.Size = new System.Drawing.Size(239, 19);
            this.label_Login_Text2.TabIndex = 10;
            this.label_Login_Text2.Text = "Gerenciador Financeiro Pessoal";
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Login.Image = global::Oiko.Properties.Resources.MiniLogo___Oiko;
            this.pictureBox_Login.Location = new System.Drawing.Point(242, 1);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(307, 309);
            this.pictureBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Login.TabIndex = 11;
            this.pictureBox_Login.TabStop = false;
            // 
            // label_Login_Usuario
            // 
            this.label_Login_Usuario.AutoSize = true;
            this.label_Login_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_Login_Usuario.Location = new System.Drawing.Point(12, 146);
            this.label_Login_Usuario.Name = "label_Login_Usuario";
            this.label_Login_Usuario.Size = new System.Drawing.Size(58, 16);
            this.label_Login_Usuario.TabIndex = 12;
            this.label_Login_Usuario.Text = "Usuário:";
            // 
            // textBox_Login_Usuario
            // 
            this.textBox_Login_Usuario.Location = new System.Drawing.Point(13, 163);
            this.textBox_Login_Usuario.Name = "textBox_Login_Usuario";
            this.textBox_Login_Usuario.Size = new System.Drawing.Size(196, 20);
            this.textBox_Login_Usuario.TabIndex = 13;
            // 
            // textBox_Login_Senha
            // 
            this.textBox_Login_Senha.Location = new System.Drawing.Point(14, 222);
            this.textBox_Login_Senha.Name = "textBox_Login_Senha";
            this.textBox_Login_Senha.Size = new System.Drawing.Size(196, 20);
            this.textBox_Login_Senha.TabIndex = 15;
            // 
            // label_Login_Senha
            // 
            this.label_Login_Senha.AutoSize = true;
            this.label_Login_Senha.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_Login_Senha.Location = new System.Drawing.Point(13, 205);
            this.label_Login_Senha.Name = "label_Login_Senha";
            this.label_Login_Senha.Size = new System.Drawing.Size(50, 16);
            this.label_Login_Senha.TabIndex = 14;
            this.label_Login_Senha.Text = "Senha:";
            // 
            // button_Login_Entrar
            // 
            this.button_Login_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Entrar.Location = new System.Drawing.Point(15, 259);
            this.button_Login_Entrar.Name = "button_Login_Entrar";
            this.button_Login_Entrar.Size = new System.Drawing.Size(70, 23);
            this.button_Login_Entrar.TabIndex = 16;
            this.button_Login_Entrar.Text = "Entrar";
            this.button_Login_Entrar.UseVisualStyleBackColor = true;
            this.button_Login_Entrar.Click += new System.EventHandler(this.button_Login_Entrar_Click);
            // 
            // button_Login_Cancelar
            // 
            this.button_Login_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login_Cancelar.Location = new System.Drawing.Point(102, 259);
            this.button_Login_Cancelar.Name = "button_Login_Cancelar";
            this.button_Login_Cancelar.Size = new System.Drawing.Size(70, 23);
            this.button_Login_Cancelar.TabIndex = 17;
            this.button_Login_Cancelar.Text = "Cancelar";
            this.button_Login_Cancelar.UseVisualStyleBackColor = true;
            this.button_Login_Cancelar.Click += new System.EventHandler(this.button_Login_Cancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Oiko.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(520, 307);
            this.Controls.Add(this.label_Login_Text2);
            this.Controls.Add(this.button_Login_Cancelar);
            this.Controls.Add(this.button_Login_Entrar);
            this.Controls.Add(this.textBox_Login_Senha);
            this.Controls.Add(this.label_Login_Senha);
            this.Controls.Add(this.textBox_Login_Usuario);
            this.Controls.Add(this.label_Login_Usuario);
            this.Controls.Add(this.pictureBox_Login);
            this.Controls.Add(this.label_Login_Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.Label label_Login_Text1;
        private System.Windows.Forms.Label label_Login_Text2;
        private System.Windows.Forms.Label label_Login_Usuario;
        private System.Windows.Forms.TextBox textBox_Login_Usuario;
        private System.Windows.Forms.TextBox textBox_Login_Senha;
        private System.Windows.Forms.Label label_Login_Senha;
        private System.Windows.Forms.Button button_Login_Entrar;
        private System.Windows.Forms.Button button_Login_Cancelar;
    }
}