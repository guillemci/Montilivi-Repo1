namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calcule la suma del número 1 al número entrat
        /// per l’usuari.
        /// ENTRA UN NÚMERO: 4
        /// 10 //1+2+3+4
        /// </summary>
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //variables
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int a = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD
            //bucle
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            for (int i = 0; i <= a; i++)
            {
                 valor += i;
            }

<<<<<<< HEAD
            //output
            Console.WriteLine($"el resultat es: {valor}");
=======
            Console.WriteLine($"el resultat es:{valor}");
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
        }
    }
}
