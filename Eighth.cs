// Write a program in C# Sharp to display the n terms of odd natural number and their sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Eighth
    {
       static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe odd natural numbers :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum =sum+ 2 * i - 1;
            }
            Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
            Console.ReadKey();
        }  
    }
}
