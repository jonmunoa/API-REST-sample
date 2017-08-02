using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EjemploAPI.Controllers
{
    [Route("api/clientes/{clienteID}/[controller]")]
    public class PedidosController : Controller
    {
        /// <summary>
        /// Obtiene todos los pedidos de un cliente
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new[]
            {
                new { id = 1, estado = "Entregado" },
                new { id = 2, estado = "En proceso" }
            }.ToList());
        }

        /// <summary>
        /// Obtiene un pedido de un cliente
        /// </summary>
        /// <param name="id">Identificador del pedido</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { id = id, estado = "Entregado" });
        }

        /// <summary>
        /// Crea un pedido de un cliente
        /// </summary>
        /// <param name="clienteId">Identificador del cliente</param>
        /// <param name="value">Nombre del pedido</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromRoute] int clienteId, [FromBody]string value)
        {
            return Created($"api/clientes/{clienteId}/pedidos/3", new { id = 3, estado = "Sin tramitar" });
        }

        /// <summary>
        /// Actualiza el pedido de un cliente
        /// </summary>
        /// <param name="id">Identificador del pedido</param>
        /// <param name="value">Nombre del pedido</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return Ok(new { id = 2, estado = "En proceso" });
        }

        /// <summary>
        /// Borra el pedido de un cliente
        /// </summary>
        /// <param name="id">Identificador del pedido</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}