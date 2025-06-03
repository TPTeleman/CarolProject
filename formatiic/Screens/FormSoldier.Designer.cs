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
            this.campoNome = new System.Windows.Forms.TextBox();
            this.CampoID = new System.Windows.Forms.TextBox();
            this.CampoFoto = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddSoldier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icone = new System.Windows.Forms.PictureBox();
            this.Adicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CampoFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icone)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // campoNome
            // 
            this.campoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.campoNome.BackColor = System.Drawing.Color.White;
            this.campoNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(12, 71);
            this.campoNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(300, 29);
            this.campoNome.TabIndex = 2;
            this.campoNome.TextChanged += new System.EventHandler(this.campoNome_TextChanged);
            // 
            // CampoID
            // 
            this.CampoID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CampoID.BackColor = System.Drawing.Color.White;
            this.CampoID.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoID.Location = new System.Drawing.Point(12, 131);
            this.CampoID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CampoID.Multiline = true;
            this.CampoID.Name = "CampoID";
            this.CampoID.Size = new System.Drawing.Size(300, 29);
            this.CampoID.TabIndex = 3;
            this.CampoID.TextChanged += new System.EventHandler(this.CampoID_TextChanged);
            // 
            // CampoFoto
            // 
            this.CampoFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CampoFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoFoto.Location = new System.Drawing.Point(347, 54);
            this.CampoFoto.Name = "CampoFoto";
            this.CampoFoto.Size = new System.Drawing.Size(113, 106);
            this.CampoFoto.TabIndex = 4;
            this.CampoFoto.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "dia";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "mes";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(171, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "ano";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.AddSoldier);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.Adicionar);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.CampoFoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 289);
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
            this.AddSoldier.Location = new System.Drawing.Point(166, 240);
            this.AddSoldier.Name = "AddSoldier";
            this.AddSoldier.Size = new System.Drawing.Size(164, 33);
            this.AddSoldier.TabIndex = 9;
            this.AddSoldier.Text = "Adicionar Soldado";
            this.AddSoldier.UseVisualStyleBackColor = false;
            this.AddSoldier.Click += new System.EventHandler(this.AddSoldier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de nascimento:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.icone);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 34);
            this.panel2.TabIndex = 7;
            // 
            // icone
            // 
            this.icone.BackColor = System.Drawing.Color.Transparent;
            this.icone.Image = global::formatiic.Properties.Resources.ico;
            this.icone.Location = new System.Drawing.Point(3, -2);
            this.icone.Name = "icone";
            this.icone.Size = new System.Drawing.Size(40, 40);
            this.icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icone.TabIndex = 14;
            this.icone.TabStop = false;
            // 
            // Adicionar
            // 
            this.Adicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Adicionar.Location = new System.Drawing.Point(356, 166);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(95, 23);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar foto";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSoldier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 289);
            this.Controls.Add(this.CampoID);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.panel1);
            this.Name = "FormSoldier";
            this.Text = "FormSoldier";
            ((System.ComponentModel.ISupportInitialize)(this.CampoFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox CampoID;
        private System.Windows.Forms.PictureBox CampoFoto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddSoldier;
    }
}