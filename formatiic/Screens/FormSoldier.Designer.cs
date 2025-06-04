namespace formatiic.Screens
{
    partial class FormSoldier
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddSoldier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icone = new System.Windows.Forms.PictureBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.CampoFoto = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTel = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampoFoto)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.campoNome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 650);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddSoldier
            // 
            this.AddSoldier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddSoldier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddSoldier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSoldier.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSoldier.ForeColor = System.Drawing.Color.White;
            this.AddSoldier.Location = new System.Drawing.Point(220, 424);
            this.AddSoldier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSoldier.Name = "AddSoldier";
            this.AddSoldier.Size = new System.Drawing.Size(246, 51);
            this.AddSoldier.TabIndex = 9;
            this.AddSoldier.Text = "Adicionar Soldado";
            this.AddSoldier.UseVisualStyleBackColor = false;
            this.AddSoldier.Click += new System.EventHandler(this.AddSoldier_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.icone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 52);
            this.panel2.TabIndex = 7;
            // 
            // icone
            // 
            this.icone.BackColor = System.Drawing.Color.Transparent;
            this.icone.Image = global::formatiic.Properties.Resources.ico;
            this.icone.Location = new System.Drawing.Point(4, -3);
            this.icone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.icone.Name = "icone";
            this.icone.Size = new System.Drawing.Size(60, 62);
            this.icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icone.TabIndex = 14;
            this.icone.TabStop = false;
            // 
            // Adicionar
            // 
            this.Adicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Adicionar.Location = new System.Drawing.Point(504, 266);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(142, 35);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar foto";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CampoFoto
            // 
            this.CampoFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CampoFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoFoto.Location = new System.Drawing.Point(497, 106);
            this.CampoFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CampoFoto.Name = "CampoFoto";
            this.CampoFoto.Size = new System.Drawing.Size(156, 152);
            this.CampoFoto.TabIndex = 4;
            this.CampoFoto.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.campoEmail);
            this.roundedPanel1.Controls.Add(this.campoSenha);
            this.roundedPanel1.Controls.Add(this.campoTel);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.AddSoldier);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.Adicionar);
            this.roundedPanel1.Controls.Add(this.CampoFoto);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Location = new System.Drawing.Point(85, 127);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(686, 498);
            this.roundedPanel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(143, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 78);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cadastrer soldado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // campoNome
            // 
            this.campoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.campoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campoNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(119, 233);
            this.campoNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(432, 29);
            this.campoNome.TabIndex = 14;
            // 
            // campoEmail
            // 
            this.campoEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.campoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campoEmail.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(34, 168);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.campoEmail.Multiline = true;
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(432, 29);
            this.campoEmail.TabIndex = 15;
            // 
            // campoTel
            // 
            this.campoTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.campoTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campoTel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTel.Location = new System.Drawing.Point(34, 232);
            this.campoTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.campoTel.Multiline = true;
            this.campoTel.Name = "campoTel";
            this.campoTel.Size = new System.Drawing.Size(432, 29);
            this.campoTel.TabIndex = 16;
            this.campoTel.TextChanged += new System.EventHandler(this.campoTel_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.campoSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campoSenha.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.Location = new System.Drawing.Point(34, 299);
            this.campoSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.campoSenha.Multiline = true;
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(432, 29);
            this.campoSenha.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nome:";
            // 
            // FormSoldier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 650);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSoldier";
            this.Text = "FormSoldier";
            this.Load += new System.EventHandler(this.FormSoldier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampoFoto)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox icone;
        private System.Windows.Forms.Button AddSoldier;
        private System.Windows.Forms.PictureBox CampoFoto;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTel;
        private System.Windows.Forms.TextBox campoSenha;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}