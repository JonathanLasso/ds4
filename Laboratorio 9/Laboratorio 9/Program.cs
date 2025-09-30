internal class Program
{
    private static void Main(string[] args)
    {
        //declaración de variables.
        int precioProducto; //variable para leer el precio del producto que ingresa el usuario.
        string formaPago, numeroCuenta; // variables para leer la forma de pago y su numero de cuenta.

        //Utilizo el while(true) para permitir corregir errores al momento de ingresar el precio de un producto.
        while (true)
        {
            try //utilizo el try y el catch para capturar la excepcion de formatException.
            {
                Console.WriteLine("Ingrese cualquier precio de un producto (que se a de valor positivo)");
                precioProducto = Convert.ToInt16(Console.ReadLine());

                if (precioProducto <= 0) //valido si el precio es negativo.
                {
                    Console.WriteLine("No se permiten precios negativos o ceros.");
                }
                else // si no es negativo sale del bucle y continua el programa.
                {
                    break; // para salir del while.
                }

            } catch (FormatException e) //Capturo la excepcion.
            {
                Console.WriteLine("El formato es incorrecto, intente de nuevo"); //Mando un mensaje cuando ocurre la excepcion.
            }
        }
        //Utilizo el while(true) para permitir corregir errores al momento de ingresar la forma de pago.
        while (true)
        {
            Console.WriteLine("Ingrese la forma de pago que desea (Efectivo o tarjeta)");
            formaPago = Console.ReadLine();

            //Valido la forma de pago si es en efectivo o tarjeta
            if (String.Equals("efectivo", formaPago.ToLower())) //tranformo el string de la variable formaPago a minuscula con el metodo ToLower().
            {
                Console.WriteLine("El precio del producto ya fue pagado con exito.");
                break; // el break para salir del while externo.
            }
            else if (String.Equals("tarjeta", formaPago.ToLower()))
            {
                //Utilizo el while(true) para permitir corregir errores al momento de ingresar el numero de cuenta.
                while (true)
                {
                    Console.WriteLine("Ingrese su numero de cuenta de solo 16 digitos");
                    numeroCuenta = Console.ReadLine();

                    if (numeroCuenta.Length == 16) //Valido la longitud del string de la variable numeroCuenta para que se de solo 16 digitos.
                    {
                        Console.WriteLine("Su numero de cuenta fue correcto y su compra fue realizada exitosamente.");
                        break; // el break para salir del bucle del while interno.
                    }
                    else
                    {
                        Console.WriteLine("El numero de cuenta solo es de 16 digitos");
                    }
                }
                break; // el ultimo break para salir del bucle del while externo.
            }
            else
            {
                Console.WriteLine("La forma de pago que ingreso es incorrecto");
            }
        }
    }
}