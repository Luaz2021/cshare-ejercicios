using System;   
namespace perimetroTriangulo
{
    class Program
    {
        // Método para leer y validar la entrada de los lados reutilizando codigo ;) 
        static double Leerlado(string mensaje)
        {
            double numero = 0;
            bool entradaValida = false;
            do
            {
                Console.WriteLine(mensaje);
                string? entrada = Console.ReadLine();

                // Se intenta convertir la entrada a un número. Si tiene éxito y es positivo, salimos del bucle.
                if (double.TryParse(entrada, out numero) && numero > 0) 
                {
                    entradaValida = true;
                }
                else
                {
                    // Si no, mostramos un único mensaje de error genérico.
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
                }
                
            } while (!entradaValida);
            
            
            return numero;
        }
        // Método para calcular el perímetro del triángulo.
        static double CalcularPerimetro(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        // Método para validar si los lados pueden formar un triángulo.
        static bool EsTrianguloValido(double lado1, double lado2, double lado3)
        {
            // La suma de dos lados siempre debe ser mayor que el tercero.
            return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
        }

        static void Main(string[] args)
        {
            double lado1 = Leerlado("Ingrese el valor del lado 1 del triángulo:");
            double lado2 = Leerlado("Ingrese el valor del lado 2 del triángulo:");
            double lado3 = Leerlado("Ingrese el valor del lado 3 del triángulo:");

            // Verificamos si los lados forman un triángulo válido antes de calcular.
            if (EsTrianguloValido(lado1, lado2, lado3))
            {
                double perimetro = CalcularPerimetro(lado1, lado2, lado3);
                Console.WriteLine($"El perímetro del triángulo es: {perimetro}");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
            }

        }
    }
}
