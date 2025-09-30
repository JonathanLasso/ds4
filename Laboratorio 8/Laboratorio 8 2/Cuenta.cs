namespace Laboratorio_8_2
{
    internal class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmtIdCuenta)
        {
            idCuenta = prmtIdCuenta;
            System.Console.WriteLine(
                "Constructor Clase Base para cuenta {0}", prmtIdCuenta);
        }

        public virtual void calcularInteres()
        {
            System.Console.WriteLine(
                "Cuenta.calcularIntereses() efectuando para la cuenta {0}"
                , idCuenta);
        }

        public string getIdCuenta()
        {
            return idCuenta;
        }

    }
}
