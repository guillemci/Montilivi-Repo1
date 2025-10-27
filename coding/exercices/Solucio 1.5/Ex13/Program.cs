using System;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random atzar = new Random();
            int valorRandom = atzar.Next(1, 11);

            StreamReader trova = new StreamReader("bonus.txt");
            string linea;
            int i = 0;
            int guanyador = 0;
            int noGuanyador = 0;
            double percentatgeGuanyadors;

            linea = trova.ReadLine();

            while (linea != null)
            {
                i++;
                if (linea == "BONUS")
                {
                    Console.WriteLine($"el numero {i} te un BONUS de {valorRandom = atzar.Next(1, 11)}");
                    guanyador++;
                }
                if (linea == "NO BONUS") 
                {
                    noGuanyador++;
                    Console.WriteLine($"el numero {i} no te bonus");
                }    
                linea = trova.ReadLine();
            }

            percentatgeGuanyadors = i / 100 * guanyador;

            trova.Close();

            Console.WriteLine($"el total de tickets distribuits es de: {i}");
            Console.WriteLine($"el total de tickets guanyadors es de: {guanyador}");
            Console.WriteLine($"el total de tickets no guanyadors es de: {noGuanyador}");


        }
    }
}