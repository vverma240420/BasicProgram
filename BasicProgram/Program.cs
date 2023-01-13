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

            Calculator calculator1 = new Calculator(first, second);
            calculator1.Addition();
            Console.ReadLine();


            Console.WriteLine("Please enter third number");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter fourth number");
            int fourth = Convert.ToInt32(Console.ReadLine());


            Calculator calculator2 = new Calculator(third, fourth);
            calculator2.Substraction();
            Console.ReadLine();
        }
    }
}