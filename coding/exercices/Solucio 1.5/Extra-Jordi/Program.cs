namespace Extra_Jordi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contEnters = 0;
            int contSenar = 0;
            int numeroUsuari = Convert.ToInt32(Console.ReadLine());

            while (numeroUsuari >= 0)
            {
                if (numeroUsuari % 2 == 0)
                {
                    contEnters++;
                }
                else
                {
                    contSenar++;
                }

                numeroUsuari = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"{contSenar} i {contEnters}");
        }
    }
}