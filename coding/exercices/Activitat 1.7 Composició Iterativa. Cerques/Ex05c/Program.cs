namespace Ex05c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("PERFECTES.txt");
            int i = 1;
            int j = 0;
            int lineaNum;
            string linea;
            bool passat = false, final = false;

            while ((linea = trova.ReadLine()) != null)
            {
                lineaNum = Convert.ToInt32(linea);
                while (!passat && !final)
                {
                    if (lineaNum % i == 0)
                        j += i;

                    passat = lineaNum <= j;
                    final = i >= lineaNum / 2;

                    i++;
                }

                if (j == lineaNum)
                {
                    Console.WriteLine(lineaNum);
                }

                passat = false;
                final = false;
                j = 0;
                i = 1;
            }
        }
    }
}
