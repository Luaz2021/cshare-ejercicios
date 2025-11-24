class Program
{
    // Hacemos Main asíncrono si usamos await, pero para este caso no es necesario.
    // Lo mantenemos como public static void Main para simplicidad.
    public static void Main(string[] args) 
    {
        int opcion;
        do
        {
            //LISTADO
            Console.WriteLine("---- MENÚ DE OPCIONES ----");
            Console.WriteLine("1. Verificar si el numero esta entre 10 y 20");
            Console.WriteLine("2. Verificar si el numero es negativo o mayor a 100");
            Console.WriteLine("3. Verificar si el numero no es igual a 10");
            Console.WriteLine("4. Verificar si una persona es mayor de edad y tiene carnet de conducir");
            Console.WriteLine("5. Verificar si el número no está entre 1 y 10");
            Console.WriteLine("6. Salir");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ingrese una opcion:");
            opcion = ValidarEntero();
            
            switch (opcion)
            {
                case 1:
                Console.WriteLine("Introduce un número:");
                int numero = ValidarEntero();

                if(numero >= 10 && numero <= 20)Console.WriteLine("El numero esta entre 10 y 20");     
                else Console.WriteLine("El numero no esta entre 10 y 20");
                break;

                case 2:
                Console.WriteLine("Introduce un número:");
                bool entradaNumericaValida = false;
                while (!entradaNumericaValida)
                {
                    string entrada = Console.ReadLine();
                    int numero2;

                    // Intentamos convertir la entrada a un número.
                    if (int.TryParse(entrada, out numero2))
                    {
                        // Si es un número, salimos del bucle de validación.
                        entradaNumericaValida = true; 

                        // Ahora aplicamos la lógica de la opción 2.
                        if(numero2 < 0 || numero2 > 100) Console.WriteLine("El numero es negativo o mayor a 100");
                        else Console.WriteLine("El numero no es negativo ni mayor a 100");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingresaste un carácter. Por favor, introduce un número entero.");
                    }
                }
                break;

                case 3:
                Console.WriteLine("Introduce un número:");
                int numero3 = ValidarEntero();

                if (numero3 != 10)Console.WriteLine("El numero no es igual a 10");
                else Console.WriteLine("El numero es igual a 10");    
                break;

                case 4:
                
                Console.WriteLine("Introduce tu edad");
                int edad = ValidarEntero();

                Console.WriteLine("Tienes carnet de conducir? (S/N)");
                
                bool carnetValido = false;
                string carnet = "";

                while (!carnetValido)
                {
                    carnet = Console.ReadLine().ToUpper();

                    if (carnet == "S" || carnet == "N")
                    {
                        carnetValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada no valida. Por favor, introduce S o N.");            
                    } 
                }

                if (edad >= 18 && carnet == "S") Console.WriteLine("Puedes conducir un vehiculo");
                else Console.WriteLine("No puedes conducir un vehiculo");
                break;

                case 5:
                Console.WriteLine("Introduce un numero");
                int numero5 = ValidarEntero();

                if (!(numero5 >= 1 && numero5 <= 10)) Console.WriteLine("El numero no esta entre 1 y 10");
                else Console.WriteLine("El numero esta entre 1 y 10");
                break;
                
                case 6:
                Console.WriteLine("Saliendo del programa..");
                break;

                default:
                Console.WriteLine("Opcion no valida. Inténtalo de nuevo.");
                break;
            }
            if (opcion != 6)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (opcion != 6);
    }

    // CORRECCIÓN: Eliminamos el parámetro 'valor' que no se usaba.
    static int ValidarEntero()
    {
        int numeroValido = 0;
        bool esValido = false;

        while(!esValido){
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numeroValido))
            {
                // AÑADIDO: Verificamos que el número no sea negativo.
                if (numeroValido >= 0)
                {
                    esValido = true; // El número es un entero y no es negativo, es válido.
                }
                else
                {
                    // El número es un entero pero es negativo.
                    Console.WriteLine("El número no puede ser negativo. Inténtalo de nuevo.");
                }
            }else{
                // La entrada no es un número entero (son letras u otros caracteres).
                Console.WriteLine("Entrada invalida. Por favor, introduce un número entero.");
            }
        }
        return numeroValido;
    }
}