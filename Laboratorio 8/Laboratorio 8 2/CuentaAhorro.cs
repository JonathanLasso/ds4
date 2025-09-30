namespace Laboratorio_8_2
{
    internal class CuentaAhorro : Cuenta
    {
        public CuentaAhorro (string prmtIdCuenta) : base(prmtIdCuenta)
        {

        }

        public override void calcularInteres()
        {
            System.Console.WriteLine(
                "CuentaAhorro.calcularIntereses() efectuando para " +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
