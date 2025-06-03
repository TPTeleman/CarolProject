namespace formatiic.Screens
{
    partial class Principal
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
            this.label3 = new System.Windows.Forms.Label();
            this.icone = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.SoldierPanel = new RoundedFlowLayoutPanel();
            this.AddSoldier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.icone)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelDireita.SuspendLayout();
            this.SoldierPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "Formattic";
            // 
            // icone
            // 
            this.icone.BackColor = System.Drawing.Color.Transparent;
            this.icone.Image = global::formatiic.Properties.Resources.ico;
            this.icone.Location = new System.Drawing.Point(0, 0);
            this.icone.Name = "icone";
            this.icone.Size = new System.Drawing.Size(65, 57);
            this.icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icone.TabIndex = 12;
            this.icone.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.icone);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 51);
            this.panel3.TabIndex = 13;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDireita.Controls.Add(this.SoldierPanel);
            this.panelDireita.Controls.Add(this.AddSoldier);
            this.panelDireita.Controls.Add(this.panel1);
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDireita.Location = new System.Drawing.Point(0, 51);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(1240, 558);
            this.panelDireita.TabIndex = 14;
            this.panelDireita.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDireita_Paint);
            // 
            // SoldierPanel
            // 
            this.SoldierPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoldierPanel.AutoScroll = true;
            this.SoldierPanel.AutoSize = true;
            this.SoldierPanel.BackColor = System.Drawing.Color.White;
            this.SoldierPanel.BorderRadius = 20;
            this.SoldierPanel.Controls.Add(this.vScrollBar1);
            this.SoldierPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SoldierPanel.Location = new System.Drawing.Point(327, 114);
            this.SoldierPanel.Name = "SoldierPanel";
            this.SoldierPanel.Size = new System.Drawing.Size(824, 362);
            this.SoldierPanel.TabIndex = 16;
            this.SoldierPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SoldierPanel_Paint);
            // 
            // AddSoldier
            // 
            this.AddSoldier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddSoldier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddSoldier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSoldier.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSoldier.ForeColor = System.Drawing.Color.White;
            this.AddSoldier.Location = new System.Drawing.Point(632, 67);
            this.AddSoldier.Name = "AddSoldier";
            this.AddSoldier.Size = new System.Drawing.Size(188, 39);
            this.AddSoldier.TabIndex = 7;
            this.AddSoldier.Text = "Adicionar Soldado";
            this.AddSoldier.UseVisualStyleBackColor = false;
            this.AddSoldier.Click += new System.EventHandler(this.AddSoldier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 558);
            this.panel1.TabIndex = 15;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 362);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 609);
            this.Controls.Add(this.panelDireita);
            this.Controls.Add(this.panel3);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icone)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDireita.ResumeLayout(false);
            this.panelDireita.PerformLayout();
            this.SoldierPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox icone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.Panel panel1;
        private RoundedFlowLayoutPanel SoldierPanel;
        private System.Windows.Forms.Button AddSoldier;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}