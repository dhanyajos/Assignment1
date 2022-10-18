// Switch Program example.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Switch
    {
        static void Main(string[] args)
        {
            char grade = 'F';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Well Done");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Average");
                    break;

                default:
                    Console.WriteLine("Failed");
                    break;
            }
            Console.ReadLine();
        }
    }
}
    

