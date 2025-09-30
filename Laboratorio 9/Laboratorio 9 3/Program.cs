internal class Program
{
    private static void Main(string[] args)
    {
        //declaracion de variables
        int lado1 = 0, lado2 = 0, lado3 = 0; //cree tres variables para leer los tres lados de un triangulo y lo inicialize con cero.

        //Aquí estoy dandole valor a los lados ingresados por el usuario con el metodo lados().
        lado1 = lados("Ingrese un valor para el lado 1", lado1);
        lado2 = lados("Ingrese un valor para el lado 2", lado2);
        lado3 = lados("Ingrese un valor para el lado 3", lado3);

        //Muestro los valores de los lados ingresados por el usuario.
        Console.WriteLine($"{lado1}, {lado2}, {lado3}");

        //Aqui muestro el tipo de triangulo con el metodo claseDeTriangulo().
        claseDeTringulo(lado1, lado2, lado3);

        //Cree un metodo estatico que retorna un int para darle valor a un lado.
        static int lados(string mensaje, int lado) //agrege dos parametros uno con el mensaje y el otro con el valor del lado.
        {
            while (true) //Utilice el while(true) para cuando el usuario ingresa un valor permite corregir si ocurre un error.
            {
                try // utilizo el try y catch para atrapar la excepcion formatException
                {
                    Console.WriteLine(mensaje);
                    lado = Convert.ToInt16(Console.ReadLine());

                    if (lado <= 0) //Valido si el usuario ingresa valores negativos o ceros.
                    {
                        Console.WriteLine("No se permiten valores negativos o iguales a cero.");
                    }
                    else // Y si no retorno el valor del lado.
                    {
                        return lado; //Retorno el valor del lado.
                    }
                }
                catch (FormatException a) //Capturo la excepcion.
                {
                    Console.WriteLine("Error de formato"); //Mando un mensaje cuando ocurre la excepcion.
                }
            }
        }

        //Cree un metodo estatico que no retorna para mostrar la clase de triangulo que forma.
        static void claseDeTringulo(int lado1, int lado2, int lado3) // tiene tres parametros que son los tres lados ingresados por el usuario
        {
            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1)) // valido los lados ingresados forman un triangulo.
            {
                if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3) //Verifico si es un triangulo equilatero.
                {
                    Console.WriteLine("Es un Triángulo equilátero.");
                }

                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) //Verifico si es un triangulo isoceles.
                {
                    Console.WriteLine("Es un Triángulo isoceles.");
                }

                else //Y si no es ninguno de los dos anteriores es un triangulo escaleno.
                {
                    Console.WriteLine("Es un Triángulo escaleno.");
                }
            }
            else //Valido cuando los lados ingresados por el usuario no forman un triangulo.
            {
                Console.WriteLine("Lados ingresados no conforman un triangulo.");
            }
           
        }
    }
}