using Ecommerce3Ads.Model;

namespace Ecommerce3Ads.DTO
{
    public class ProdutoResponse
    {
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }

        public ProdutoResponse(Produto produto)
        {
            Nome = produto.Nome;
            Categoria = produto.Categoria;
        }


    }
}
