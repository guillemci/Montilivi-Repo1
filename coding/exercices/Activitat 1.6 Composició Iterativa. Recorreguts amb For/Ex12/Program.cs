namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("coordenades2.txt");

            int Radi;
            double x;
            double y;
            int totalinas = Convert.ToInt32(trova.ReadLine());
            string linea = trova.ReadLine();
            Radi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalinas; i++)
            {
                x = Convert.ToDouble(linea);
                Console.WriteLine($"la X proporcionada per el programa es {x}");
                x = Math.Pow(x, 2);
                linea = trova.ReadLine();

                y = Convert.ToDouble(linea);
                Console.WriteLine($"la Y proporcionada per el programa es {y}");
                y = Math.Pow(y, 2);

                string cadenaTornada = Distancia(x, y, Radi);
                Console.WriteLine(cadenaTornada);

                linea = trova.ReadLine();
            }
            trova.Close();
        }

        public static string Distancia(double x, double y, int Radi)
        {
            string cadenaATornar;
            double distancia;
            distancia = x + y;

            distancia = Math.Round(Math.Sqrt(distancia), 2);

            //condicional tractar elements procesats
            if (distancia > Radi) cadenaATornar = ($"el punt {distancia} no es trova dints el perimetre");
            else if (distancia < Radi) cadenaATornar = ($"el punt {distancia} es trova dints el perimetre");
            else cadenaATornar = ($"el punt {distancia} es trova sobre el perimetre");

            return cadenaATornar;
        }
    }
}
