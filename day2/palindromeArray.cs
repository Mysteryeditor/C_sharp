using System;

namespace Palindrome
{
    class PaliArray
    {
        public static void Main()
        {
            int count = 0;
            int[] arr = { 121 ,100,101}; 

            foreach (int a in arr)
            {
                if (isPalinArray(a))
                {
                    count++;
                }
            }

            if (count == arr.Length)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        static bool isPalinArray(int a)
        {
            int revnum = 0;
            int og = a;

            while (a != 0)
            {
                int remainder = a % 10;
                revnum = (revnum * 10) + remainder;
                a = a / 10;
            }

            return (revnum == og);
        }
    }
}



