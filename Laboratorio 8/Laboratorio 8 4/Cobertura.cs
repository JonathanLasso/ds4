namespace Laboratorio_8_4
{
    //Propiedades de solo lectura
    internal class Cobertura
    {
        private double radio;

        public Cobertura (double radio)
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
        }
    }
}
