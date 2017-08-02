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
        public IEnumerable<string> Get()
        {
            return new string[] { "Veronica", "Maria", "Pablo", "Alex", "Abel" };
        }

        /// <summary>
        /// Obtiene un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Veronica";
        }

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="nombre">Nombre del cliente</param>
        /// <returns></returns>
        [HttpPost]
        public string Post([FromBody]string nombre)
        {
            return nombre;
        }

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]string nombre)
        {
            return nombre;
        }

        /// <summary>
        /// Borra un cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return string.Empty;
        }
    }
}