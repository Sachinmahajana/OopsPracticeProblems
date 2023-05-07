using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblems
{
    internal class Findmaxmin
    {
        public void FindMaxMinFunction()
        {
            int[] arr = new int[7];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 25;
            arr[3] = 30;
            arr[4] = 35;
            arr[5] = 40;
            arr[6] = 45;

            int maxValue = arr[0];
            int minValue = arr[0];
            for(int i = 0; i< arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine("Maxvalue is:" + maxValue );
            Console.WriteLine("Minvalue is:" + minValue);
        }
    }
}
