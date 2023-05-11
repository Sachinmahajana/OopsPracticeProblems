using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class FirstletterCapital
    {
        public void FirstLetterCapitalFunction()
        {
            string input = "welcome to the rFP batch";
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 0)
                {
                    string firstLetter = word.Substring(0, 1).ToUpper();
                    string restOfWord = word.Substring(1).ToLower();
                    words[i] = firstLetter + restOfWord;
                }
            }

            string output = string.Join(" ", words);
            Console.WriteLine(output);

        }
    }
}
