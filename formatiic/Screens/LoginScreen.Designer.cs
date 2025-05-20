namespace formatiic
{
    partial class LoginScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.campoEmailLogin = new System.Windows.Forms.TextBox();
            this.campoSenhaLogin = new System.Windows.Forms.TextBox();
            this.botaoLogin = new System.Windows.Forms.Button();
            this.recuperarSenha = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::formatiic.Properties.Resources.LoginScreen2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1130, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // campoEmailLogin
            // 
            this.campoEmailLogin.Location = new System.Drawing.Point(340, 262);
            this.campoEmailLogin.Multiline = true;
            this.campoEmailLogin.Name = "campoEmailLogin";
            this.campoEmailLogin.Size = new System.Drawing.Size(457, 28);
            this.campoEmailLogin.TabIndex = 2;
            // 
            // campoSenhaLogin
            // 
            this.campoSenhaLogin.Location = new System.Drawing.Point(340, 363);
            this.campoSenhaLogin.Multiline = true;
            this.campoSenhaLogin.Name = "campoSenhaLogin";
            this.campoSenhaLogin.Size = new System.Drawing.Size(457, 28);
            this.campoSenhaLogin.TabIndex = 3;
            // 
            // botaoLogin
            // 
            this.botaoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botaoLogin.ForeColor = System.Drawing.Color.White;
            this.botaoLogin.Location = new System.Drawing.Point(479, 435);
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.Size = new System.Drawing.Size(169, 45);
            this.botaoLogin.TabIndex = 6;
            this.botaoLogin.Text = "LOGAR";
            this.botaoLogin.UseVisualStyleBackColor = false;
            this.botaoLogin.Click += new System.EventHandler(this.botaoLogin_Click);
            // 
            // recuperarSenha
            // 
            this.recuperarSenha.Location = new System.Drawing.Point(547, 592);
            this.recuperarSenha.Name = "recuperarSenha";
            this.recuperarSenha.Size = new System.Drawing.Size(165, 24);
            this.recuperarSenha.TabIndex = 7;
            this.recuperarSenha.Text = "Esqueci minha senha.";
            this.recuperarSenha.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(503, 483);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Não possuo uma conta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 584);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.recuperarSenha);
            this.Controls.Add(this.botaoLogin);
            this.Controls.Add(this.campoSenhaLogin);
            this.Controls.Add(this.campoEmailLogin);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginScreen";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox campoEmailLogin;
        private System.Windows.Forms.TextBox campoSenhaLogin;
        private System.Windows.Forms.Button botaoLogin;
        private System.Windows.Forms.Button recuperarSenha;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}