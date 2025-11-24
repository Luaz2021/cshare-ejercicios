using System;
namespace enunciado2Media
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int nota1 = LeerNumero("Ingrese la primera nota:");
            int nota2 = LeerNumero("Ingrese la segunda nota:");
            int nota3 = LeerNumero("Ingrese la tercera nota:");

            double media = (nota1 + nota2 + nota3) / 3.0;
            Console.WriteLine($"Tu media es: {media}");
            Console.WriteLine(Condicion(media));
        }
            
        static int LeerNumero(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero >= 0 && numero <= 10)
                    {
                        return numero;
                    }
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entre 0 y 10.");
                }
            }
        }

        static string Condicion(double media)
        {
            if (media >= 5)
            {
                return "Estas aprobado";
            }
            else
            {
                return "Estas desaprobado";
            }
        }
    }
}
