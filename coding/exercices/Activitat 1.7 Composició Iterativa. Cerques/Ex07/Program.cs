namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("TROBAT.txt");
            StreamReader trova2 = new StreamReader("PERDUT.txt");
            int numeroPerdut = Convert.ToInt32(Console.ReadLine());
            string busquedaNumeroString;
            string busquedaNumeroString2;
            int busquedaNumero;
            int busquedaNumero2;
            int cont = 0;
            bool trovat = false;
            bool trovat2 = false;

            while ((busquedaNumeroString = trova.ReadLine()) != null && !trovat)
            {
                busquedaNumero = Convert.ToInt32(busquedaNumeroString);
                trovat = numeroPerdut == busquedaNumero;
                cont++;
            }

            if (trovat)
            {
                Console.WriteLine("A");
                Console.WriteLine(cont);
            }
            else
            {
                while ((busquedaNumeroString2 = trova2.ReadLine()) != null && !trovat2)
                {
                    busquedaNumero2 = Convert.ToInt32(busquedaNumeroString2);
                    trovat2 = numeroPerdut == busquedaNumero2;
                }

                if (trovat2)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    Console.WriteLine("no hay, no existe");
                }
            }
        }
    }
}
