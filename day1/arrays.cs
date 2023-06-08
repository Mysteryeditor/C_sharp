using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    class arrays
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number of cars");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the cars");
            string[] cars = new string[size];
            for(int i = 0; i< cars.Length; i++)
            {
                cars[i] = Console.ReadLine();
            }

            Array.Sort(cars);
            string s;
            Console.Write("[");
            for (int j = 0; j < cars.Length; j++)
            {
                
                s = j<cars.Length-1 ? cars[j]+",": cars[j];
                Console.Write(s);
                
            }

            Console.Write("]");

        }
    }
}
