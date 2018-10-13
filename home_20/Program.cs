using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int sepretor = 0;
            numberSeparator(sepretor);
        }
        static int numberSeparator(int x)
        {
            Console.WriteLine("Enter number");
            x = int.Parse(Console.ReadLine());
            int sepretor = 0;
            for (int i = 1; i <= x; i++)
            {
                sepretor = x % i;
             
                if (x%i==0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
            return sepretor;

        }
    }
}
