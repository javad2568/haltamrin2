using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
       X=Convert.ToInt32(Console.ReadLine());
            SQRT(X);
        }
        private static void SQRT(int X)
        {
            Console.WriteLine(Math.Sqrt(X));
            Console.ReadKey();
        }
    }
}
