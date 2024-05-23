using System.ComponentModel.DataAnnotations;

namespace Ecommerce3Ads.Model
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(string nome, int categoriaId)
        {
            Nome = nome;
            CategoriaId = categoriaId;
        }
    }
}
