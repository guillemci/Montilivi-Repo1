namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int k = 0;
            int j = 0;
            // i se li posa un valor i mira que j no sigui mes gran, en aquell cas ++j
            for (int i = Convert.ToInt32(Console.ReadLine()); j <= i; j++)
            {
                //j pasa a ser 1 per tant k a d'arribar a 1 printeja 1
                //j pasa a ser 2 per tant k a d'arribar a 2 printeja 2
                for (int k = 0; k < j; k++)
                {
                    Console.Write("*");
                }

                //fa la nova linea
                Console.WriteLine();

                //també es pot fer amb aquest objecte
                /* 
                string tabs = new string('*', j);
                Console.WriteLine(tabs);
                */
            }
        }
    }
}
