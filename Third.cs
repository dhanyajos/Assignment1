// Write a program to find sum of first 10 natural numbers.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Third
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for(i=1;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of first 10 natural numbers:" + sum);
            Console.ReadKey();
        }
    }
}
