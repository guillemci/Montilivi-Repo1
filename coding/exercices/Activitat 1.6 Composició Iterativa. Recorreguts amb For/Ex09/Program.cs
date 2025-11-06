namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorUsuari = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i * valorUsuari);
            }
        }
    }
}
