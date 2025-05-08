using System.Text.Json.Serialization;

namespace MisPrimerasAPIS.Models
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }
        [JsonIgnore]
        public TipoCuenta TipoCuenta { get; set; }
        public String NomrbeTipoCuneta
        {
            get
            {
                return TipoCuenta.ToString();
            }
        }
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
