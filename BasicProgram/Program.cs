namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Csharp basic programs");

            Console.WriteLine("Please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator(first, second);
            calculator.Addition();
            Console.ReadLine();
        }
    }
}