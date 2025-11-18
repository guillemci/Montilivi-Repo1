namespace Ex15B
{
    internal class Program
    {
<<<<<<< HEAD
        //el metex que en el exercici anterior pero utilitzant "new string"
=======
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
        static void Main(string[] args)
        {
            char caracter = Convert.ToChar(Console.ReadLine());
            int longitud = Convert.ToInt32(Console.ReadLine());

            string lineaGenerada = GenerarLinea(caracter, longitud);

            Console.WriteLine(lineaGenerada);
        }

<<<<<<< HEAD
        //funcio
        public static string GenerarLinea(char car, int longitud)
        {
            //variable
            string linea;

            //objecte
            linea = new string(car, longitud);
            
            //retorn de la funcio
=======
        public static string GenerarLinea(char car, int longitud)
        {
            string linea;

            linea = new string(car, longitud);
>>>>>>> d77365382e3973784c49ce5bb88fa6f547df8627
            return linea;
        }
    }
}
