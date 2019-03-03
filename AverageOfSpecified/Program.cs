using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfSpecified
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter total number of assignments");
            double totalNumbers = double.Parse(Console.ReadLine());
            Console.WriteLine("Confirm number of assignments");
            double total = double.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            double value = double.Parse(Console.ReadLine());
            
            

            double sum = 0;

            while (value <= 100 && value >= 0 && total != 1) 
            {   

                Console.WriteLine("enter grade");
                value = double.Parse(Console.ReadLine());

                sum += value;
                total--;

            }

            double average = sum / totalNumbers;
            double Grade = average;
            
                if (Grade > 89)
                {
                    Console.WriteLine("Grade = A");
                }

                else if (Grade > 79)
                {
                    Console.WriteLine("Grade = B");
                }

                else if (Grade > 69)
                {
                    Console.WriteLine("Grade = C");
                }

                else if (Grade > 59)
                {
                    Console.WriteLine("Grade = D");
                }

                else
                {
                    Console.WriteLine("Grade = F");
                }

                  Console.WriteLine($"Average = {average}");
                  Console.WriteLine($"Total assignments graded = {totalNumbers}");

        }
    }
}
