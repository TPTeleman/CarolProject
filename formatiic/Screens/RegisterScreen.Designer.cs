namespace formatiic
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
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
            this.campoNome.Size = new System.Drawing.Size(456, 31);
            this.campoNome.TabIndex = 1;
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(341, 276);
            this.campoEmail.Multiline = true;
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(456, 30);
            this.campoEmail.TabIndex = 2;
            // 
            // campoTel
            // 
            this.campoTel.Location = new System.Drawing.Point(341, 350);
            this.campoTel.Multiline = true;
            this.campoTel.Name = "campoTel";
            this.campoTel.Size = new System.Drawing.Size(456, 33);
            this.campoTel.TabIndex = 3;
            this.campoTel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(341, 425);
            this.campoSenha.Multiline = true;
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(456, 30);
            this.campoSenha.TabIndex = 4;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botaoCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoCadastrar.ForeColor = System.Drawing.Color.White;
            this.botaoCadastrar.Location = new System.Drawing.Point(476, 470);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(169, 45);
            this.botaoCadastrar.TabIndex = 5;
            this.botaoCadastrar.Text = "CADASTRAR";
            this.botaoCadastrar.UseVisualStyleBackColor = false;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(510, 518);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(103, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ja estou cadastrado";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 584);
            this.Controls.Add(this.linkLabel2);
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
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}