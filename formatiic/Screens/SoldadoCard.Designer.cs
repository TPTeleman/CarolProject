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
            this.Remover = new System.Windows.Forms.LinkLabel();
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
            this.roundedPanel1.BackColor = System.Drawing.Color.Silver;
            this.roundedPanel1.Controls.Add(this.Data);
            this.roundedPanel1.Controls.Add(this.Atrasado);
            this.roundedPanel1.Controls.Add(this.Ausente);
            this.roundedPanel1.Controls.Add(this.Presente);
            this.roundedPanel1.Controls.Add(this.Remover);
            this.roundedPanel1.Controls.Add(this.Editar);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.Id);
            this.roundedPanel1.Controls.Add(this.Nome);
            this.roundedPanel1.Controls.Add(this.foto);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(700, 68);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Data.Location = new System.Drawing.Point(162, 39);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(65, 13);
            this.Data.TabIndex = 9;
            this.Data.Text = "00/00/0000";
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Atrasado
            // 
            this.Atrasado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Atrasado.AutoSize = true;
            this.Atrasado.Location = new System.Drawing.Point(594, 28);
            this.Atrasado.Name = "Atrasado";
            this.Atrasado.Size = new System.Drawing.Size(14, 13);
            this.Atrasado.TabIndex = 8;
            this.Atrasado.TabStop = true;
            this.Atrasado.UseVisualStyleBackColor = true;
            // 
            // Ausente
            // 
            this.Ausente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ausente.AutoSize = true;
            this.Ausente.Location = new System.Drawing.Point(503, 28);
            this.Ausente.Name = "Ausente";
            this.Ausente.Size = new System.Drawing.Size(14, 13);
            this.Ausente.TabIndex = 7;
            this.Ausente.TabStop = true;
            this.Ausente.UseVisualStyleBackColor = true;
            // 
            // Presente
            // 
            this.Presente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Presente.AutoSize = true;
            this.Presente.Location = new System.Drawing.Point(412, 28);
            this.Presente.Name = "Presente";
            this.Presente.Size = new System.Drawing.Size(14, 13);
            this.Presente.TabIndex = 6;
            this.Presente.TabStop = true;
            this.Presente.UseVisualStyleBackColor = true;
            // 
            // Remover
            // 
            this.Remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Remover.AutoSize = true;
            this.Remover.Location = new System.Drawing.Point(634, 51);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(50, 13);
            this.Remover.TabIndex = 5;
            this.Remover.TabStop = true;
            this.Remover.Text = "Remover";
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.AutoSize = true;
            this.Editar.LinkColor = System.Drawing.Color.Blue;
            this.Editar.Location = new System.Drawing.Point(589, 51);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(34, 13);
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
            this.label2.Location = new System.Drawing.Point(74, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.BackColor = System.Drawing.Color.Transparent;
            this.Id.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Id.Location = new System.Drawing.Point(94, 37);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(52, 23);
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
            this.Nome.Location = new System.Drawing.Point(72, 11);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(178, 34);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome Nome Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // foto
            // 
            this.foto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foto.BackColor = System.Drawing.Color.Black;
            this.foto.Location = new System.Drawing.Point(6, 4);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(60, 60);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // SoldadoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "SoldadoCard";
            this.Size = new System.Drawing.Size(724, 66);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.LinkLabel Remover;
        private System.Windows.Forms.LinkLabel Editar;
        private System.Windows.Forms.Label Data;
    }
}
