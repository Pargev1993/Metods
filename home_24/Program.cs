using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_24
{
    class Program
    {
        static void Main(string[] args)
        {while (true)
            {
                Console.WriteLine("Enter number");
               float x = 0f;
                x =float.Parse(Console.ReadLine());
                bool isNumDirBy3 = numberofdegrees(x);
                Console.WriteLine(isNumDirBy3);
            }
        }
        static bool numberofdegrees(float x)
        {
            
            float result = 0f;

            for (int i = 0;i<x ;)
            {

                result = x;
                x /= 3;
                if (result == 1)
                {
                    return true;
                }
                
            }
            
           
            return false;

        }
    }
}
