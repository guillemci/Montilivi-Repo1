namespace Ex05b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorTeclatPrimer = Convert.ToInt32(Console.ReadLine());
            bool retornat = EsPerfecte(valorTeclatPrimer);

            if (EsPerfecte(valorTeclatPrimer))
            {
                Console.WriteLine(valorTeclatPrimer);
            }
            else
            {
                Console.WriteLine("nuhuh");
            }
        }

        public static bool EsPerfecte(int n)
        {
            int i = 1;
            int j = 0;
            bool passat = false, final = false;

            while (!passat && !final)
            {

                if (n % i == 0)
                    j += i;

                passat = n <= j;
                final = i <= n / 2;

                i++;
            }

            return j == n;
        }
    }
}
