namespace Ex16
{
    internal class Program
    {
<<<<<<< HEAD
        /// <summary>
        /// Fes un programa que demani a l’usuari un número i que mostri una piràmide.
        ///NTRA UN NÚMERO: 4
        ///*
        ///**
        ///***
        ///****
        /// </summary>
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
        static void Main(string[] args)
        {
            //int k = 0;
            int j = 0;
<<<<<<< HEAD
            //bucle
            Console.WriteLine("introdueix aqui la longitud de la mitja piramide");
=======
            // i se li posa un valor i mira que j no sigui mes gran, en aquell cas ++j
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            for (int i = Convert.ToInt32(Console.ReadLine()); j <= i; j++)
            {
                //j pasa a ser 1 per tant k a d'arribar a 1 printeja 1
                //j pasa a ser 2 per tant k a d'arribar a 2 printeja 2
<<<<<<< HEAD

                //bucle niat AKA doble bucle
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                for (int k = 0; k < j; k++)
                {
                    Console.Write("*");
                }

                //fa la nova linea
                Console.WriteLine();

                //també es pot fer amb aquest objecte
                /* 
                string tabs = new string('*', j);
                Console.WriteLine(tabs);
                */
            }
        }
    }
}
