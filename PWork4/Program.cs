namespace PWork4
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int counterPair = 0;

            int [] array = new int[rand.Next(24, 51)];
            Console.WriteLine($"Length array: {array.Length}");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                if ((array[i] % 2) == 0)
                {
                    counterPair++;
                }
            }

            Console.WriteLine($"Array include {counterPair} pair numbers.");
            Console.Write("It`s: ");
            foreach(int num in array)
            {
                if ((num % 2) == 0)
                {
                    Console.Write(num);
                    counterPair--;
                    Console.Write((counterPair != 0) ? ", " : ". ");
                }
                if (counterPair == 0)
                    break;
            }
            Console.ReadKey();
        }
    }
}
