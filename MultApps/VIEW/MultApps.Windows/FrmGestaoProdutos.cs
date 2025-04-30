using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;
using MultApps.Models.Repositories;
using MultApps.Models.Services;
using MultiApps.Models.Enum;
using MultiApps.Models.Repositories;
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
    public partial class FrmGestaoProdutos : Form
    {
        public FrmGestaoProdutos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if(TemCamposEmBranco())
                    {
                        return;
                    }

                    var produto = new GestaoProdutos();
                    produto.Categoria = cmbCategoria.Text;
                    produto.Nome = txtNome.Text;
                    produto.Preco = txtPreco.Text;
                    produto.Estoque = txtEstoque.Text;
                    produto.Imagem = txtURL.Text;

                    var produtoRepository = new ProdutoRepository();

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo nome é obrigatório");
                txtNome.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("Campo Estoque é obrigatório");
                txtEstoque.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Campo Preço é obrigatório");
                txtPreco.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtURL.Text))
            {
                MessageBox.Show("Campo URL é obrigatório");
                txtURL.Focus();
                return true;
            }
            return false;
        }
    }
}
