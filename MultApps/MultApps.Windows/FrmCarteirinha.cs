using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCarteirinha : Form
    {
        public FrmCarteirinha()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = txtCPF.Text.Trim();
            string dataTexto = txtNascimento.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(dataTexto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                MessageBox.Show("Digite um CPF válido (apenas números).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataNascimento;
            if (!DateTime.TryParseExact(dataTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                MessageBox.Show("Insira a data no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idade = DateTime.Today.Year - dataNascimento.Year;
            if (dataNascimento.Date > DateTime.Today.AddYears(-idade)) idade--;

            string cpfOfuscado = OfuscarCPF(cpf);

            Color corCarteirinha;
            string iconePath = "";
            if (idade <= 12)
            {
                corCarteirinha = Color.Blue; // Zona Azul - Criança
                iconePath = "icones/crianca.png";
                picBoxIcone.Load(ImcImagem.Criança);

            }
        
            else if (idade <= 17)
            {
                corCarteirinha = Color.Yellow; // Zona Amarela - Jovem
                iconePath = "icones/jovem.png";
                picBoxIcone.Load(ImcImagem.Joven);
            }

            else if (idade <= 59)
            {
                corCarteirinha = Color.Purple; // Zona Roxa - Adulto
                iconePath = "icones/adulto.png";
                picBoxIcone.Load(ImcImagem.Adulto);
            }

            else
            {
                corCarteirinha = Color.Green; // Zona Verde - Idoso
                iconePath = "icones/Idoso.png";
                 picBoxIcone.Load(ImcImagem.idoso);
            }

            pnlCarteirinha.BackColor = corCarteirinha;
            lblNomeCarteirinha.Text = nome;
            lblIdadeCarteirinha.Text = $"Idade: {idade} anos";
            lblCPFcarteirinha.Text = $"CPF: {cpfOfuscado}";

            if (System.IO.File.Exists(iconePath))
            {
                picBoxIcone.Image = Image.FromFile(iconePath);
            }


            pnlCarteirinha.Visible = true;
              
        }
        private string OfuscarCPF(string cpf)
        {
            return $"***.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}.***";
        }



    }
}
    
