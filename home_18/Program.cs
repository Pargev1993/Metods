using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggadd = 0;
            biggerthen4odddigits(biggadd);
        }
        static int biggerthen4odddigits(int x)
        {
            Console.WriteLine("Enter number");
            x = int.Parse(Console.ReadLine());
            int digg = 0;
            for (int i = 0; i < x; i++)
            {
                digg = (int)(x / Math.Pow(10, i) % 10);
                if (digg % 2 != 0 && digg > 4)
                {
                    Console.WriteLine(digg);
                    Console.Clear();
                }
                Console.WriteLine(digg % 2 != 0 && digg > 4 ? $"your biggist odd digit is {digg}" : "you hav no add gitits");
                Console.ReadKey();
            }
            return digg;
        }
    }
}
