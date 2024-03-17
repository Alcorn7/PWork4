namespace PWork4
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            string inputLine;

            Console.WriteLine("Hello! It`s a string roulette");

            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("Enter text: ");
                inputLine = Console.ReadLine();
                if (string.IsNullOrEmpty(inputLine))
                {
                    Console.WriteLine("Wrong input! Try again? (y - yes/other сharacter(s) - no)");
                    if (Console.ReadLine() == "y")
                        continue;
                    else break;
                }
            
                Console.WriteLine($"\nText \"{inputLine}\" include: {inputLine.Length} symbol(s)");

                Console.WriteLine("Try again? (y - yes/other сharacter(s) - no)");
                if (Console.ReadLine() == "y")
                    continue;
                else break;

            }


            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
