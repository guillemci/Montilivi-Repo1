namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trovar = new StreamReader("NUMEROS.TXT");

            int lineaNumero = 0;
            string linea;
            bool trobat = false;

            while ((linea = trovar.ReadLine()) != null && !trobat)
            {
                lineaNumero = Convert.ToInt32(linea);
                trobat = lineaNumero % 2 == 0;
            }

            if (trobat) Console.WriteLine($"{lineaNumero}");
            else Console.WriteLine("hola");
        }
    }
}
