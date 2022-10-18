/* Pattern
 
 *******
  *****
   ***
    *   
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Tenth
    {
        static void Main(string[] args)
        {
            int i,j,k, rows;
            Console.Write("Number of rows  :");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (k = 1; k <= (rows * 2) - (2 * i - 1); k++)
              
                {
                    Console.Write("*");
                }
              
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}






