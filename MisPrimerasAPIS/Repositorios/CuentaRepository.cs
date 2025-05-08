using MisPrimerasAPIS.Models;

namespace MisPrimerasAPIS.Repositorios
{
    public class CuentaRepository
    {
        public IEnumerable<Cuenta> ObtenerListadoCeuntasPorCliente(string Identificacion)
        {
            List<Cuenta> Cuentas = new List<Cuenta>();
            Cuenta cuenta1 = new Cuenta()
            {
                NumeroCuenta = 123456,
                TipoCuenta = TipoCuenta.Ahorros,
                saldo = 100
           
            };
            Cuenta cuenta2 = new Cuenta()
            {
                NumeroCuenta = 456789,
                TipoCuenta = TipoCuenta.Corriente,
                saldo = 2000
            };
            Cuentas.Add(cuenta1);
            Cuentas.Add(cuenta2);
            return Cuentas;
        }
    }
}
