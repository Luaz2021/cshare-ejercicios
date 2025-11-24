using System;
namespace numeroMultiplo
{ 
    class Program
    {
        static int ValidarNumero(string mensaje)
        {
            int numero;
            bool esValido = false;

            do
            {
                Console.WriteLine(mensaje);
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    if (numero > 0)
                    {
                        esValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Debe ingresar un número entero mayor a cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: La entrada no es válida. Debe ingresar un número entero.");
                }

            } while (!esValido);

            return numero;
        }
        static void Main(string[] args)
        {
            int valor = ValidarNumero("Ingrese un número entero mayor a cero:");

            if (valor % 5 == 0 )
            {
                Console.WriteLine("El número ingresado es múltiplo de 5.");
            }
            else
            {
                Console.WriteLine("El número ingresado no es múltiplo de 5.");          
            }

        }
    }
}