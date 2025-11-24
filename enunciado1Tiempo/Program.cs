using System;
namespace enunciado1Tiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcula el tiempo de una ciudad a otra 

            float kilometros = 0;
            float velocidad = 0;
            bool entradaValida = false;

            

            Console.WriteLine("Ingrese la ciudad de partida:");
            string? ciudadPartida = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad de destino:");
            string? ciudadDestino = Console.ReadLine();
            // Solicitar distancia
            do
            {
                Console.WriteLine("Ingrese la distancia en kilometros entre las dos ciudades:");
                entradaValida = float.TryParse(Console.ReadLine(), out kilometros);
                if (!entradaValida || kilometros <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un valor valido para la distancia.");
                }

            } while (!entradaValida || kilometros <= 0);

            // Solicitar velocidad
            entradaValida = false;
            do
            {
                Console.WriteLine("Ingrese la velocidad promedio en km/h:");
                entradaValida = float.TryParse(Console.ReadLine(), out velocidad);
                if (!entradaValida || velocidad <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un valor valido para la velocidad.");
                }

            } while (!entradaValida || velocidad <= 0);

            //Calcular horas enteras 
            float tiempoTotalhoras = kilometros / velocidad;
            //Calcular horas enteras 
            int horas = (int)Math.Floor(tiempoTotalhoras);
            //Calcular minutos
            float minutosTotales = (tiempoTotalhoras - horas) * 60;
            int minutos = (int)Math.Floor(minutosTotales);
            //Calcular segundos
            float segundosTotales = (minutosTotales - minutos) * 60;
            int segundos = (int)Math.Round(segundosTotales);

            Console.WriteLine($"El tiempo estimado de viaje desde {ciudadPartida} hasta {ciudadDestino} es de {horas} horas, {minutos} minutos y {segundos} segundos.");

        }
    }
}