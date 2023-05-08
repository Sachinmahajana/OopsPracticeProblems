namespace OopsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concept practice problems");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Pattern\n2:FindmaxminArray\n3:SumofDigits\n4:Reversestringeachword");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintPattern.PatternFunction();
                    break;
                case 2:
                    Findmaxmin myObj = new Findmaxmin();
                    myObj.FindMaxMinFunction();
                    break;
                case 3:
                    SumofDigitNumber myObj1 = new SumofDigitNumber();
                    myObj1.SumOfDigitFunction();
                    break;
                case 4:
                    Reversestring myObj2 = new Reversestring();
                    myObj2.ReverseStringFunction();
                    break;
            }
        }
    }
}