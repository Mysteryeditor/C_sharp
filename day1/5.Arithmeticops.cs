using System;
namespace arithmeticops
{
    class Arith
    {
        static void Main()
        {
            int choice = 0, n1, n2, ans;

            




            while (choice != 5)
            {

                Console.WriteLine();
                Console.WriteLine("***Arithmetic Operations***");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Division");
                Console.WriteLine("2.Multiplication");
                Console.WriteLine("3.Addition");
                Console.WriteLine("4.Subtraction");
                Console.WriteLine("5.Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Thank You");
                    break;
                }


                Console.WriteLine("Enter the First number");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second Number");
                n2 = Convert.ToInt32(Console.ReadLine());


                //creating an if statement for the operations
                if (choice == 1)
                {
                    try
                    {
                        ans = n1 / n2;
                        Console.WriteLine("The Quotient is " + ans);
                        Console.WriteLine("The Remainder is " + (n1 % n2));
                    }
                catch(Exception e)
                    {
                        Console.WriteLine("Division By Zero is Not Possible,Try A Different Number");
                    }
                }

                else if (choice == 2)
                {
                    ans = n1 * n2;
                    Console.WriteLine("The Product is " + ans);
                }

                else if (choice == 3)
                {
                    ans = n1 + n2;
                    Console.WriteLine("The Sum is " + ans);

                }

                else if (choice == 4)
                {
                    ans = n1 - n2;
                    Console.WriteLine("The Difference is " + ans);
                }

                else
                {
                    Console.WriteLine("Wrong Option");
                }

            }

        }
    }
}