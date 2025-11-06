namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int valorusuari = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valorusuari; i++)
            {
                valor += i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                    if (j < i) Console.Write("+ ");
                    if (j == a) Console.WriteLine($"= {valor}");
                }
                Console.WriteLine();
            }
        }
    }
}
