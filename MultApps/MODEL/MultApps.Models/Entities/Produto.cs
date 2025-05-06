using MultApps.Models.Entidades;
using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;

namespace MultiApps.Models.Entidades
{
    internal class Produto : EntidadeBase
    {
        public int categoriaId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public Categoria Categoria { get; set; }
    }
}