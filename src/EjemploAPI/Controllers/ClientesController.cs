using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        /// <summary>
        /// Obtiene todos los clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Veronica", "Maria", "Pablo", "Alex", "Abel" });
        }

        /// <summary>
        /// Obtiene un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("Veronica");
        }

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="value">Nombre del cliente</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            return Created($"api/clientes/{value}", value);
        }

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <param name="value">Nombre del cliente</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return Ok(value);
        }

        /// <summary>
        /// Borra un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}