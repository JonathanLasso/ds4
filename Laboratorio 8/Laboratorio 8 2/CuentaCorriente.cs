namespace Laboratorio_8_2
{
    internal class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {

        }

        public override void calcularInteres()
        {
            System.Console.WriteLine(
                "CuentaCorriente.calcularIntereses() efectuando para " +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
