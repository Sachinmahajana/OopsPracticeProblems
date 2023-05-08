using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class Reversestring
    {
        public void ReverseStringFunction()
        {
            // Taking the input from user
            Console.WriteLine("Enter the input string");
            string input = Console.ReadLine();
             // create char array and string input convert into TocharArray
            char[] chars = input.ToCharArray();
            int length = chars.Length;
            //print the input length
            Console.WriteLine("string length is:" + length);

            for(int i = length-1; i>=0; i--)
            {
                Console.Write(chars[i]);
            }
        }
    }
}
