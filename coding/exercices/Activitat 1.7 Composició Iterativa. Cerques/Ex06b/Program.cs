using static System.Net.Mime.MediaTypeNames;

namespace Ex06b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTeclat = Convert.ToInt32(Console.ReadLine());

            if (EsPrimer(numeroTeclat))
            {
                Console.WriteLine(numeroTeclat);
            }
            else
            {
                Console.WriteLine("no es");
            }

        }


        static bool EsPrimer(int n)
        {
            int cont = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }

            return cont == 2;
        }
    }
}
