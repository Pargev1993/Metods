using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            numberofdegrees(number);

        }
        static int numberofdegrees (int x)
        {
            Console.WriteLine("Enter number");
            x = int.Parse(Console.ReadLine());
            int result = 0;
           
            for (int i = 0; i < x; i++)
            {
                result = (int)Math.Pow(x, 1.0 / i);
                if (result==3)
                {
                    Console.WriteLine($" {x} is {i} degree  of 3");
                     
                }
                
            }
            
            Console.ReadKey();
            return result;

        }
    }
}
