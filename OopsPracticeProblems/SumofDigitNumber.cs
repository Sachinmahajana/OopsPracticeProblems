using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class SumofDigitNumber
    {
        int sum = 0, remainder = 0;
        public void SumOfDigitFunction()
        {
            Console.WriteLine("Please provide input number");
            int inputnumber = Convert.ToInt32(Console.ReadLine());
            int backupValue = inputnumber;

            while (inputnumber != 0)
            {
                remainder = inputnumber % 10;
                sum = sum + remainder;
                inputnumber = inputnumber / 10;
            }
            Console.WriteLine("Sum of {0} is {1}", backupValue, sum);
        }
    }
}
