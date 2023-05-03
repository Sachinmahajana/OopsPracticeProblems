using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class PrintPattern
    {
        public static void PatternFunction()
        {
            for(int i = 1; i <= 8; i++)
            {
                for(int j = i; j <= 8; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
