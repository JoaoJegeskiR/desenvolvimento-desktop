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

       

        private void CarregarProdutos()
        {
            var produtoRepository = new ProdutoRepository();

            var listaProdutos = produtoRepository.ListarProdutos();
            dataGridView1.DataSource = listaProdutos;
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            cmbCategoria.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtURL.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var produtoId = (int)row.Cells[0].Value;

            var produtoRepository = new ProdutoRepository();
            var produto = produtoRepository.ObterProduto(produtoId);

            if (produto == null)
            {
                MessageBox.Show($"Usuario: #{produtoId} não encontrado");
                return;
            }

            txtId.Text = produtoId.ToString();
            txtNome.Text = produto.Nome;
            cmbCategoria.Text = produto.Categoria;
            txtURL.Text = produto.Imagem;
            txtEstoque.Text = produto.Estoque;
            txtPreco.Text = produto.Preco;
            txtDescricao.Text = produto.Descricao;
            cmbStatus.SelectedIndex = (int)produto.Status;

            btnSalvar.Text = "Atualizar produto";
            btnDeletar.Enabled = true;
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            cmbCategoria.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtURL.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void cmbStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();

            switch (cmbStatus.SelectedIndex)
            {
                case 0:
                    CarregarProdutos();
                    break;
                case 1:
                    var produtosAtivos = produtoRepository.ListarProdutosPorStatus(1);
                    dataGridView1.DataSource = produtosAtivos;
                    break;
                case 2:
                    var produtosInativos = produtoRepository.ListarProdutosPorStatus(0);
                    dataGridView1.DataSource = produtosInativos;
                    break;
            }
        }

        private void FrmGestaoProdutos_Load(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();
            var categorias = produtoRepository.ListarCategorias();

            foreach (var categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria);
            }
        }

        private void cmbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();
            var categoriaSelecionada = cmbCategoria.Text;

            dataGridView1.DataSource = produtoRepository.ListarProdutosPorCategoria(categoriaSelecionada);
        }

        private void btnAtualizarGrid_Click_1(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnNovoProduto_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
    

