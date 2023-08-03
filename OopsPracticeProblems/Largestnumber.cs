using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class Largestnumber
    {
        public void LargeNumberFunction()
        {
            int[] arr = { 10, 34, 43, 12, 33 };
            int i = 1;
            int max = arr[0];
            

            while (i < arr.Length)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                i++;
            } 
            Console.WriteLine("The largest number in array" + max);
            

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
        }
    }
}
