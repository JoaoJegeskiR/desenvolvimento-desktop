using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MultApps.Models.Repositories
{
    public class CategoriaRepositorie
    {
        public string ConnectionString = "Serve=localhost;Database=multiapps_dev; Uid=root,Pwd=root";
        public bool cadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandosql = @"INSERT INTO Categoria (Nome, Status) VALUES(@Nome, @Status)";

                var parametro = new DynamicParameters();

                parametro.Add("@Nome", categoria.Nome);
                parametro.Add("@Status", categoria.Status);


                
                var resultado = db.Execute(comandosql, categoria);
                return resultado > 0;
            }
        }
    }
}
