using System.ComponentModel.DataAnnotations;

namespace Ecommerce3Ads.Model
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Categoria(string nome)
        {
            Nome = nome; 
        }
    }
}
