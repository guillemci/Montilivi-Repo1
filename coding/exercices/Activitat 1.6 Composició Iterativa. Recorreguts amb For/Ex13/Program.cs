namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("Girona lliga23_24_v2.txt");


            int golRival = 0, golGirona = 0;
            int puntsTotals = 0;
            int partitsGuanyants = 0, partitsPerduts = 0, partitsEmpatats = 0;

            int TotalLineas = Convert.ToInt32(trova.ReadLine());
            string linea = trova.ReadLine();

            golRival = Convert.ToInt32(linea);
            linea = trova.ReadLine();

            for (int i = 0; i < TotalLineas; i++)
            {

                    golGirona = Convert.ToInt32(linea);

                    if (golGirona > golRival)
                    {
                        partitsGuanyants++;
                        puntsTotals += 3;
                    }
                    else if (golGirona < golRival) partitsPerduts++;
                    else
                    {
                        partitsEmpatats++;
                        puntsTotals += 1;
                    }

                    linea = trova.ReadLine();
                    golRival = Convert.ToInt32(linea);
                    linea = trova.ReadLine();
            }
            trova.Close();

            //output
            Console.WriteLine($"el total de partits que han guanyat el Girona es de: {partitsGuanyants}");
            Console.WriteLine($"el total de partits que han perdut el Girona es de: {partitsPerduts}");
            Console.WriteLine($"el total de partits que han enpatat el Girona es de es de: {partitsEmpatats}");
            Console.WriteLine($"el total de punts fets del Girona es de {puntsTotals}");

        }
    }
}
