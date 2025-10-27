namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("alumnesDAMDAW.txt");
            string linea;
            int i = 0;
            int contAlex = 0;
            int contIker = 0;

            linea = trova.ReadLine();

            while (linea != null)
            {
                i++;
                if (linea == "Alex") contAlex++;
                linea = trova.ReadLine();
                if (linea == "Iker") contIker++;
            }
            Console.WriteLine(i);
            trova.Close();

            Console.WriteLine(contAlex);
            Console.WriteLine(contIker);
        }
    }
}
