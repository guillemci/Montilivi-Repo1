namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            int xifres = 0;

            while (numero != 0)
            {
                numero = numero / 10;
                xifres++;
            }

            Console.WriteLine(xifres);
        }
    }
}