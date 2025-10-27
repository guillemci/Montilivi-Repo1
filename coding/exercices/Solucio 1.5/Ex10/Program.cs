namespace Ex10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random atzar = new Random();
            int cont = 0, contNumeros6 = 0, contNumeros1 = 0;
            int valorRandom = atzar.Next(1,7);

            //mentres contnumeros1 no sigui igual a contnumeros6 0 contnumeros1 == 0
            while (contNumeros1 != contNumeros6 || contNumeros1 == 0)
            {
                if (valorRandom == 6) contNumeros6++;
                if (valorRandom == 1) contNumeros1++;
                valorRandom = atzar.Next(1, 7);
                cont++;
            }
            Console.WriteLine($"{contNumeros1}");
            Console.WriteLine($"{contNumeros6}");
            Console.WriteLine($"{cont}");
        }
    }
}