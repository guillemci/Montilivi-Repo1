namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS2.TXT.
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            double resultat;
            int i = 0;
            double numerosAcomulats = 0;

            
            int numeroIntroduit = ;

            //bucle
            while (numeroIntroduit != 0)
            {
                numerosAcomulats += numeroIntroduit;
                i++;
                numeroIntroduit = Convert.ToInt32(Console.ReadLine());
            }
            //calcul
            resultat = numerosAcomulats / i;

            //output
            Console.WriteLine(resultat);
        }
    }
}
