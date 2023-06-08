using System;
namespace Sumofdigits
{
    class Addition
    {
        static void Main()
        {
            int n,sum,sum2=0;
            Console.WriteLine("Enter THe Range value ");
            n = Convert.ToInt32(Console.ReadLine());

            //using formula
            sum = n * (n + 1) / 2;
            Console.WriteLine("The sum is "+sum);

            //using for loop
            for (int i = 1; i <= n; i++)
            {
                sum2 = sum2 + i;
            }
            Console.WriteLine("The Sum found using Loop is "+sum2);
        }
    }
}