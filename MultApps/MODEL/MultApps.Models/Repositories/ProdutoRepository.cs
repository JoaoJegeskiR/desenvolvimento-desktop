using Dapper;
using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;
using MultiApps.Models.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public  class ProdutoRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";

        public bool AdicionarProduto(GestaoProdutos produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario (nome, categoria, preco, estoque, imagem, status)
                                   VALUES (@Nome, @Categoria, @Preco, @Estoque, @Imagem, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Categoria", produto.Categoria);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Estoque", produto.Estoque);
                parametros.Add("Imagem", produto.Imagem);
                parametros.Add("@Status", produto.Status.ToString());


                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public DataTable ListarTodosProdutos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT categoria, nome, preco, imagem, quantidade_estoque AS Estoque, status AS Status FROM produto";
                var resultado = db.Query<GestaoProdutos>(comandoSql).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Categoria", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Preco", typeof(string));
                dataTable.Columns.Add("Estoque", typeof(string));
                dataTable.Columns.Add("Imagem", typeof(string));
                dataTable.Columns.Add("Status", typeof(string));
                return resultado;
            }
        }
    }
}
