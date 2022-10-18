/* Write a program in c# to display the multiplication table of a given integer.
6

1*6=6
.........
10*6=60
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Second
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the key");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = i * 6;
                Console.WriteLine("{0} * {1} = {2}", i, n, result);
            }

            Console.ReadKey();
        }
    }
}
