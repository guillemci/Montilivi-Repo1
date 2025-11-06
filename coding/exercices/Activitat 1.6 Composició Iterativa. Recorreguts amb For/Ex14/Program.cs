using System.Text;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StreamReader trova = new StreamReader("tiquetsuper.txt");

            string nomProducte;
            int quantitatProducte;
            double preuProducte;
            double preufinal = 0;

            int TotalLineas = Convert.ToInt32(trova.ReadLine());
            nomProducte = trova.ReadLine();
            
            for (int i = 0; i < TotalLineas; i++)
            {
                Console.WriteLine(nomProducte);
                quantitatProducte = Convert.ToInt32(trova.ReadLine());
                Console.WriteLine($"quantitat: {quantitatProducte}");
                preuProducte = Convert.ToDouble(trova.ReadLine());
                Console.WriteLine($"preu: {preuProducte}€");
                preufinal += preuProducte;
                nomProducte = trova.ReadLine();
            }
            trova.Close();

            Console.WriteLine($"Preu Final compra: {preufinal}€");
        }
    }
}
