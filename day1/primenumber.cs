using System;
namespace primenumber
{
    class Prime
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            bool flag=false ;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag=true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("not p");
            }
            else
            {
                Console.WriteLine("prime");
            }
        }
    }
}