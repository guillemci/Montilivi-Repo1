namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani dos números i mostri per pantalla tots els valors compresos entre
        ///aquests dos números.
        ///ENTRA n1: 5
        ///ENTRA n2: 900
        ///5, 6, ………., 900
        /// </summary>
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Aquest programa et mostrara tots els numeros dints un rang");
            Console.WriteLine("entra el primer numero");

            //variables
=======
            Console.WriteLine("entra el primer numero");
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v1cache = v1;

            Console.WriteLine("entra el segon numero");

<<<<<<< HEAD
            //variable i bucle
            for (int v2 = Convert.ToInt32(Console.ReadLine()); v2 >= v1; v1++)
            {
                //comprovador primer recoregut
=======
            for (int v2 = Convert.ToInt32(Console.ReadLine()); v2 >= v1; v1++)
            {
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                if (v1 == v1cache)
                {
                    Console.WriteLine("en aquest rang de numeros introduits hi han els seguents numeros:");
                }
<<<<<<< HEAD

                //output
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                Console.WriteLine(v1);
            }
        }
    }
}