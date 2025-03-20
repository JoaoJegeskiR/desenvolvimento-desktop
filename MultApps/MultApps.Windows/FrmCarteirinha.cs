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

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompleto.Text;
            string cpf = txtCPF.Text;
            DateTime dataNascimento;
            if (!DateTime.TryParse(txtNascimento.Text, out dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida!");
                return;
            }

            int idade = CalcularIdade(dataNascimento);
            if (idade == -1)
            {
                MessageBox.Show("Preencha todos os campos!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idadeUsuario = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now < dataNascimento.AddYears(idade)) idade--;

            Color corZona;
            picIcone.Load("");

            if (idade <= 12)
            {
                corZona = Color.Blue;
                picIcone.Load("https://img.cdndsgni.com/preview/11614026.jpg");

            }

            else if (idade >=60 ) 
            {
                corZona = Color.Green;
                picIcone.Load("https://img.cdndsgni.com/preview/10234370.jpg");

            }

            else if ( idade >= 13 && idade <= 25)
            {
                corZona = Color.Yellow;
                picIcone.Load("https://www.pngarts.com/files/3/Young-Man-PNG-Download-Image.png");

            }

            else
            {
                corZona = Color.Purple;
                picIcone.Load("https://cdn-icons-png.flaticon.com/512/3107/3107137.png");

            }



        }

        
    }
            
        
    
}
    
