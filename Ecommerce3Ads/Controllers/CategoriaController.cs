using Ecommerce3Ads.Context;
using Ecommerce3Ads.DTO;
using Ecommerce3Ads.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce3Ads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public CategoriaController()
        {
            _dataContext = new DataContext();
        }

        // GET: api/<CategoriaController>
        [HttpGet]
        public ActionResult<List<Categoria>> Get()
        {
            var categorias = _dataContext.Categoria.ToList<Categoria>();
            return categorias;
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public ActionResult<Categoria> Post([FromBody] CategoriaRequest categoriaRequest)
        {
            if (ModelState.IsValid)
            {
                var categoria = categoriaRequest.toModel();
                _dataContext.Categoria.Add(categoria);
                _dataContext.SaveChanges();
                return categoria;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut]
        public ActionResult<Categoria> Put([FromBody] Categoria categoria)
        {
            var categoriaENulo = _dataContext.Categoria.FirstOrDefault(categoria) == null;
            if (categoriaENulo)
                ModelState.AddModelError("CategoriaId", "Id da categoria não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Categoria.Update(categoria);
                _dataContext.SaveChanges();
                return categoria;
            }
            return BadRequest(ModelState);

        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _dataContext.Categoria.Find(id);
            if (categoria == null)
                ModelState.AddModelError("CategoriaId", "Id da categoria não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Categoria.Remove(categoria);
                _dataContext.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
