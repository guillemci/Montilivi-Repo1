namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //variables
            StreamReader trova = new StreamReader("NUMEROS.txt");
            string linea;
            int contPositius = 0, contNegatius = 0;

            linea = trova.ReadLine();
            int numero = Convert.ToInt32(linea);

            //bucle
            while (linea != null)
            {
                //element principal del bucle (numero)

                //condicional per mirar si el numero es positiu
                if (numero > 0)
                {
                    contPositius++;
                }

                //condicional per mirar si el numero es negatiu
                if (numero < 0)
                {
                    contNegatius++;
                }


                linea = trova.ReadLine();
                numero = Convert.ToInt32(linea);
            }

            //output
            Console.WriteLine($"el total de numeros positius contats a sigut de {contPositius}");
            Console.WriteLine($"el total de numeros negatius contats a sigut de {contNegatius}");
        }
    }
}