using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_22
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
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sepretor = x % i;
               
                

                if (sepretor == 0)
                {
                    
                    sum += i;   
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            return sum;
        }
    }
}
