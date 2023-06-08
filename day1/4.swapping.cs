//4. Swap Program in C#.
using System;
namespace swapping
{
    class Swapnum
    {
        static void Main()
        {
            int n1, n2, temp;
            Console.WriteLine("Swapping Numbers");
            Console.WriteLine("Enter the 1st number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping");
            Console.WriteLine("n1="+n1);
            Console.WriteLine("n2=" + n2);

            //swapping the digits using a temporary variable temp
            //temp = n1;
            //n1 = n2;
            //n2 = temp;

            //swapping without third variable
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Console.WriteLine("After Swapping");
            Console.WriteLine("n1=" + n1);
            Console.WriteLine("n2=" + n2);

        }
    }
}