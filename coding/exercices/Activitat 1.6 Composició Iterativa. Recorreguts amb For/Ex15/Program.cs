namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani a l’usuari un número i que mostri un quadrat.
        ///ENTRA UN NÚMERO: 4
        ///****
        ///****
        ///****
        ///****
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int j = 0;

            Console.WriteLine("introdueix el numero de lineas que vols que tingui el quadrat/rectangle");
            //bucle
            for (int i = Convert.ToInt32(Console.ReadLine()); j < i; j++)
            {
                //output
                Console.Write("****");
                Console.WriteLine();
            }
        }
    }
}
