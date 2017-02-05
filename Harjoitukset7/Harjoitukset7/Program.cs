using System;

namespace Harj1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDice();
        }
        static void TestDice()
        {
            double average;
            int timesRolled, result = 0;
            int count1, count2, count3, count4, count5, count6;
            count1 = count2 = count3 = count4 = count5 = count6 = 0;

            Console.Write("How many times do you want to roll the dice?: ");
            timesRolled = int.Parse(Console.ReadLine());
            Dice dice = new Dice();

            for (int i = 1; i <= timesRolled; i++)
            {
                int rolledNumber = dice.Roll();
                switch (rolledNumber)
                {
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                    case 3:
                        count3++;
                        break;
                    case 4:
                        count4++;
                        break;
                    case 5:
                        count5++;
                        break;
                    case 6:
                        count6++;
                        break;
                }
                result = result + rolledNumber;
            }
            average = (double)result/timesRolled;
            Console.WriteLine("Dice is thrown {0} times \n-average is {1}", timesRolled, average);
            Console.WriteLine("- 1 count is {0}\n- 2 count is {1}\n- 3 count is {2}", count1, count2, count3);
            Console.WriteLine("- 4 count is {0}\n- 5 count is {1}\n- 6 count is {2}", count4, count5, count6);
        }
    }
}
