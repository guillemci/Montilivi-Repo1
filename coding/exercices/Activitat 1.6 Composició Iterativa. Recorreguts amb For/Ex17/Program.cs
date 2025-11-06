namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taulesAImprimir = 5;
            int numeroDintsTaula = 10;
            
            for (int i = 0; i <= taulesAImprimir; i++)
            {
                for (int j = 0; j <= numeroDintsTaula; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"la taula de multiplicar del {i} es:");
                    }

                    Console.WriteLine(i * j);
                }
            }
        }
    }
}
