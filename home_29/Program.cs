using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_29
{
    class Program
    {
        static void Main(string[] args)
        {

            threedigitnumber(0);
            Console.ReadKey();
        }
        static void threedigitnumber(int num)
        {
            
            for (int i = 100; i < 1000; i++)
            {

                if (i == i%100*7)

                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

