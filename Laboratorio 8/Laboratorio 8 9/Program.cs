using Laboratorio_8_9;

internal class Program
{
    private static void Main(string[] args)
    {
        Template temp1 = new Template();
        temp1.ponerVariable("var1", "valor 1");
        temp1.ponerVariable("var2", "valor 2");
        temp1.ponerVariable("var3", "valor 3");
        temp1.verHtml("<br>Texto de Prueba</br>");
    }
}