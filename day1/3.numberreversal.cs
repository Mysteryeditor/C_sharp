//Reverse a Nimber in C#
using System;
namespace reverseNumber
{
    class number
    {
        static void Main()
        {
            int num, rnum = 0, rem=0,originalnum=0;
            Console.WriteLine("Number Reversal");
            Console.WriteLine("Enter the number you want to reverse");
            num = Convert.ToInt32(Console.ReadLine());
            originalnum = num;
            while (num > 0)
            {

                rem = num % 10;
                rnum = rnum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(rnum);

            //palindrom check
            if (originalnum == rnum)
            {
                Console.WriteLine("The reversed number is "+rnum);
                Console.WriteLine("The number " + originalnum + " is a Palindrome");
            }
            else
            {
                Console.WriteLine("The number "+originalnum+" is not a palindrome");
            }

        }
    }
}