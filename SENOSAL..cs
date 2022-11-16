using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rooz, mah, sal, hafteh;
            rooz = Convert.ToInt32(Console.ReadLine());
            senosal(rooz);
            }
        private static void senosal(int rooz)
        {
        int sal, mah, hafteh;
        sal = rooz/365;
            rooz %= 365;
            mah = rooz/30;
            rooz %= 30;
            hafteh=rooz/7;
            rooz%=7;

            Console.WriteLine(sal);
     
            }
    }
}
