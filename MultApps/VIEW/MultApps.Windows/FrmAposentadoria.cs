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
    public partial class FrmAposentadoria : Form
    {
        public FrmAposentadoria()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string dataTexto = txtNascimento.Text.Trim();
            string sexo = cbSexo.SelectedItem?.ToString();
            int tempoContribuicao;

            
            DateTime dataNascimento;
            if (!DateTime.TryParseExact(dataTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                MessageBox.Show("Insira uma data válida no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!int.TryParse(txtContribuicao.Text, out tempoContribuicao))
            {
                MessageBox.Show("Insira um número válido para o tempo de contribuição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int idade = DateTime.Today.Year - dataNascimento.Year;
            if (dataNascimento.Date > DateTime.Today.AddYears(-idade)) idade--;

            
            bool podeAposentar = (sexo == "Masculino" && idade >= 65 && tempoContribuicao >= 15) ||
                                 (sexo == "Feminino" && idade >= 62 && tempoContribuicao >= 15);

          
            pnlResultado.Visible = true;
            lblResultado.Text = podeAposentar ?
                "✅ Você pode dar entrada no processo de aposentadoria!" :
                "❌ Você não cumpre os requisitos para se aposentar.";
            lblResultado.ForeColor = podeAposentar ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }
    }
}
