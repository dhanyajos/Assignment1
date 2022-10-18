/* Pattern
 
1
1 2
1 2 3
1 2 3 4

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Eleventh
    {
        static void Main(string[] args)
        {
            int rows;
            Console.Write("Number of rows  :");
            rows = Convert.ToInt32(Console.ReadLine());

            int i, j;
            for (i = 1; i <= rows; ++i)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
