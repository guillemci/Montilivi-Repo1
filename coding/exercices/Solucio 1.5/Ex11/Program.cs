namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random atzar = new Random();
            int resultatDiferentsOperacions;
            int usuariEndivina;
            int puntuacioCorrectes = 0;
            int i = 0;
            int j = 0;

            while (puntuacioCorrectes != 4)
            {
                //atzar.Next(1, 101)
                int valorRandom1 = 2;
                int valorRandom2 = 2;

                Console.WriteLine($"els numeros generats aleatoriament son els seguents: valor1:{valorRandom1} i valor2:{valorRandom2}");

                Console.WriteLine("fes la suma");
                resultatDiferentsOperacions = valorRandom1 + valorRandom2;
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                Console.WriteLine("fes la resta");
                resultatDiferentsOperacions = valorRandom1 - valorRandom2;
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                Console.WriteLine("fes la multiplicacio");
                resultatDiferentsOperacions = valorRandom1 * valorRandom2;
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                Console.WriteLine("fes la divisio");
                resultatDiferentsOperacions = valorRandom1 / valorRandom2;
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                if (resultatDiferentsOperacions == 4)
                {
                    puntuacioCorrectes = 0;
                    Console.WriteLine($"has fet una puntuacio de {puntuacioCorrectes} n'has de fer 4, torna-ho a fer");
                    j++;
                }
            }

            Console.WriteLine("good boy tot very good");
            Console.WriteLine($"iteracions necesitades {j}");
        }
    }
}



