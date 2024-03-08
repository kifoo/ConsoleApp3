namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number of items:");
                    int number = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the seed:");
                    int seed = int.Parse(Console.ReadLine());

                    Problem Backpack = new Problem(number, seed);

                    Console.WriteLine("Enter the capacity:");
                    int capacity = int.Parse(Console.ReadLine());

                    Backpack.Solve(capacity);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            
        }
    }
}
