using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class Duplicatenumber
    {
        public void DuplicateFunction()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, };
            

            for(int i = 0; i<array.Length; i++)
            {
                for(int j = i+1; j<array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("Find duplicate:" + array[j]);
                    }
                }
            }

        }
    }
}
