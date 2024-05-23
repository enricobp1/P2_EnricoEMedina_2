using Ecommerce3Ads.Context;
using Ecommerce3Ads.DTO;
using Ecommerce3Ads.Model;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce3Ads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ProdutoController()
        {
            _dataContext = new DataContext();
        }

        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            var produtos = _dataContext.Produto.ToList<Produto>();
            return produtos;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public ActionResult<Produto> Post([FromBody] ProdutoRequest produtoRequest)
        {
            if (ModelState.IsValid)
            {
                var produto = produtoRequest.toModel();
                _dataContext.Produto.Add(produto);
                _dataContext.SaveChanges();
                return produto;
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public ActionResult<Produto> Put([FromBody] Produto produto)
        {
            var produtoENulo = _dataContext.Produto.FirstOrDefault(produto) == null;
            if (produtoENulo)
                ModelState.AddModelError("ProdutoId", "Id do produto não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Produto.Update(produto);
                _dataContext.SaveChanges();
                return produto;
            }
            return BadRequest(ModelState);

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var produto = _dataContext.Produto.Find(id);
            if (produto == null)
                ModelState.AddModelError("ProdutoId", "Id do produto não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Produto.Remove(produto);
                _dataContext.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
