﻿namespace formatiic
{
    partial class RegisterScreen
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
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTel = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.botaoLogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::formatiic.Properties.Resources.RegisterScreen1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1130, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(341, 205);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(351, 31);
            this.campoNome.TabIndex = 1;
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(341, 276);
            this.campoEmail.Multiline = true;
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(351, 30);
            this.campoEmail.TabIndex = 2;
            // 
            // campoTel
            // 
            this.campoTel.Location = new System.Drawing.Point(341, 350);
            this.campoTel.Multiline = true;
            this.campoTel.Name = "campoTel";
            this.campoTel.Size = new System.Drawing.Size(351, 33);
            this.campoTel.TabIndex = 3;
            this.campoTel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(341, 425);
            this.campoSenha.Multiline = true;
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(351, 30);
            this.campoSenha.TabIndex = 4;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(407, 476);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(224, 45);
            this.botaoCadastrar.TabIndex = 5;
            this.botaoCadastrar.Text = "CADASTRAR";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // botaoLogar
            // 
            this.botaoLogar.Location = new System.Drawing.Point(711, 135);
            this.botaoLogar.Name = "botaoLogar";
            this.botaoLogar.Size = new System.Drawing.Size(174, 51);
            this.botaoLogar.TabIndex = 6;
            this.botaoLogar.Text = "JÁ TENHO CONTA";
            this.botaoLogar.UseVisualStyleBackColor = true;
            this.botaoLogar.Click += new System.EventHandler(this.botaoLogar_Click);
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 584);
            this.Controls.Add(this.botaoLogar);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoTel);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegisterScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTel;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Button botaoLogar;
    }
}