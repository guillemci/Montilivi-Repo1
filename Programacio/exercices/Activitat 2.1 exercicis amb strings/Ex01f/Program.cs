using System.Text;

namespace Ex01f
{
    /// <summary>
    /// 1f) Escriu una funció que retorna true si la cadena data és un palíndrom. Per exemple, "racecar" és
    /// un palíndrom.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            if (IsPalindrome(data))
                Console.WriteLine($"El text {data} es tracta d'un palindrom");
        }

        public static bool IsPalindrome(string data)
        {
            data = data.ToLower();
            StringBuilder datareverse = new StringBuilder();

            for (int i = data.Length - 1; i >= 0; i--)
                datareverse.Append(data[i]);

            string reverse = datareverse.ToString();

            return (reverse == data);
        }
    }
}
