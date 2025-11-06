namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 300; i++)
            {
                if (i % 4 == 0) Console.WriteLine($"{i} es un multiple de 4");
                else Console.WriteLine($"{i} no es un multiple de 4");
                if (i == 20) Console.ReadLine();
            }
        }
    }
}
