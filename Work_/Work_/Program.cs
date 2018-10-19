using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_
{
    class Program
    {
        static void Main(string[] args)

        {
            int num = int.Parse(Console.ReadLine());
            if (recursia(num) == 1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();

        }
        static int recursia(float num)
        {
            if (num == 1)
            
                return 1;
            
            else if (num > 1 && num < 2)
            
                return 0;
            
          return  recursia(num / 2);
           
        }
    }
}
