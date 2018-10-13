using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_17
{
    class Program
    {
        static void Main(string[] args)
        {

            int digg = 0;
            odddigit(digg);

        }
        static int odddigit(int x)
        {
            Console.WriteLine("Enter number");
            x = int.Parse(Console.ReadLine());
            int digg = 0;

            for (int i = 0; i < x; i++)
            {
                digg = (int)(x / Math.Pow(10, i) % 10);

                if (digg % 2 != 0)
                {

                    break;
                }
            }
            Console.WriteLine(digg % 2 != 0 ? $"The  odd digit of {x} is {digg}" : "you have not add digits");

            Console.ReadKey();
            return digg;
        }
    }
}
