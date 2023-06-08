using System;
namespace randomgen
{
    class randomnumbers
    {
        static void Main()
        {
            Console.WriteLine("Random number generation");
            Console.WriteLine("How Many numbers should be printed");
            int count = Convert.ToInt32(Console.ReadLine());
            //creating an instance for random class
            Random r = new Random();
            for (int i = 1; i <= count; i++)
            {
                int n1 = r.Next(i);
                Console.Write(n1+" ");
            }

        }
    }
}