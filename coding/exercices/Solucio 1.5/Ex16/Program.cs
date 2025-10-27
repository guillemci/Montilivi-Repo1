namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToInt32(Console.ReadLine());
            a = Math.Pow(a, 2);
            Console.WriteLine(a);

            double b;
            b = Convert.ToInt32(Console.ReadLine());
            b = Math.Pow(b, 2);
            Console.WriteLine(b);

            double resultat;
            resultat = a + b;
            Console.WriteLine(resultat);

            resultat = Math.Sqrt(resultat);

            Console.WriteLine(resultat);
            
        }
    }
}
