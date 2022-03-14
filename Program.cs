using System;

namespace LogicalPrograms
{/// <summary>
/// UC4- Reverse a Number
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int rev=0;
            int rem = 0;

            //taking input from user
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

         
            while (num > 0)
            {
                num = num / 10;
                rem= num % 10;
                rev = (rev * 10) + num;
            }
            Console.WriteLine("The reverse of the given number is:" + rev);
            Console.ReadLine();
        }
    }
}
