namespace Ex17
{
    internal class Program
    {
<<<<<<< HEAD
        /// <summary>
        /// Fes un programa que mostri per pantalla totes les taules de multiplicar del 0 al 5.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int taulesAImprimir = 5;
            int numeroDintsTaula = 10;

            Console.WriteLine("aquest programa escriura totes les taules de multiplicar del 0 al 5");

            //bucle niat AKA bucle doble
=======
        static void Main(string[] args)
        {
            int taulesAImprimir = 5;
            int numeroDintsTaula = 10;
            
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            for (int i = 0; i <= taulesAImprimir; i++)
            {
                for (int j = 0; j <= numeroDintsTaula; j++)
                {
                    if (j == 0)
                    {
<<<<<<< HEAD
                        //output
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                        Console.WriteLine($"la taula de multiplicar del {i} es:");
                    }

                    Console.WriteLine(i * j);
                }
            }
        }
    }
}
