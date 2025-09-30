namespace Laboratorio_8_9
{
    internal class Template : Itemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine("Metodo poner variable {nombre}  : {var}");
        }

        public void verHtml(string template)
        {
            Console.WriteLine(template);
        }
    }
}
