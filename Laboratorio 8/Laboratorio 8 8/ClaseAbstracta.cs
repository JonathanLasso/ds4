namespace Laboratorio_8_8
{
    internal abstract class ClaseAbstracta
    {
        //Se fuerza la herenca de la clase para definir estos métodos
        abstract protected string tomarValor();
        abstract public string prefixValor(string prefix);
        //Metodo común
        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
}
