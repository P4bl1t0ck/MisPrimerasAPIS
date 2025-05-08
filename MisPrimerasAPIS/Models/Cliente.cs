namespace MisPrimerasAPIS.Models
{
    public class Cliente
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string correo { get; set; }
        //Una forma abstracta de que tenga mas de una cuenta con el
        //la estructura de datos Ienumerable.
        public IEnumerable<Cuenta> Cuentas { get; set; }
    }
}
