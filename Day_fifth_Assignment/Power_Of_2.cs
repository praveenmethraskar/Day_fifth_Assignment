using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_fifth_Assignment
{
    public class Power_Of_2
    {
        public void Pow_2()
        {
            Console.WriteLine("Enter  any positive number to know power of 2");
            int power = Int32.Parse(Console.ReadLine());
            Console.WriteLine("your find 2 power {0}", power);
            double pow_ab = 0;



            for (int i = 1; i <= power; i++)
            {
                pow_ab = Math.Pow(2, power);
            }

            Console.WriteLine("the power of 2 is " + pow_ab);
        }
}
