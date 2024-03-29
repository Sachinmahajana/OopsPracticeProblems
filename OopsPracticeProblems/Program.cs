﻿namespace OopsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concept practice problems");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Pattern\n2:FindmaxminArray\n3:SumofDigits\n4:Reversestringeachword\n5:FindDuplicates\n6:Firstletter");
            Console.WriteLine("\n7:Lastlettercapital\n8:Bubblesort\n9:LargestNumber");
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
                case 5:
                    Duplicatenumber myObj3 = new Duplicatenumber();
                    myObj3.DuplicateFunction();
                    break;
                case 6:
                    FirstletterCapital myObj4 = new FirstletterCapital();
                    myObj4.FirstLetterCapitalFunction();
                    break;
                case 7:
                    Lastlettercapital.LastletterCapitalFunction();
                    break;
                case 8:
                    Bubble myObj5 = new Bubble();
                    myObj5.BubbleSort();
                    break;
                case 9:
                    Largestnumber myObj6 = new Largestnumber();
                    myObj6.LargeNumberFunction();
                    break;
                default:
                    Console.WriteLine("Please select program given below");
                    break;
            }
        }
    }
}