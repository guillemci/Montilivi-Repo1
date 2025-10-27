namespace extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bucle for

            int i = 0;

            for (int x = 1; x <= 40; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);

                    i++;

                    if (i != 10)
                    {
                        x = 40;
                    }
                }
            }
        }
    }
}