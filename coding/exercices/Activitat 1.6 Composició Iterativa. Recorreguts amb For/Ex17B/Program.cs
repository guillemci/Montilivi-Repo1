namespace _17B
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
