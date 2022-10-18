// Write a program to find sum of digits of a number.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class First
    {
        static void Main(string[] args)
        {
            int j, sum = 0;
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                j = num % 10;
                sum = sum + j;
                num = num / 10;

            }
            Console.WriteLine("sum is " + sum);

            Console.ReadKey();

        }
    }
}
