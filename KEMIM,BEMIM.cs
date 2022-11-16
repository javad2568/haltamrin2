using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            bemimmim(a, b);
            kemimmim(a, b);
        }
        private static void bemimmim(int a, int b)
        {
            int i, min, bemimmim = 1;
            min = a;
            if (min > b)
            {
                min = b;
            }
            for (i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    bemimmim = i;
                }
            }
            Console.WriteLine(bemimmim);
        }
        private static void kemimmim(int a, int b)
        {
            int i = 1, max, min;
            max = a;
            min = b;
            if (b > max)
            {
              max = b;
             min = a;
            }
            while (true)
            {
                max *= i;
                if (max % min == 0)
                {
              Console.WriteLine(max);
                 break;
                }
                else
                {
                i++;
                    Console.ReadKey();
                }
            }
        }
    }
}
