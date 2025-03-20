namespace MultApps.Windows
{
    partial class FrmCarteirinha
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pnlCarteirinha = new System.Windows.Forms.Panel();
            this.lblIdadeCarteirinha = new System.Windows.Forms.Label();
            this.lblCPFcarteirinha = new System.Windows.Forms.Label();
            this.lblNomeCarteirinha = new System.Windows.Forms.Label();
            this.picBoxIcone = new System.Windows.Forms.PictureBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.pnlCarteirinha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de Carteirinha de acesso ao parque";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(12, 86);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(178, 25);
            this.lblNomeCompleto.TabIndex = 1;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(12, 146);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(57, 25);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 207);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(227, 25);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data De Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(17, 174);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(173, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(17, 281);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(173, 52);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar Carteirinha";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // pnlCarteirinha
            // 
            this.pnlCarteirinha.Controls.Add(this.lblIdadeCarteirinha);
            this.pnlCarteirinha.Controls.Add(this.lblCPFcarteirinha);
            this.pnlCarteirinha.Controls.Add(this.lblNomeCarteirinha);
            this.pnlCarteirinha.Controls.Add(this.picBoxIcone);
            this.pnlCarteirinha.Location = new System.Drawing.Point(473, 57);
            this.pnlCarteirinha.Name = "pnlCarteirinha";
            this.pnlCarteirinha.Size = new System.Drawing.Size(286, 323);
            this.pnlCarteirinha.TabIndex = 9;
            // 
            // lblIdadeCarteirinha
            // 
            this.lblIdadeCarteirinha.AutoSize = true;
            this.lblIdadeCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeCarteirinha.Location = new System.Drawing.Point(49, 271);
            this.lblIdadeCarteirinha.Name = "lblIdadeCarteirinha";
            this.lblIdadeCarteirinha.Size = new System.Drawing.Size(62, 24);
            this.lblIdadeCarteirinha.TabIndex = 3;
            this.lblIdadeCarteirinha.Text = "Idade";
            // 
            // lblCPFcarteirinha
            // 
            this.lblCPFcarteirinha.AutoSize = true;
            this.lblCPFcarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFcarteirinha.Location = new System.Drawing.Point(48, 224);
            this.lblCPFcarteirinha.Name = "lblCPFcarteirinha";
            this.lblCPFcarteirinha.Size = new System.Drawing.Size(50, 24);
            this.lblCPFcarteirinha.TabIndex = 2;
            this.lblCPFcarteirinha.Text = "CPF";
            // 
            // lblNomeCarteirinha
            // 
            this.lblNomeCarteirinha.AutoSize = true;
            this.lblNomeCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCarteirinha.Location = new System.Drawing.Point(49, 175);
            this.lblNomeCarteirinha.Name = "lblNomeCarteirinha";
            this.lblNomeCarteirinha.Size = new System.Drawing.Size(66, 24);
            this.lblNomeCarteirinha.TabIndex = 1;
            this.lblNomeCarteirinha.Text = "Nome";
            // 
            // picBoxIcone
            // 
            this.picBoxIcone.Location = new System.Drawing.Point(52, 15);
            this.picBoxIcone.Name = "picBoxIcone";
            this.picBoxIcone.Size = new System.Drawing.Size(190, 131);
            this.picBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxIcone.TabIndex = 0;
            this.picBoxIcone.TabStop = false;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(17, 235);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(173, 20);
            this.txtNascimento.TabIndex = 10;
            // 
            // FrmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.pnlCarteirinha);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "FrmCarteirinha";
            this.Text = "FrmCarteirinha";
            this.pnlCarteirinha.ResumeLayout(false);
            this.pnlCarteirinha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Panel pnlCarteirinha;
        private System.Windows.Forms.Label lblCPFcarteirinha;
        private System.Windows.Forms.Label lblNomeCarteirinha;
        private System.Windows.Forms.PictureBox picBoxIcone;
        private System.Windows.Forms.Label lblIdadeCarteirinha;
        private System.Windows.Forms.TextBox txtNascimento;
    }
}