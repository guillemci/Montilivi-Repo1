namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("Girona lliga23_24.txt");

            int goolRival = 0, goolGirona = 0;
            int puntsTotals = 0;
            int partitsGuanyants = 0, partitsPerduts = 0, partitsEnpatats = 0;
            string linea = trova.ReadLine();

            if (linea != null)
            {
                goolRival = Convert.ToInt32(linea);
                linea = trova.ReadLine();
            }

            while ()
            {
                
            }
        }
    }
}
