using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class randomnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number Generation");
            Console.WriteLine("How many numbers should be printed?");
            int count = Convert.ToInt32(Console.ReadLine());
            //creating an instance for the random class
            Random r = new Random();
            
            for(int i = 1; i < count; i++)
            {
                int n1 = r.Next(i);//returns a number less than i
                Console.WriteLine(n1);
            }
        }
    }
}
