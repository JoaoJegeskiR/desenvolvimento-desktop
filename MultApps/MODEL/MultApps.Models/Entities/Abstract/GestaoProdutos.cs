using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities.Abstract
{
    public  class GestaoProdutos : EntidadeBase
    {
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Estoque { get; set; } 
        public string Imagem { get; set; }

    }
}
