using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using MultiApps.Models.Entidades;
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
    public partial class Frmcadastro : Form
    {
        public Frmcadastro()
        {
            InitializeComponent();
       
            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltro.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
       
                if (TemCamposEmBranco())
                {
                    return;
                }

                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txtCPF.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                
                var usuarioRepository = new UsuarioRepository();

                
                var emailJaExiste = usuarioRepository.EmailJaExiste(usuario.Email);
                if (emailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }

                
                var sucesso = usuarioRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {usuario.Nome}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }


        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Campo Cpf é obrigatório");
                txtCPF.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var usuarioId = int.Parse(txtId.Text);

            var usuarioRepository = new UsuarioRepository();
            var sucesso = usuarioRepository.DeletarUsuario(usuarioId);

            if (sucesso)
            {
                MessageBox.Show("Categoria deletada com sucesso")
                CarregarTodosUsuarios();
            }

            else
            {
                MessageBox.Show("não foi possivel deletar a categoria" + txtNome.Text);
            }

            btnDeletar.Enabled = false; 
        }

        private void Frmcadastro_Load(object sender, EventArgs e)
        {
            CarregarTodosUsuarios();
        }



        private void LimparCampos()
        {
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cmbStatus.SelectedIndex = 1;
            txtDataCadastro.Text = string.Empty;
            txtDataUltimoacesso.Text = string.Empty;

        }

       
    }
}
