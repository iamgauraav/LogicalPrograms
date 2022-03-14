using System;

namespace LogicalPrograms
{/// <summary>
/// UC1- Fibonacci Series
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int a = 0;
            int b = 1;
            int c;

            //taking input from user
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            //For loop
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c);

                //swapping a and b
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
