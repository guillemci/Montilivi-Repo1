namespace Ex06c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trovar = new StreamReader("ALGUNSPRIMERS.txt");
            string linea;
            int cont = 0;
            int numLinea;

            while ((linea = trovar.ReadLine()) != null)
            {
                numLinea = Convert.ToInt32(linea);

                for (int i = 1; i <= numLinea; i++)
                {
                    if (numLinea % i == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine($"{numLinea} es primari");
                }

                cont = 0;
            }
        }
    }
}
