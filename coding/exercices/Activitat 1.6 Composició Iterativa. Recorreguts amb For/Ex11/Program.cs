namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("BONUS3.txt");

            double valorGuanyBonus = 0;
            int totalAmbBonus = 0;

            int totalBitllets = Convert.ToInt32(trova.ReadLine());
            string numerolineas = trova.ReadLine();

            for (int i = 0; i < totalBitllets; i++)
            {
                if (numerolineas == "BONUS")
                {
                    double valor = Convert.ToDouble(trova.ReadLine());
                    valorGuanyBonus += valor;
                    totalAmbBonus++;
                    Console.WriteLine($"el bonus numero {i + 1} te un bonus de {valor}");
                }
                else if (numerolineas == "NO BONUS")
                {
                    Console.WriteLine($"el bitllet numero {i + 1} no te bonus");
                }

                numerolineas = trova.ReadLine();
            }
            trova.Close();

            double percent = (double)totalAmbBonus / totalBitllets * 100;

            Console.WriteLine($"el total de bitllets a sigut de {totalBitllets}");
            Console.WriteLine($"el total de bitllets guanyadors distributs a sigut de {totalAmbBonus}");
            Console.WriteLine($"el percentatge de bitllets guanyadors a sigut de {percent}");
            Console.WriteLine($"el total guanyat a sigut de {valorGuanyBonus}");

        }
    }
}
