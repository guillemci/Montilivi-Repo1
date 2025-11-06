namespace Ex15B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter = Convert.ToChar(Console.ReadLine());
            int longitud = Convert.ToInt32(Console.ReadLine());

            string lineaGenerada = GenerarLinea(caracter, longitud);

            Console.WriteLine(lineaGenerada);
        }

        public static string GenerarLinea(char car, int longitud)
        {
            string linea;

            linea = new string(car, longitud);
            return linea;
        }
    }
}
