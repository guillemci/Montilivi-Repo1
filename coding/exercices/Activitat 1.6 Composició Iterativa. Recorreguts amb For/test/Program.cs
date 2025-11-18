namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4;

            for (int i = 11; i <= 99; i++)
            {
                valor1 = i % 10;
                Console.WriteLine(valor1);
                valor2 = i / 10;
                Console.WriteLine(valor2);


                valor3 = valor1 + valor2;
                valor4 = valor1 * valor2;

                if (valor3 != 0 && valor4 != 0)
                {
                    if (valor3 % valor4 == 0) Console.WriteLine($"si {i} es");
                    else Console.WriteLine($"no {i} no es");
                }
                else Console.WriteLine($"no {i} no es");

            }
        }
    }
}
