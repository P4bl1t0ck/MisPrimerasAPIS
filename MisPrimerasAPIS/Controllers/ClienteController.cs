using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisPrimerasAPIS.Models;
using MisPrimerasAPIS.Repositorios;

namespace MisPrimerasAPIS.Controllers
{
    [Route("api/[controller]")]//Es la ruta de la api
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
    }
}
