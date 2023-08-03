using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class Bubble
    {
        public void BubbleSort()
        {
            int[] arr = { 27, 16, 44, 10, 7 };
            int temp;

            for (int i = 0; i < 5 - 1; i++)
            {
                for (int j = 0; j < 5 - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    
                }
            }
            for(int j= 0; j<5; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
    
      

