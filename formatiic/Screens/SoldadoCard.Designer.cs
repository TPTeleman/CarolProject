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
            this.Data = new System.Windows.Forms.Label();
            this.Atrasado = new System.Windows.Forms.RadioButton();
            this.Ausente = new System.Windows.Forms.RadioButton();
            this.Presente = new System.Windows.Forms.RadioButton();
            this.linkRemover = new System.Windows.Forms.LinkLabel();
            this.Editar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.foto = new RoundedPictureBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.AutoSize = true;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel1.Controls.Add(this.Data);
            this.roundedPanel1.Controls.Add(this.Atrasado);
            this.roundedPanel1.Controls.Add(this.Ausente);
            this.roundedPanel1.Controls.Add(this.Presente);
            this.roundedPanel1.Controls.Add(this.linkRemover);
            this.roundedPanel1.Controls.Add(this.Editar);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.Id);
            this.roundedPanel1.Controls.Add(this.Nome);
            this.roundedPanel1.Controls.Add(this.foto);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1100, 102);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Data.Location = new System.Drawing.Point(243, 60);
            this.Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(89, 20);
            this.Data.TabIndex = 9;
            this.Data.Text = "00/00/0000";
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Atrasado
            // 
            this.Atrasado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Atrasado.AutoSize = true;
            this.Atrasado.Location = new System.Drawing.Point(968, 42);
            this.Atrasado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Atrasado.Name = "Atrasado";
            this.Atrasado.Size = new System.Drawing.Size(21, 20);
            this.Atrasado.TabIndex = 8;
            this.Atrasado.TabStop = true;
            this.Atrasado.UseVisualStyleBackColor = true;
            // 
            // Ausente
            // 
            this.Ausente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ausente.AutoSize = true;
            this.Ausente.Location = new System.Drawing.Point(744, 42);
            this.Ausente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ausente.Name = "Ausente";
            this.Ausente.Size = new System.Drawing.Size(21, 20);
            this.Ausente.TabIndex = 7;
            this.Ausente.TabStop = true;
            this.Ausente.UseVisualStyleBackColor = true;
            // 
            // Presente
            // 
            this.Presente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Presente.AutoSize = true;
            this.Presente.Location = new System.Drawing.Point(523, 42);
            this.Presente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Presente.Name = "Presente";
            this.Presente.Size = new System.Drawing.Size(21, 20);
            this.Presente.TabIndex = 6;
            this.Presente.TabStop = true;
            this.Presente.UseVisualStyleBackColor = true;
            // 
            // linkRemover
            // 
            this.linkRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRemover.AutoSize = true;
            this.linkRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRemover.Location = new System.Drawing.Point(1001, 75);
            this.linkRemover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRemover.Name = "linkRemover";
            this.linkRemover.Size = new System.Drawing.Size(73, 20);
            this.linkRemover.TabIndex = 5;
            this.linkRemover.TabStop = true;
            this.linkRemover.Text = "Remover";
            this.linkRemover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnRemover_LinkClicked);
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.AutoSize = true;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.LinkColor = System.Drawing.Color.Blue;
            this.Editar.Location = new System.Drawing.Point(934, 75);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(51, 20);
            this.Editar.TabIndex = 4;
            this.Editar.TabStop = true;
            this.Editar.Text = "Editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(111, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.BackColor = System.Drawing.Color.Transparent;
            this.Id.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Id.Location = new System.Drawing.Point(141, 57);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(81, 36);
            this.Id.TabIndex = 2;
            this.Id.Text = "123456";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Nome.Location = new System.Drawing.Point(108, 17);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(275, 51);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome Nome Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // foto
            // 
            this.foto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foto.BackColor = System.Drawing.Color.Transparent;
            this.foto.BackgroundImage = global::formatiic.Properties.Resources.user;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.Location = new System.Drawing.Point(9, 5);
            this.foto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(90, 92);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // SoldadoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SoldadoCard";
            this.Size = new System.Drawing.Size(1826, 117);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label Nome;
        private RoundedPictureBox foto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.RadioButton Atrasado;
        private System.Windows.Forms.RadioButton Ausente;
        private System.Windows.Forms.RadioButton Presente;
        private System.Windows.Forms.LinkLabel linkRemover;
        private System.Windows.Forms.LinkLabel Editar;
        private System.Windows.Forms.Label Data;
    }
}
