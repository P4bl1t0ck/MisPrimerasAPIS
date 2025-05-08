using MisPrimerasAPIS.Models;

namespace MisPrimerasAPIS.Repositorios
{
    public class ClientesRepository
    {
        private CuentaRepository _cuentasRepository;
        public ClientesRepository()
        {
            // Constructor logic here
            _cuentasRepository = new CuentaRepository();
        }
        public IEnumerable<Cliente> ObtenerListardoClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente1 = new Cliente
            {
                Identificacion = "123456789",
                correo = "tumama@gmail.com",
                Nombre = "Juanito",
                Cuentas = _cuentasRepository.ObtenerListadoCeuntasPorCliente("123456789")

            };
            Cliente cliente2 = new Cliente
            {
                Identificacion = "12345678910",
                correo = "tumama@gmail.com",
                Nombre = "Juanito",
                Cuentas = _cuentasRepository.ObtenerListadoCeuntasPorCliente("12345678910")

            };
            clientes.Add(cliente1);
            clientes.Add(cliente2);
            return clientes;

        }
    }
}
