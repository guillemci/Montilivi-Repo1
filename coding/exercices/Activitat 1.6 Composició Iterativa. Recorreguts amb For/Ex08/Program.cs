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
            //variables
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la multiplicacio dels seus anteriors");
            int a = Convert.ToInt32(Console.ReadLine());

            //bucle
            for (int i = 0; i <= a; i++)
            {
                if (i == 1) valor += i;
                else valor *= i;
            }

            //output
            Console.WriteLine(valor);
        }
    }
}
