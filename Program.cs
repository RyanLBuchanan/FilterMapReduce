namespace FilterMapReduce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<int> { 3, 10, 6, 1, 4, 8, 2, 5, 9, 7 };

            Console.WriteLine("Original values: ");
            values.Display();

            // Display SQL functions
            Console.WriteLine($"\nMin: {values.Min()}");
            Console.WriteLine($"Max: {values.Max()}");
            Console.WriteLine($"Sum: {values.Sum()}");
            Console.WriteLine($"Average: {values.Average()}");

            Console.WriteLine("\nSum via Aggregate method: " +
                values.Aggregate(0, (x, y) => x + y));

            Console.WriteLine("Sum of squares via Aggregate method: " +
                values.Aggregate(0, (x, y) => x + y * y));

            Console.WriteLine("Product via Aggregate method: " +
                values.Aggregate(0, (x, y) => x * y));

            Console.Write("\nEven values displayed in sorted order: ");
            values.Where(value => value % 2 == 0)
                  .OrderBy(value => value)
                  .Display();

            Console.Write("Odd values multiplied by 10 in sorted order: ");
            values.Where(value => value % 2 != 0)
                  .Select(value => value * 10)
                  .OrderBy(value => value)
                  .Display();

            Console.Write("Original values: ");
            values.Display();
        }
    }

    static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> data)
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}