using Ecommerce3Ads.Model;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce3Ads.DTO
{
    public class CategoriaRequest
    {
        [MinLength(5)]
        public string Nome { get; set; }

        public Categoria toModel()
            => new Categoria(Nome);
    }
}
