using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            mindegree(res);
        }
        static int mindegree (int n)
        {
            Console.WriteLine("Enter number");
            n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 1; i <n; i++)
            {
               num= (int)Math.Pow(n, 1.0 / i);
                if (num == 2)
                {
                    Console.WriteLine(i;
                }
               
            }
            
            Console.ReadKey();
            return num;
        }
    }
}
