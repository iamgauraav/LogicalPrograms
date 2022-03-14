using System;
namespace LogicalPrograms
{
    public class random
    {
        public void Coupan()
        {

            //taking input from user
            Console.WriteLine("Enter Coupon number");
            int num = Convert.ToInt32(Console.ReadLine());

            //Using random class
            Random random = new Random();
            int ran = random.Next(num);

            //if - else condition
            if (ran == num)
            {
                Console.WriteLine("coupan number {0} random number {1] " , num ,ran);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("coupan number {0} random number {1} ", num, ran);
                Console.ReadLine();
            }
            
        }
    }
}
