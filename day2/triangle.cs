using System;
namespace triangle
{
    class CheckingTriangle
    {
        public static void Main()
        {
            Console.WriteLine("Triangle checking");
            Console.WriteLine("Enter the First Side Of the Triangle");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second Side Of the Triangle");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Third Side Of the Triangle");
            double s3 = Convert.ToDouble(Console.ReadLine());

            double x = s1 * s1, y = s2 * s2, z=s3*s3 ;



            if (s1 == s2 && s2 == s3)
            {
                Console.WriteLine("Its an Equilateral Triangle");
            }

            else if (s1==s2||s2==s3)
            {
                Console.WriteLine("Its an Isoceles Triangle");
            }

            else if(x==(y+z)||y==(x+z)||z==(x+y))
            {
                Console.WriteLine("Its a Right Triangle");

            }

            else if (s1 != s2 && s1 != s3)
            {
                Console.WriteLine("Its a scalene Triangle");
            }
        }
    }
}