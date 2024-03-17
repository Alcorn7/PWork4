namespace PWork4
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            
            int [] array = new int[rand.Next(24, 51)];
            Console.WriteLine(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }

            Console.ReadKey();
        }
    }
}
