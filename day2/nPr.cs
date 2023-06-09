using System;
namespace permutation
{
    class Npr
    {
        static void Main()
        {
            int n = 3,r = 2;
            nPr(n, r);
        }

       static void nPr(int n,int r) {
            int answer = Factorial(n) / Factorial(n - r);
            Console.WriteLine(answer);
        }

         static int Factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <=n; i++)
            {
                fact *= i;
                
            }
            return fact;
        }
    }
}