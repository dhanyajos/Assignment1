// Write a program to check whether a given number is positive or negative.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Fifth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                Console.WriteLine("Positive number");
            }
            else if(n<0)
            {
                Console.WriteLine("Negative number");
            }
            else
            {
                Console.WriteLine("neither positive nor negative");
            }
            Console.ReadKey();
        }
    }
}
