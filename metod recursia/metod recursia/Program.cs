using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_recursia
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                int res = fact(5);
                Console.WriteLine(res);
                Console.ReadKey();
            }
        }
        static int fact (int num)
        {
            if (num == 1) return 1;
            return num * fact(num - 1);
            
        }
    }
}
