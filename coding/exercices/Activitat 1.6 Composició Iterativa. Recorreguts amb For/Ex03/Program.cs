namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani dos números i mostri per pantalla tots els valors compresos entre
        ///aquests dos números.
        ///ENTRA n1: 5
        ///ENTRA n2: 900
        ///5, 6, ………., 900
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
                Console.WriteLine(v1);
            }
        }
    }
}