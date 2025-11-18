<<<<<<< HEAD
﻿using System.Runtime.ConstrainedExecution;
using System.Text;
=======
﻿using System.Text;
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627

namespace Ex14
{
    internal class Program
    {
<<<<<<< HEAD
        /// <summary>
        /// Donat el fitxer tiquetsuper.txt, calcular la el preu total de la compra del tiquet. La primera línia del
        ///fitxer indica el nombre de productes.Després cada producte està format per tres línies (Nom del
        ///producte, Quantitat comprada de producte, Preu unitari del producte). El programa haurà d’indicar el
        ///preu final del tiquet.
        /// </summary>
        static void Main(string[] args)
        {
            //sistema
            Console.OutputEncoding = Encoding.UTF8;

            //objecte
            StreamReader trova = new StreamReader("tiquetsuper.txt");

            //variables
=======
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StreamReader trova = new StreamReader("tiquetsuper.txt");

>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            string nomProducte;
            int quantitatProducte;
            double preuProducte;
            double preufinal = 0;
<<<<<<< HEAD
            int TotalLineas = Convert.ToInt32(trova.ReadLine());

            nomProducte = trova.ReadLine();
            
            //bucles
            for (int i = 0; i < TotalLineas; i++)
            {
                //output
=======

            int TotalLineas = Convert.ToInt32(trova.ReadLine());
            nomProducte = trova.ReadLine();
            
            for (int i = 0; i < TotalLineas; i++)
            {
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                Console.WriteLine(nomProducte);
                quantitatProducte = Convert.ToInt32(trova.ReadLine());
                Console.WriteLine($"quantitat: {quantitatProducte}");
                preuProducte = Convert.ToDouble(trova.ReadLine());
                Console.WriteLine($"preu: {preuProducte}€");
<<<<<<< HEAD
                Console.WriteLine($"preu unitari: {Math.Round(preuProducte / quantitatProducte,2)}€");
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
                preufinal += preuProducte;
                nomProducte = trova.ReadLine();
            }
            trova.Close();

<<<<<<< HEAD
            //output
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            Console.WriteLine($"Preu Final compra: {preufinal}€");
        }
    }
}
