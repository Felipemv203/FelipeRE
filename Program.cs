using System;

namespace Obraspublicas
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para simular el proceso de reparación de los tramos de las calles");
            Console.WriteLine("Los deterioros en los tramos pueden ser por hundimientos, agrietamientos y ondulaciones.  ");
            Console.WriteLine("Las calles a intervenir tienen una longitud entre 100 y 500 metros.");
            Console.WriteLine("os tramos tienen una longitud relativa entre el 20 y el 60% de la calle.  ");

            int Cantidadcalles = 0;
            bool datoCorrecto = false;

            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\ncual es la cantidad de calles ");
                    Cantidadcalles = int.Parse(Console.ReadLine()!);

                    if (Cantidadcalles >= 100 && Cantidadcalles <= 500  )
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser entre 100 y 500");
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("La cantidad debe ser un numero entre 100 y 500");
                    Console.WriteLine(elError.Message);
                }
            }

            string[] losdeterioros = { "hundimientos", "agrietamientos" , "ondulaciones" };


            Random aleatorio = new Random();

            Calle[] callespublicas = new Calle[Cantidadcalles];

            for (int i = 0; i < callespublicas.Length; i++)
            {

                callespublicas[i] = new Calle();


                callespublicas[i].tipodeterioro = losdeterioros[aleatorio.Next(losdeterioros.Length)];
            }

            VisualizaInformacionCalles(callespublicas);

            Console.WriteLine("\n Los totales de Calles por deterioros son:");
            float[] totalesCallespordeterioro = Totalizacallespordeterioro(callespublicas, losdeterioros);

            for (int i = 0; i < losdeterioros.Length; i++)
                Console.WriteLine($"Medio: {losdeterioros[i]}, " +
                    $"Total Animales: {totalesCallespordeterioro[i]} que equivale al" +
                    $" {((totalesCallespordeterioro[i] / Cantidadcalles) * 100).ToString(".00")}%");


        }

        static void VisualizaInformacionCalles(Calle[] Obraspublicas)
        {
            Console.WriteLine("\nLas calles con deterioros son:");

            int contador = 1;
            foreach (Calle Lacalle in Obraspublicas)
            {
                Console.WriteLine($"\nCalle No. {contador}, \n" +
                    $"Tipo de deterioro{Lacalle.TipoCalle} {Lacalle.tipodeterioro} \n");
                contador++;
            }
        }

        static float[] Totalizacallespordeterioro(Calle[] Lascalles, string[] Losdeterioros)
        {
            float[] totalesPordeterioro = new float[Losdeterioros.Length];

            for (int i = 0; i < Losdeterioros.Length; i++)
            {
                for (int j = 0; j < Lascalles.Length; j++)
                {
                    if (Lascalles[j].tipodeterioro == Losdeterioros[i])
                        totalesPordeterioro[i]++;
                }
            }

            return totalesPordeterioro;
        }


        }
    }
