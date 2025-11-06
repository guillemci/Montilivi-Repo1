namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calcule el producte del número 1 al numero
        /// entrat per l’usuari.
        /// </summary>
        static void Main(string[] args)
        {
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= a; i++)
            {
                if (i == 1) valor += i;
                else valor *= i;
            }

            Console.WriteLine(valor);
        }
    }
}
