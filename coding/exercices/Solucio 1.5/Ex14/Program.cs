namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("BONUS2.txt");
            string linea;
            int i = 0;

            linea = trova.ReadLine();

            while (linea != null)
            {
                i++;

                if (linea != "BONUS" && linea != "NO BONUS")
                {
                    Console.WriteLine($"el bonus del ticket es de {linea}");
                }

                

                if (linea == "NO BONUS")
                    Console.WriteLine(linea);

                linea = trova.ReadLine();
            }
            trova.Close();
        }
    }
}