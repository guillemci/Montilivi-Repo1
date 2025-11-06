namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// Modifica l’anterior programa fent que no es mostrin els números que siguin múltiples de 7
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("entra el primer numero");
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v1cache = v1;

            Console.WriteLine("entra el segon numero");

            for (int v2 = Convert.ToInt32(Console.ReadLine()); v2 >= v1; v1++)
            {
                if (v1 == v1cache)
                {
                    Console.WriteLine("en aquest rang de numeros introduits hi han els seguents numeros:");
                }
                if (v1 % 7 == 0)
                {
                    Console.WriteLine($"{v1} esta en el rang i es multiple de 7");
                }
            }
        }
    }
}
