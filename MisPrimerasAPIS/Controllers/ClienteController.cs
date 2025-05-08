using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisPrimerasAPIS.Models;
using MisPrimerasAPIS.Repositorios;

namespace MisPrimerasAPIS.Controllers
{
    [Route("Details/{Identificacion}")]//Es la ruta de la api
    [ApiController]//Define que es una api  
    public class ClienteController : ControllerBase //Herada
    {
        private readonly ClientesRepository _clientesRepository;
        public ClienteController()
        {
            _clientesRepository = new ClientesRepository();
        }
        [HttpGet]
        [Route("List")]
        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            return _clientesRepository.ObtenerListardoClientes();
        }
        [HttpGet]
        [Route("Details")]
        public IActionResult ObtenerInformacionClientePorIdentificacion(string Identifacion)
        {//Es un try y catch
            try
            {
                var cliente = _clientesRepository.ObtenerInfoClientePorIdentificacion(Identifacion);
                return Ok(cliente);
            }
            catch (Exception )
            {
                return StatusCode(505);
            }
        }
        [HttpPost]
        public IActionResult CrearCliente([FromBody] Cliente cliente)
        {
            var guarda = _clientesRepository.CrearCliente(cliente);
            if (guarda)
            {
                return Ok(cliente);
            }
            else
            {
                return StatusCode(505);
            }
        }
        [HttpPut]
        public IActionResult ActualizarCliente([FromBody] Cliente cliente)
        {
            var actualiza = _clientesRepository.ActualizarCliente(cliente);
            if (actualiza)
            {
                return Ok(cliente);
            }
            else
            {
                return StatusCode(500);
            }
        }
        [HttpDelete]
        public IActionResult EliminarCliente(string Identificacion)
        {
            var eliminar = _clientesRepository.EliminarCliente(Identificacion);
            if (eliminar)
            {
                return Ok(Identificacion);
            }
            else
            {
                return StatusCode(500);
            }
            return Ok(eliminar);
        }
    }
}
