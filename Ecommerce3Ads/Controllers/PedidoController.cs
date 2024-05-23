using Ecommerce3Ads.Context;
using Ecommerce3Ads.DTO;
using Ecommerce3Ads.Model;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce3Ads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PedidoController()
        {
            _dataContext = new DataContext();
        }

        [HttpGet]
        public ActionResult<List<Pedido>> Get()
        {
            var pedidos = _dataContext.Pedido.ToList<Pedido>();
            return pedidos;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public ActionResult<Pedido> Post([FromBody] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _dataContext.Pedido.Add(pedido);
                _dataContext.SaveChanges();
                return pedido;
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public ActionResult<Pedido> Put([FromBody] Pedido pedido)
        {
            var pedidoENulo = _dataContext.Pedido.FirstOrDefault(pedido) == null;
            if (pedidoENulo)
                ModelState.AddModelError("PedidoId", "Id do pedido não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Pedido.Update(pedido);
                _dataContext.SaveChanges();
                return pedido;
            }
            return BadRequest(ModelState);

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pedido = _dataContext.Pedido.Find(id);
            if (pedido == null)
                ModelState.AddModelError("PedidoId", "Id do pedido não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Pedido.Remove(pedido);
                _dataContext.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
