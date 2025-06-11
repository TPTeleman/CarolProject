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
            this.fotoCard = new RoundedPictureBox();
            this.txtDateofbirth = new System.Windows.Forms.Label();
            this.linkRemover = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkEditar = new System.Windows.Forms.LinkLabel();
            this.Presente = new System.Windows.Forms.RadioButton();
            this.linkList = new System.Windows.Forms.LinkLabel();
            this.txtFullname = new System.Windows.Forms.Label();
            this.Ausente = new System.Windows.Forms.RadioButton();
            this.Atrasado = new System.Windows.Forms.RadioButton();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCard)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.txtWarname);
            this.roundedPanel1.Controls.Add(this.fotoCard);
            this.roundedPanel1.Controls.Add(this.txtDateofbirth);
            this.roundedPanel1.Controls.Add(this.linkRemover);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.linkEditar);
            this.roundedPanel1.Controls.Add(this.Presente);
            this.roundedPanel1.Controls.Add(this.linkList);
            this.roundedPanel1.Controls.Add(this.txtFullname);
            this.roundedPanel1.Controls.Add(this.Ausente);
            this.roundedPanel1.Controls.Add(this.Atrasado);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel1.Location = new System.Drawing.Point(14, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1193, 66);
            this.roundedPanel1.TabIndex = 12;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint_1);
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
            // fotoCard
            // 
            this.fotoCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fotoCard.BackColor = System.Drawing.Color.Transparent;
            this.fotoCard.BackgroundImage = global::formatiic.Properties.Resources.user;
            this.fotoCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoCard.Location = new System.Drawing.Point(3, 1);
            this.fotoCard.Name = "fotoCard";
            this.fotoCard.Size = new System.Drawing.Size(60, 60);
            this.fotoCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCard.TabIndex = 0;
            this.fotoCard.TabStop = false;
            this.fotoCard.Click += new System.EventHandler(this.foto_Click);
            // 
            // txtDateofbirth
            // 
            this.txtDateofbirth.AutoSize = true;
            this.txtDateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.txtDateofbirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDateofbirth.Location = new System.Drawing.Point(391, 41);
            this.txtDateofbirth.Name = "txtDateofbirth";
            this.txtDateofbirth.Size = new System.Drawing.Size(65, 13);
            this.txtDateofbirth.TabIndex = 9;
            this.txtDateofbirth.Text = "00/00/0000";
            this.txtDateofbirth.Click += new System.EventHandler(this.Data_Click);
            // 
            // linkRemover
            // 
            this.linkRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkRemover.AutoSize = true;
            this.linkRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRemover.Location = new System.Drawing.Point(619, 42);
            this.linkRemover.Name = "linkRemover";
            this.linkRemover.Size = new System.Drawing.Size(50, 13);
            this.linkRemover.TabIndex = 5;
            this.linkRemover.TabStop = true;
            this.linkRemover.Text = "Remover";
            this.linkRemover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnRemover_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(385, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nascimento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkEditar
            // 
            this.linkEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkEditar.AutoSize = true;
            this.linkEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkEditar.LinkColor = System.Drawing.Color.Blue;
            this.linkEditar.Location = new System.Drawing.Point(577, 42);
            this.linkEditar.Name = "linkEditar";
            this.linkEditar.Size = new System.Drawing.Size(34, 13);
            this.linkEditar.TabIndex = 4;
            this.linkEditar.TabStop = true;
            this.linkEditar.Text = "Editar";
            this.linkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Editar_LinkClicked);
            // 
            // Presente
            // 
            this.Presente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Presente.AutoSize = true;
            this.Presente.Checked = true;
            this.Presente.Location = new System.Drawing.Point(744, 25);
            this.Presente.Name = "Presente";
            this.Presente.Size = new System.Drawing.Size(14, 13);
            this.Presente.TabIndex = 6;
            this.Presente.TabStop = true;
            this.Presente.UseVisualStyleBackColor = true;
            this.Presente.CheckedChanged += new System.EventHandler(this.Presente_CheckedChanged);
            // 
            // linkList
            // 
            this.linkList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkList.AutoSize = true;
            this.linkList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkList.LinkColor = System.Drawing.Color.Blue;
            this.linkList.Location = new System.Drawing.Point(512, 42);
            this.linkList.Name = "linkList";
            this.linkList.Size = new System.Drawing.Size(51, 13);
            this.linkList.TabIndex = 10;
            this.linkList.TabStop = true;
            this.linkList.Text = "Inspeção";
            this.linkList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.Ausente.Location = new System.Drawing.Point(891, 25);
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
            this.Atrasado.Location = new System.Drawing.Point(1040, 25);
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
            ((System.ComponentModel.ISupportInitialize)(this.fotoCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public RoundedPictureBox fotoCard;
        public System.Windows.Forms.Label txtFullname;
        public System.Windows.Forms.Label txtWarname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.LinkLabel linkEditar;
        public System.Windows.Forms.LinkLabel linkRemover;
        public System.Windows.Forms.RadioButton Presente;
        public System.Windows.Forms.RadioButton Ausente;
        public System.Windows.Forms.RadioButton Atrasado;
        public System.Windows.Forms.LinkLabel linkList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txtDateofbirth;
        private RoundedPanel roundedPanel1;
    }
}
