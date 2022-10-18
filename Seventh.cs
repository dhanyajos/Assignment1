
// Write a program to read roll no, name and marks of three subjects and calculate the total, percentage.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Seventh
    {
        static void Main(string[] args)
        {
           
                int rollNo, num1, num2, num3, sum;
                String name;
                double percent;
                Console.WriteLine("Enter the Roll No");
                rollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the first mark");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second mark");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the third mark");
                num3 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2 + num3;
                percent = sum / 3.0;

                Console.WriteLine("RollNo: " + rollNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Total: " + sum);
                Console.WriteLine("Percentage: " + percent);
                Console.ReadKey();

            
        }
    }
}
