using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_fifth_Assignment
{
    public class Leap_year
    {
        public void Leap_Year()
        {
            Console.WriteLine("Enter Year in format of yyyy");
            int year = Int32.Parse(Console.ReadLine());

            if (((year % 4==0) && (year % 100 !=0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year");
            }
            else
            {
                Console.WriteLine("{0} is not a leap year");
            }
        }
    }
}
