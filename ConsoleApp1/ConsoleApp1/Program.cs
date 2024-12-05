namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your first number: ");
            int x = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter your second number: ");
            int y = int.Parse(Console.ReadLine()!);

            DoMath(x, y);
        }
        public static void DoMath(int x, int y)
        {
            int z = x * y;
            Console.WriteLine("Result: " + z);
        }
    }
}
