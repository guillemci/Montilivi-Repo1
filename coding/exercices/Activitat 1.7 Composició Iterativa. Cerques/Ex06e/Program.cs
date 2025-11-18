namespace Ex06e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosATrovar = Convert.ToInt32(Console.ReadLine());
            int trovats = 0;
            int cont = 0;
            int i = 0;

            while (trovats != numerosATrovar)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    trovats++;
                    Console.WriteLine($"{i} es primari");
                }

                i++;
                cont = 0;
            }
        }
    }
}
