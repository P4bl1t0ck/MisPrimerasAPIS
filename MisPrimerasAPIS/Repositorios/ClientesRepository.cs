using System.ComponentModel;
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
        public Cliente ObtenerInfoClientePorIdentificacion(string Identificacion)
        {
            var clientes = ObtenerListardoClientes();
            Cliente cliente = clientes.First(item => item.Identificacion == Identificacion);
            return cliente;
        }
        //Metodos de CRUD
        public bool CrearCliente(Cliente cliente)
        {
            // Aquí puedes implementar la lógica para crear un nuevo cliente
            // Por ejemplo, agregarlo a una base de datos o una lista en memoria
            // Retorna true si se creó correctamente, false en caso contrario
            return true;
        }
        public bool ActualizarCliente(Cliente cliente)
        {
            // Aquí puedes implementar la lógica para crear un nuevo cliente
            // Por ejemplo, agregarlo a una base de datos o una lista en memoria
            // Retorna true si se creó correctamente, false en caso contrario
            return true;
        }
        public bool EliminarCliente(Cliente Identificacion)
        {
            // Aquí puedes implementar la lógica para crear un nuevo cliente
            // Por ejemplo, agregarlo a una base de datos o una lista en memoria
            // Retorna true si se creó correctamente, false en caso contrario
            return true;
        }

    }
}
