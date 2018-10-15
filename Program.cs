using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                for (int i = 1; i <= userInput; i++)
                {
                    double squaredNumber = Math.Pow(i, 2);
                    Console.Write(squaredNumber + " ");
                }

                Console.WriteLine(Environment.NewLine + "Do you want to continue?");
                
            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }
    }
}
