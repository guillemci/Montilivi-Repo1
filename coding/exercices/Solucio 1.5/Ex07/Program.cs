namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix un numero");
            int numeroIntroduit = Convert.ToInt32(Console.ReadLine());
            int numeroMesGran = numeroIntroduit;
            int numeroMesPetit = numeroIntroduit;
            int cont = 0;

            while (numeroIntroduit != 0)
            {
                if (numeroMesGran < numeroIntroduit)
                numeroMesGran = numeroIntroduit;

                if (numeroMesPetit > numeroIntroduit)
                {
                    numeroMesPetit = numeroIntroduit;
                }
                cont++;

                Console.WriteLine("introdueix un altre numero");
                numeroIntroduit = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"el programa a parat perque has introduit {numeroIntroduit}, el total de numeros introduits a sigut {cont}, el numero mes gran introduit a sigut {numeroMesGran} i el mes petit {numeroMesPetit}");
        }
    }
}
