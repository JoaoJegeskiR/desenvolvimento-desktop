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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnGerarCarteirinha = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.panelCarteirinha = new System.Windows.Forms.Panel();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCadastroDePessoaFisica = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.panelCarteirinha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
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
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(17, 114);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(173, 20);
            this.txtNomeCompleto.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(17, 174);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(173, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // btnGerarCarteirinha
            // 
            this.btnGerarCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCarteirinha.Location = new System.Drawing.Point(17, 281);
            this.btnGerarCarteirinha.Name = "btnGerarCarteirinha";
            this.btnGerarCarteirinha.Size = new System.Drawing.Size(173, 52);
            this.btnGerarCarteirinha.TabIndex = 7;
            this.btnGerarCarteirinha.Text = "Gerar Carteirinha";
            this.btnGerarCarteirinha.UseVisualStyleBackColor = true;
            this.btnGerarCarteirinha.Click += new System.EventHandler(this.btnGerarCarteirinha_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(17, 236);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(222, 20);
            this.dtpDataNascimento.TabIndex = 8;
            // 
            // panelCarteirinha
            // 
            this.panelCarteirinha.Controls.Add(this.lblIdade);
            this.panelCarteirinha.Controls.Add(this.lblCadastroDePessoaFisica);
            this.panelCarteirinha.Controls.Add(this.lblNome);
            this.panelCarteirinha.Controls.Add(this.picIcone);
            this.panelCarteirinha.Location = new System.Drawing.Point(473, 57);
            this.panelCarteirinha.Name = "panelCarteirinha";
            this.panelCarteirinha.Size = new System.Drawing.Size(286, 323);
            this.panelCarteirinha.TabIndex = 9;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(49, 271);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(62, 24);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade";
            // 
            // lblCadastroDePessoaFisica
            // 
            this.lblCadastroDePessoaFisica.AutoSize = true;
            this.lblCadastroDePessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroDePessoaFisica.Location = new System.Drawing.Point(48, 224);
            this.lblCadastroDePessoaFisica.Name = "lblCadastroDePessoaFisica";
            this.lblCadastroDePessoaFisica.Size = new System.Drawing.Size(50, 24);
            this.lblCadastroDePessoaFisica.TabIndex = 2;
            this.lblCadastroDePessoaFisica.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(49, 175);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // picIcone
            // 
            this.picIcone.Location = new System.Drawing.Point(52, 15);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(190, 131);
            this.picIcone.TabIndex = 0;
            this.picIcone.TabStop = false;
            // 
            // FrmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCarteirinha);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btnGerarCarteirinha);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "FrmCarteirinha";
            this.Text = "FrmCarteirinha";
            this.panelCarteirinha.ResumeLayout(false);
            this.panelCarteirinha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnGerarCarteirinha;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Panel panelCarteirinha;
        private System.Windows.Forms.Label lblCadastroDePessoaFisica;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblIdade;
    }
}