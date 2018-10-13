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
            int num = 0;
            for (int i = 0; i < x; i++)
            { if ((int)(x / Math.Pow(10, i)) != 0)
                {
                    num++;
                    
                }
                else
                    break;
            }

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
            int result = sum/num;
            Console.WriteLine($"the quotient of {sum} to {num} is {result}");
            Console.ReadKey();
            return result;
        }
    }
}
