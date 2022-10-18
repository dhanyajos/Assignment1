// Write a program to accept two integers and check whether they are equal or not.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Sixth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }
            Console.ReadKey();
        }
    }
}
