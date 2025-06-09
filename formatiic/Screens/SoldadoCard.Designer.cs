namespace formatiic.Screens
{
    partial class SoldadoCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWarname = new System.Windows.Forms.Label();
            this.foto = new RoundedPictureBox();
            this.txtDateofbirth = new System.Windows.Forms.Label();
            this.linkRemover = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.LinkLabel();
            this.Presente = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtFullname = new System.Windows.Forms.Label();
            this.Ausente = new System.Windows.Forms.RadioButton();
            this.Atrasado = new System.Windows.Forms.RadioButton();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.txtWarname);
            this.roundedPanel1.Controls.Add(this.foto);
            this.roundedPanel1.Controls.Add(this.txtDateofbirth);
            this.roundedPanel1.Controls.Add(this.linkRemover);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.Editar);
            this.roundedPanel1.Controls.Add(this.Presente);
            this.roundedPanel1.Controls.Add(this.linkLabel1);
            this.roundedPanel1.Controls.Add(this.txtFullname);
            this.roundedPanel1.Controls.Add(this.Ausente);
            this.roundedPanel1.Controls.Add(this.Atrasado);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel1.Location = new System.Drawing.Point(14, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1193, 66);
            this.roundedPanel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(71, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome de guerra:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWarname
            // 
            this.txtWarname.AutoSize = true;
            this.txtWarname.BackColor = System.Drawing.Color.Transparent;
            this.txtWarname.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtWarname.Location = new System.Drawing.Point(178, 38);
            this.txtWarname.Name = "txtWarname";
            this.txtWarname.Size = new System.Drawing.Size(120, 23);
            this.txtWarname.TabIndex = 2;
            this.txtWarname.Text = "Nome nome nome";
            this.txtWarname.Click += new System.EventHandler(this.Id_Click);
            // 
            // foto
            // 
            this.foto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foto.BackColor = System.Drawing.Color.Transparent;
            this.foto.BackgroundImage = global::formatiic.Properties.Resources.user;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.Location = new System.Drawing.Point(3, 1);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(60, 60);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            // 
            // txtDateofbirth
            // 
            this.txtDateofbirth.AutoSize = true;
            this.txtDateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.txtDateofbirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDateofbirth.Location = new System.Drawing.Point(351, 42);
            this.txtDateofbirth.Name = "txtDateofbirth";
            this.txtDateofbirth.Size = new System.Drawing.Size(65, 13);
            this.txtDateofbirth.TabIndex = 9;
            this.txtDateofbirth.Text = "00/00/0000";
            this.txtDateofbirth.Click += new System.EventHandler(this.Data_Click);
            // 
            // linkRemover
            // 
            this.linkRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRemover.AutoSize = true;
            this.linkRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRemover.Location = new System.Drawing.Point(1122, 44);
            this.linkRemover.Name = "linkRemover";
            this.linkRemover.Size = new System.Drawing.Size(50, 13);
            this.linkRemover.TabIndex = 5;
            this.linkRemover.TabStop = true;
            this.linkRemover.Text = "Remover";
            this.linkRemover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnRemover_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(345, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nascimento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.AutoSize = true;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.LinkColor = System.Drawing.Color.Blue;
            this.Editar.Location = new System.Drawing.Point(1080, 44);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(34, 13);
            this.Editar.TabIndex = 4;
            this.Editar.TabStop = true;
            this.Editar.Text = "Editar";
            this.Editar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Editar_LinkClicked);
            // 
            // Presente
            // 
            this.Presente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Presente.AutoSize = true;
            this.Presente.Location = new System.Drawing.Point(575, 25);
            this.Presente.Name = "Presente";
            this.Presente.Size = new System.Drawing.Size(14, 13);
            this.Presente.TabIndex = 6;
            this.Presente.TabStop = true;
            this.Presente.UseVisualStyleBackColor = true;
            this.Presente.CheckedChanged += new System.EventHandler(this.Presente_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(1015, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chekc-List";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtFullname
            // 
            this.txtFullname.AutoSize = true;
            this.txtFullname.BackColor = System.Drawing.Color.Transparent;
            this.txtFullname.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtFullname.Location = new System.Drawing.Point(69, 12);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(178, 34);
            this.txtFullname.TabIndex = 1;
            this.txtFullname.Text = "Nome Nome Nome";
            this.txtFullname.Click += new System.EventHandler(this.Nome_Click);
            // 
            // Ausente
            // 
            this.Ausente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ausente.AutoSize = true;
            this.Ausente.Location = new System.Drawing.Point(722, 25);
            this.Ausente.Name = "Ausente";
            this.Ausente.Size = new System.Drawing.Size(14, 13);
            this.Ausente.TabIndex = 7;
            this.Ausente.TabStop = true;
            this.Ausente.UseVisualStyleBackColor = true;
            this.Ausente.CheckedChanged += new System.EventHandler(this.Ausente_CheckedChanged);
            // 
            // Atrasado
            // 
            this.Atrasado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Atrasado.AutoSize = true;
            this.Atrasado.Location = new System.Drawing.Point(871, 25);
            this.Atrasado.Name = "Atrasado";
            this.Atrasado.Size = new System.Drawing.Size(14, 13);
            this.Atrasado.TabIndex = 8;
            this.Atrasado.TabStop = true;
            this.Atrasado.UseVisualStyleBackColor = true;
            this.Atrasado.CheckedChanged += new System.EventHandler(this.Atrasado_CheckedChanged);
            // 
            // SoldadoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "SoldadoCard";
            this.Size = new System.Drawing.Size(1222, 66);
            this.Load += new System.EventHandler(this.SoldadoCard_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPictureBox foto;
        public System.Windows.Forms.Label txtFullname;
        public System.Windows.Forms.Label txtWarname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Editar;
        private System.Windows.Forms.LinkLabel linkRemover;
        private System.Windows.Forms.RadioButton Presente;
        private System.Windows.Forms.RadioButton Ausente;
        private System.Windows.Forms.RadioButton Atrasado;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txtDateofbirth;
        private RoundedPanel roundedPanel1;
    }
}
