using System;
namespace multiples
{
    class Three_five
    {
        static void Main(String[] args) {
            int max = 0,sum=0;
            Console.WriteLine("Multiples of Three and Five");
            Console.WriteLine("Enter the Range");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Common Multiples of 3 & 5");
            for (int i = 0; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("The Sum is "+sum);

        }
        
       
    }
}