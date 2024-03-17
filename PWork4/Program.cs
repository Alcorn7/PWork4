namespace PWork4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            int firstChar = 'a', lastChar = 'z'; // range

            string charArray = ""; // one-dimensional array of symbols

            for (int i = firstChar; i <= lastChar; i++)
            {
                charArray += (char)i;
            }

            Console.WriteLine("\n\t\t    ASCII Table (a-z)\n");
            foreach (char c in charArray)
            {
                Console.Write($"\'{c}\' - ASCII: {(int)c:D3}  | ");
                if (c % 3 == 0)
                    Console.WriteLine("\n-----------------------------------------------------------");
            }


            Console.ReadKey();
        }
    }
}
