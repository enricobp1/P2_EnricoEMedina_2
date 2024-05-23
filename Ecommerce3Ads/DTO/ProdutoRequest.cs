using Ecommerce3Ads.Model;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce3Ads.DTO
{
    public class ProdutoRequest
    {
        [MinLength(5)]
        public string Nome { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        public Produto toModel()
            => new Produto(Nome, CategoriaId);
    }
}
