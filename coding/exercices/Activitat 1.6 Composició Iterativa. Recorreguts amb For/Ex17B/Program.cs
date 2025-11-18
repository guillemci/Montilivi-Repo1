<<<<<<< HEAD
﻿namespace Ex17B
{
    internal class Program
    {
        /// <summary>
        /// Utilitzar el procediment MostrarTaula, que mostri per pantalla la taula de multiplicar d’un número
        ///passat per paràmetre.
        ///public static void MostrarTaula(int numTaula)
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int taulesAImprimir = Convert.ToInt32(Console.ReadLine());

            //funcio
            MostrarTaula(taulesAImprimir);
        }

        //funcio
        public static void MostrarTaula(int numTaula)
        {
            //variable dints funcio
            int numeroDintsTaula = 10;

            //bucle
=======
﻿namespace _17B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taulesAImprimir = Convert.ToInt32(Console.ReadLine());
            MostrarTaula(taulesAImprimir);
        }

        public static void MostrarTaula(int numTaula)
        {
            int numeroDintsTaula = 10;

>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            for (int j = 0; j <= numeroDintsTaula; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine($"la taula de multiplicar del {numTaula} es:");
                }

                Console.WriteLine(numTaula * j);
            }
        }
    }
}
