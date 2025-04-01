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
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }
        private void ChkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkMasculino.Checked = false;
        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkFeminino.Checked = false;

        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            lblAnos.Visible = true;
            cmbIdade.Visible = true;
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            lblAnos.Visible = false;
            cmbIdade.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (chkAdulto.Checked == true && chkMasculino.Checked == true)
            {
                #region Adulto Masculino 


                var peso = double.Parse(txtPeso.Text);
                var Altura = double.Parse(txtAltura.Text);

                var imc = peso / (Altura * Altura);
                var textobase = $@"Seu IMC: {imc:N2} é";

                if (imc < 18.5)
                {
                    lblResultadoimc.Text = $@"{textobase} abaixo do normal";
                    PicBoximc.Load(ImcImagem.MasculinoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoimc.Text = $@"{textobase} normal";
                    PicBoximc.Load(ImcImagem.MasculinoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoimc.Text = $@"{textobase} sobrepeso";
                    PicBoximc.Load(ImcImagem.MasculinoSobrepeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade grau I";
                    PicBoximc.Load(ImcImagem.MasculinoObesidadeGrauI);
                }
                else if (imc < 39.9)
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade grau II";
                    PicBoximc.Load(ImcImagem.MasculinoObesidadeGrauII);
                }
                else
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade grau III";
                    PicBoximc.Load(ImcImagem.MasculinoObesidadeGrauIII);
                }
                #endregion
            }

            if (chkAdulto.Checked && chkFeminino.Checked)
            {
                #region Adulto Feminino

                var peso = double.Parse(txtPeso.Text);
                var Altura = double.Parse(txtAltura.Text);

                var imc = peso / (Altura * Altura);
                var textobase = $@"Seu IMC: {imc:N2} é";

                if (imc < 18.5)
                {
                    lblResultadoimc.Text = $@"{textobase} abaixo do normal";
                    PicBoximc.Load(ImcImagem.FemininoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoimc.Text = $@"{textobase} normal";
                    PicBoximc.Load(ImcImagem.FemininoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoimc.Text = $@"{textobase} sobrepeso";
                    PicBoximc.Load(ImcImagem.FemininoSobrepeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade grau I";
                    PicBoximc.Load(ImcImagem.FemininoObesidadeGrauI);
                }
                else if (imc < 39.9)
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade grau II";
                    PicBoximc.Load(ImcImagem.FemininoObesidadeGrauII);
                }
                else
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade grau III";
                    PicBoximc.Load(ImcImagem.FemininoObesidadeGrauIII);
                }
                #endregion

            }

            else if (chkCrianca.Checked == true)


            {

                var peso = double.Parse(txtPeso.Text);
                var Altura = double.Parse(txtAltura.Text);

                var imc = peso / (Altura * Altura);
                var textobase = $@"Seu IMC: {imc:N2} é";

                #region Crianca 


                if (imc < 18.5)
                {
                    lblResultadoimc.Text = $@"{textobase} abaixo do normal";
                    PicBoximc.Load(ImcImagem.CriançaAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoimc.Text = $@"{textobase} normal";
                    PicBoximc.Load(ImcImagem.CriançaNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoimc.Text = $@"{textobase} sobrepeso";
                    PicBoximc.Load(ImcImagem.CriançaSobrepeso);

                }
                else if (imc < 34.9)
                {
                    lblResultadoimc.Text = $@"{textobase} obesidade";
                    PicBoximc.Load(ImcImagem.CriançaObesidade);
                }
                #endregion

            }







        }

    }
}   

