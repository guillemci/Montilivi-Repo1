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
<<<<<<< HEAD
            //variables
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la multiplicacio dels seus anteriors");
            int a = Convert.ToInt32(Console.ReadLine());

            //bucle
=======
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int a = Convert.ToInt32(Console.ReadLine());

>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            for (int i = 0; i <= a; i++)
            {
                if (i == 1) valor += i;
                else valor *= i;
            }

<<<<<<< HEAD
            //output
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            Console.WriteLine(valor);
        }
    }
}
