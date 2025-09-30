using Laboratorio_9_4;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaracion de las variables
        /*
         *Declare la variable mostrarUnNumero para alamacenar el valor del numero generado aleatorimente.
         *Declare la variable maximo para el rango maximo al generar un numero aleatorio.
         *Declare la variable mininmo para el rango minimo al generar un numero aleatorio.
         *Declare la variable cantidad para el tamaño del arreglo.
         *Declare un arreglo llamado mostrarUnArregloNumeros para aguardar la referencia del arreglo creado por el metodo generarUnArregloNumeros().
         */
        int mostrarUnNumero, maximo = 0, minimo = 0, cantidad = 0; 
        int[] mostrarUnArregloNumeros;

        //Declare e inicialice el objeto ale de la clase Aleatorios.
        Aleatorios ale = new Aleatorios();

        //Aqui lee las variables (minimo, maximo y cantidad) que declare para que el usuario ingrese los valores usando el metodo verificar().
        minimo = verificar("Ingrese un valor minimo", minimo);
        maximo = verificar("Ingrese un valor maximo", maximo);
        cantidad = verificar("Ingrese una cantidad", cantidad);

        //Aqui guardo el numero generado por el metodo generarUnNumero con el objeto ale.
        mostrarUnNumero = ale.generarUnNumero(minimo, maximo);

        //Inicializo el arreglo que declare al inicio con el tamaño definido por el usuario con la variable cantidad.
        mostrarUnArregloNumeros = new int[cantidad];
        //Almaceno la referencia del arreglo generado por el metodo generarUnArregloNumeros con el objeto ale.
        mostrarUnArregloNumeros = ale.generarUnArregoNumeros(cantidad,minimo, maximo);

        //Aqui muestro el numero generado aleatoriamente con un rango minimo y maximo.
        Console.WriteLine($"El numero generado es: {mostrarUnNumero}");

        //Aqui muestro el arreglo de numeros generados aleatoriamente con un rango minimo y maximo, ademas con un tamaño definido en el arreglo por el usuario.
        Console.Write("El arreglo de los numeros generados son: ");
        for ( int i = 0; i < cantidad; i++ )
        {
            Console.Write(mostrarUnArregloNumeros[i]+ ", ");
        }

        //Cree un metodo estatico llamado verificar que hace que valide el valor si es negativo y permite corregir cuando ocurra excepciones.
        static int verificar(string mensaje, int valor) //Tiene dos parametros que son el mensaje de tipo string y el valor de tipo int.
        {
            //Utilizo un while(true) para permitir cuando ocurran errores.
            while(true)
            {
                try //Utilizo el try y catch para capturar excepciones.
                {
                    Console.WriteLine(mensaje); //Muestro el mensaje.
                    valor = Convert.ToInt16(Console.ReadLine()); //Leo el valor.

                    if(valor <= 0) //Valido que no sea negativo ni cero.
                    {
                        Console.WriteLine("El valor ingresando no puede ser negativo ni cero.");
                    }
                    else // Y si no es ni negativo ni cero.
                    {
                        return valor; // Retorno el valor.
                    }
                }catch (FormatException e) //Capturo la excepcion FormatException.
                {
                    Console.WriteLine("Formato incorrecto"); //Mando un mensaje cuando ocurra la excepcion.
                }
            }
        }
    }
}