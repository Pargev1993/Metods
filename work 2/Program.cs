using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            recursion(A,B);
            Console.ReadKey();
        }
        static int recursion(int A, int B)
        {

            if (A > B)
            {

                Console.WriteLine(A);
                return recursion(A - 1, B);
            }
            else if (A < B)
            {

                Console.WriteLine(A);
                return recursion(A + 1, B);
            }
            else
                return (A);

        }
    }
}
