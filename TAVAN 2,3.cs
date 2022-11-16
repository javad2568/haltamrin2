using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
          Console.WriteLine("GIVE ME ADAD ")
              X = Convert.ToInt32(Console.ReadLine());
           Power(X);
        }
    static void Power(int X)
        {
            Console.WriteLine(Math.Pow(X, 3));
         Console.WriteLine(Math.Pow(X, 2));
               Console.ReadKey();
        }
    }
}
