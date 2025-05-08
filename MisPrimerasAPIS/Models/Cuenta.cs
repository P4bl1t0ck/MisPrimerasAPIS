namespace MisPrimerasAPIS.Models
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public double saldo { get; set; }
    }

    public enum TipoCuenta
    {
        //Es un tipo de forma de definir un listado
        Ahorros,
        Corriente,
        Inversion
    }
}
