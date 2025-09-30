namespace Laboratorio_8_8
{
    internal class ClaseConcretal2 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "claseConcretal2";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}claseConcretal2";
        }
    }
}
