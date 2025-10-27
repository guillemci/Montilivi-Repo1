namespace Cosica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader trova = new StreamReader("trova.txt");
            int num;
            int i = 0;
            string linea;

            linea = trova.ReadLine();

            while (linea != null)
            {
                num = Convert.ToInt32(trova.ReadLine());

                i++;

                linea = trova.ReadLine();
            }
            Console.WriteLine(i);
            trova.Close();
        }
    }
}