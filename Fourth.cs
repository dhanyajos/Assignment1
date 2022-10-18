// Write a program to find the largest of three numbers.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Fourth
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
             num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2 && num1 >num3)
            {
                Console.WriteLine("{0} is the largest number",num1);
            }
            else if (num2> num1 && num2 > num3)
            {
                Console.WriteLine("{0} is the largest number", num2);
            }
             else
            {
                Console.WriteLine("{0} is the largest number", num3);
            }
            Console.ReadKey();
        }
    }
}
