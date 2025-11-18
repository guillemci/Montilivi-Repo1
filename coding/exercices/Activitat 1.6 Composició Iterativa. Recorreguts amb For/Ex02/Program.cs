namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Escriure els 20 primers números parells.
        /// 2, 4, 6,......... 40
        /// </summary>
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //variable
            int comptador = 1;

            //bucle
            for (int i = 1; comptador <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    //output1
=======
            int comptador = 0;
            for (int i = 0; comptador <= 20; i++)
            {
                if (i % 2 == 0)
                {
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                    Console.WriteLine($"el numero {i} es parell");
                    comptador++;
                }
                else
                {
<<<<<<< HEAD
                    //output1
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                    Console.WriteLine($"el numero {i} es imparell");
                }
            }
        }
    }
}
