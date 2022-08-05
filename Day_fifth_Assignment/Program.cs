using System;

namespace Day_fifth_Assignment
{
    public class Program
    {
        void FlipCoin()
        {
            Console.WriteLine("Enter How many times to flip coin");
            double n = Double.Parse(Console.ReadLine());


            int h_count = 0;
            int t_count = 0;

            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();
                int head_or_tail = random.Next(0, 2);
                if (head_or_tail == 1)
                {
                    Console.WriteLine("Heads");
                    h_count++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    t_count++;
                }
            }
            Console.WriteLine("no of heads "+h_count);
            Console.WriteLine("no of tails "+t_count);

            double Head_percentage = (h_count/n)*100;
            double Tail_Percentage = (t_count/n)*100;

            Console.WriteLine("Percentage of Heads is = {0}%", Head_percentage);
            Console.WriteLine("Percentage of Tails is = {0}% ", Tail_Percentage);

        }

        public static void Main(string[] args)
        {
            Program obj = new Program();


            Console.WriteLine("Flip coin problem");
            obj.FlipCoin();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Leap Year Problem");
            Leap_year leap_Year = new Leap_year();
            leap_Year.Leap_Year();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Powers of Two");
            Power_Of_2 power_Of_2 = new Power_Of_2();
            power_Of_2.Pow_2();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Harmonic Problem");

            Harmonic obj2 = new Harmonic();
            obj2.Harmonic1();


        }
    }
}