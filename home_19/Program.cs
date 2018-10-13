using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_19
{
    class Program
    {
        static void Main(string[] args)

        {
            int manuf = 0;
            smallistPairsdiggits7(manuf);
        }
        static int smallistPairsdiggits7(int x)
        {
            Console.WriteLine("Enter Number");
            x = int.Parse(Console.ReadLine());

            int Pairs = 0;
            int manuf = 1;
            for (int i = 0; i < x; i++)
            {
                Pairs = (int)(x / Math.Pow(10, i) % 10);
                if (Pairs == 0)
                {
                    break;
                }
                if (Pairs % 2 == 0 && Pairs < 7)
                {
                    manuf *= Pairs;

                }
                else
                    continue;

            }
            Console.WriteLine(Pairs % 2 == 0 && Pairs < 7 ? $"smaller then 7 pairs digit manufactur from {x} is {manuf}" : "its have not pairs digits smaller then 7:");
            Console.ReadKey();
            return manuf;
        }
    }
}
