namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int numeroTeclat = Convert.ToInt32(Console.ReadLine());

           for (int i = 1; i <= numeroTeclat; i++)
           {
                if (numeroTeclat % i == 0)
                {
                    cont++;
                }
           }

           if (cont == 2)
           {
                Console.WriteLine("es primari");
           }
        }
    }
}
