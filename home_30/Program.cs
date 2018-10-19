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
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[1];
            array[0] = n;
            for (int i = 0; i < n; i++)
            {
                int res = n % 10;
                n /= 10;
                res *= 10;
                Console.Write(res);
            }
            Console.ReadKey();
        }
    }
}

