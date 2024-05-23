using Ecommerce3Ads.Model;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce3Ads.DTO
{
    public class PedidoResquest
    {
        public DateTime Data { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        [Required]

        public int Quantidade { get; set; }

    }
}
