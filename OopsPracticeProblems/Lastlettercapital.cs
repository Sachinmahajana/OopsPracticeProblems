using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class Lastlettercapital
    {
        public static void LastletterCapitalFunction()
        {
            Console.WriteLine("Enter the input");
            string input = Console.ReadLine();

            string[] array = input.Split(' ');
            for(int i = 0; i<array.Length; i++)
            {
                string word = array[i];
                string first = word.Substring(0, word.Length - 1);
                string last = word.Substring(word.Length - 1).ToUpper();
                Console.Write(first + last + " ");
            }
        }

    }
}
