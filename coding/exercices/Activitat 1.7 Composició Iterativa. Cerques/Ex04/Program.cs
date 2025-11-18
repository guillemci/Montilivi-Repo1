namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("NUMEROS.txt");
            int numeroUsuari = Convert.ToInt32(Console.ReadLine());
            int lineanum;
            int cont = 0;
            string linea;
            bool trovat = false;

            while ((linea = trova.ReadLine()) != null && !trovat)
            {
                lineanum = Convert.ToInt32(linea);
                trovat = lineanum == numeroUsuari;
                cont++;
            }

            Console.WriteLine(cont);
        }
    }
}
