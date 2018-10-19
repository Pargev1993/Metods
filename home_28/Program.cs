using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == valu(x))
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
        static int valu(int x)
        {
            int result = 0;

            for (int i = 0; i <= x; i++)
            {

                result += x % 10;
                x /= 10;
            }
            result = 2 * result;
            return result;
        }
    }
}