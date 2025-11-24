using System;

namespace areaRectangulo
{
    class Program
    {
        //Creamos un metodo para leer números con validación de entrada
        static double LeerNumero(string mensaje)
        {
            double numero;
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

        // Creamos un método específico para calcular el área.
        static double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            return baseRectangulo * alturaRectangulo;
        }

        static void Main(string[] args)
        {
            //Usamos el método para leer la base y la altura del rectángulo
            double baseRectangulo = LeerNumero("Ingrese la base del rectángulo:");
            double alturaRectangulo = LeerNumero("Ingrese la altura del rectángulo:");

            // Llamamos al nuevo método para realizar el cálculo.
            double areaRectangulo = CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
            
            Console.WriteLine($"El área del rectángulo es: {areaRectangulo}");
        }
    }
}