using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day2
{
    class Median
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 20, 59, 41, 90,69 };
            
            findMedian(arr);

        }

        static void findMedian(int[] arr)
        {
            Array.Sort(arr);

            if (arr.Length % 2 != 0)
            {

                int mid = (arr.Length) / 2;
                Console.WriteLine(arr[mid]);
                
            }

            else
            {
                int mid = (arr.Length) / 2;
                int median = arr[mid] + arr[mid - 1];
                Console.WriteLine(median/2);
            }

        }
    }
}
