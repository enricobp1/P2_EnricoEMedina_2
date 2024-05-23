using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce3Ads.Model
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        
    }
}
