namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Escriure els 20 primers números parells.
        /// 2, 4, 6,......... 40
        /// </summary>
        static void Main(string[] args)
        {
            int comptador = 0;
            for (int i = 0; comptador <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"el numero {i} es parell");
                    comptador++;
                }
                else
                {
                    Console.WriteLine($"el numero {i} es imparell");
                }
            }
        }
    }
}
