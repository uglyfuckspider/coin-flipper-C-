using System;

namespace Flip_a_coid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coid flipper downloaded");
            Console.WriteLine("Please enter how many times flip a coin");
            uint flipTimes = uint.Parse(Console.ReadLine());
            uint flipTimesDone = 0;
            uint eagleSideTimes = 0;
            uint tailsSideTimes = 0;
            Random x = new Random();
            while (flipTimesDone <= flipTimes)
            {
                ++flipTimesDone;
                int coinSide = x.Next(3);
                if (coinSide == 1)
                {
                    ++eagleSideTimes;
                }    
                if(coinSide == 2)
                {
                    ++tailsSideTimes;
                }  
            }
            Console.WriteLine("Eagle side dropt: " + eagleSideTimes + "times");
            Console.WriteLine("Tails side dropt: " + tailsSideTimes + "times");
            Console.ReadLine();
        }

    }
}
