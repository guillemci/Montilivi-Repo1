namespace Ex19
{
    internal class Program
    {
<<<<<<< HEAD
        /// <summary>
        /// Fes un programa que demani un número enter positiu n i mostri el següent ( exemple per n=4)
        /// </summary>
        static void Main(string[] args)
        {
            //variable
=======
        static void Main(string[] args)
        {
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int valorusuari = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD
            //bucle
            for (int i = 1; i <= valorusuari; i++)
            {
                //bucle
=======
            for (int i = 1; i <= valorusuari; i++)
            {
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                valor += i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                    if (j < i) Console.Write("+ ");
<<<<<<< HEAD
                    if (j == valorusuari) Console.WriteLine($"= {valor}");
=======
                    if (j == a) Console.WriteLine($"= {valor}");
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                }
                Console.WriteLine();
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
