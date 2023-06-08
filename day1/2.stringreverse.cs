using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Stringrev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversing String");
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            Console.WriteLine("The string is " + str);
            Console.Write("The reversedString is "); ;
            for (int i = str.Length-1; i >= 0; i--)
            {
                
                Console.Write(str[i]);
                
            }

            Console.WriteLine();
           
        }
    }
}