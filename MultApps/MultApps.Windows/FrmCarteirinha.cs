using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string Zona { get; set; }
        public Image Icone { get; set; }
        public Color CorZona { get; set; }

        public FrmCarteirinha(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Idade = CalcularIdade(dataNascimento);
            CPF = OfuscarCPF(cpf);
            DefinirZonaEIcone();
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now < dataNascimento.AddYears(idade)) idade--;
            return idade;
        }

        private string OfuscarCPF(string cpf)
        {
            if (cpf.Length != 11)
                return "CPF inválido";

            return $"***.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}.***";
        }

        private void DefinirZonaEIcone()
        {
            if (Idade <= 12)
            {
                Zona = "Zona Azul - Criança";
                CorZona = Color.Blue;
                picIcone.Load("https://cdn-icons-png.flaticon.com/512/3884/3884934.png");
            }
            else if (Idade >= 60)
            {
                Zona = "Zona Verde - Idoso";
                CorZona = Color.Green;
                picIcone.Load("https://img.lovepik.com/png/20231120/an-elderly-couple-icon-line-vector-line-icons-lineal-icon_645654_wh860.png");
            }
            else if (Idade >= 13 && Idade <= 17)
            {
                Zona = "Zona Amarela - Jovem";
                CorZona = Color.Yellow;
                picIcone.Load("https://cdn-icons-png.flaticon.com/512/3461/3461376.png");
            }
            else (Idade >= 18 && Idade <= 59)
            {
                Zona = "Zona Roxa - Adulto";
                CorZona = Color.Purple;
                picIcone.Load("https://cdn-icons-png.flaticon.com/512/2179/2179285.png");
            }
        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompleto.Text;
            string cpf = txtCPF.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;

            if (string.IsNullOrWhiteSpace(nome) || cpf.Length != 11)
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmCarteirinha carteirinha = new FrmCarteirinha(nome, cpf, dataNascimento);

            lblNome.Text = carteirinha.Nome;
            lblCadastroDePessoaFisica.Text = carteirinha.CPF;
            lblIdade.Text = $"{carteirinha.Idade} anos";
            panelCarteirinha.BackColor = carteirinha.CorZona;
            picIcone.Image = carteirinha.Icone;
        }
    }
}