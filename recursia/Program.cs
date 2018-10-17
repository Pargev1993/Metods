using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursia
{
    class Program
    {
        static void Main(string[] args)
        {
          
           recursia(10);
          
            Console.ReadKey();
        }
        static int recursia(int n)
        {
            if (n <1)
                return 1;
            Console.WriteLine(n);
            return  recursia(n - 1);
            
        }
    }
}
