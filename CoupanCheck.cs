using System;
namespace LogicalPrograms
{
    public class random
    {
        public void Coupan()
        {
            int num;
            //taking input from user
            Console.WriteLine("Enter Coupon number");
             num = Convert.ToInt32(Console.ReadLine());

            int[] arrOfCoupans = new int[num];
            int countOfLoops=0;
            int numOfCoupans=0;
            int i;

            
            while (numOfCoupans < num)
            {
                Random random = new Random();
                int result = random.Next(10000, 100000);

                for ( i = 0; i < num; i++)
                {
                    if (arrOfCoupans[i] == result)
                    {
                        break;
                    }
                    else
                    {
                        result += arrOfCoupans[i];
                        Console.WriteLine(result);
                        numOfCoupans++;
                    }
                    countOfLoops++;
                    Console.WriteLine("Random number should have distinct numbers :" + numOfCoupans);
                }
                    
            }
        }
    }
}
