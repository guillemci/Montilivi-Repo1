namespace extras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorMinimDescompte = 2;
            double totalDescompte = 0.10;

            Console.WriteLine("introdueix el preu inicial en euros (s'aplicara un descompte del 10% en cas de que el preu no sigui inferior a 2 euros)");
            double preuInicial = Convert.ToDouble(Console.ReadLine());
            double DescompteCalculat = preuInicial * totalDescompte;


            if (preuInicial >= valorMinimDescompte)
            {
                Console.WriteLine(preuInicial-DescompteCalculat);
            }
        }
    }
}
