namespace OopsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concept practice problems");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Pattern");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintPattern.PatternFunction();
                    break;
            }
        }
    }
}