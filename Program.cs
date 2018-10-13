using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x = int.Parse(Console.ReadLine());

            numberquantity(x);
            sumofdigits(x);
            numbermanufactured(x);

        }
        static int numberquantity(int x)
        {

            int number = 0;
            for (int i = 0; i < x; i++)
            {
                if ((int)(x / Math.Pow(10, i)) != 0)

                    number++;
            }
            Console.WriteLine("the digits quantity of {0}={1}", x, number);


            return number;
        }
        static int sumofdigits(int x)
        {

            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                if ((int)(x / Math.Pow(10, i)) != 0)
                {
                    sum += (int)(x / Math.Pow(10, i)) % 10;
                }
            }
            Console.WriteLine("the summer digits of {0}={1}", x, sum);


            return sum;
        }
        static int numbermanufactured(int x)
        {
            int manu = 1;
            for (int i = 0; i < x; i++)
            {
                if ((int)(x / Math.Pow(10, i)) != 0)
                {
                    manu *= (int)(x / Math.Pow(10, i)) % 10;
                }
            }
            Console.WriteLine("the manufactured  digits of {0}={1}", x, manu);
            Console.ReadLine();
            return manu;
        }


    }
}
