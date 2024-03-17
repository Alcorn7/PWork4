namespace PWork4
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            string inputLine;
            char inputChar;
            char lowerRange = (char)32, upperRange = (char)126; // Character Range ASCII ('space' - '~') (#32 - #126) (include a-z)
            int counterChar = 0;

            Console.WriteLine("Hello! It`s a string roulette (and search)");

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

                Console.Write("Enter symbol: ");
                inputChar = Console.ReadKey().KeyChar;
                if (inputChar < lowerRange || inputChar > upperRange) // Check valid search range 
                {
                    Console.WriteLine("\nWrong input! This symbol not supported!  Try again? (y - yes/other сharacter(s) - no)");
                    if (Console.ReadLine() == "y")
                        continue;
                    else break;
                }

                foreach (char c in inputLine.ToLower())
                {
                    if (c == Char.ToLower(inputChar))
                        counterChar++;
                }

                Console.WriteLine($"\nText \"{inputLine}\" include: {inputLine.Length} symbol(s)");
                Console.WriteLine($"Search symbol is \'{inputChar}\', counter: {counterChar} symbol(s)");
                Console.WriteLine("Try again? (y - yes/other сharacter(s) - no)");

                counterChar = 0; // For next try

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
