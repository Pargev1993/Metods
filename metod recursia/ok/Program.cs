using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok
{
    class Program
    {
        static void Main(string[] args)
        {
          dreem(1);
            
        }
        static void dreem (int y)
        {
            y+=2;
            Console.WriteLine(y);
            if (y< 10)
                dreem(y);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
