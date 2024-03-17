namespace PWork4
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50]; 
            
            for (int i = 1; i <= numbers.Length; i++)
                numbers[i-1] = i * 2;

            foreach (int num in numbers)
                Console.WriteLine($"Element: {num}");

            Console.ReadKey();
        }
    }
}
