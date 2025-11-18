namespace Ex18
{
    internal class Program
    {
<<<<<<< HEAD
        /// <summary>
        /// Fes un programa que mostre una piràmide de números com la següent
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int valor = 5;

            //bucle
            for (int i = 0; i < valor; i++)
            {
                //bucle niat AKA doble bucle
                for (int k = valor; i < k; k--)
=======
        static void Main(string[] args)
        {
            int valor = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int k = 5; i < k; k--)
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                {
                    Console.Write(" ");
                }

<<<<<<< HEAD
                //bucle niat AKA doble bucle
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{1 + j} ");
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
