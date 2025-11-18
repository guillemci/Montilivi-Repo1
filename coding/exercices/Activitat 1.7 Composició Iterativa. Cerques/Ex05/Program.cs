namespace Ex05
{
    //FER EXERCICI AQUEST PERO AMB ELS 4 NUMEROS PRIMERS
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorTeclatPrimer = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int j = 0;
            bool passat = false, final = false;

            /*for (int i = 1; i <= valorTeclatPrimer / 2; i++)
            {
                if (valorTeclatPrimer % i == 0) 
                    j += i;

                if (j >= valorTeclatPrimer) break;
            }*/

            while (!passat && !final)
            {

                if (valorTeclatPrimer % i == 0)
                    j += i;

                passat = valorTeclatPrimer <= j;
                final = i >= valorTeclatPrimer / 2;

                i++;
            }

            if (j == valorTeclatPrimer)
            {
                Console.WriteLine(valorTeclatPrimer);
            }
        }
    }
}
