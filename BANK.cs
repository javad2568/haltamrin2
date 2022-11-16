using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
        int sood, manba, maghsad ;
          manba=Convert.ToInt32(Console.ReadLine());
            maghsad=Convert.ToInt32(Console.ReadLine());
         sood=Convert.ToInt32(Console.ReadLine());
            natije (maghsad,manba,sood);
        }
     private static void natije(int a,int b,int c)
        {
            int i=1;
        while (true)
            {
                if ((a*(c/100)*i)+a>=b)
                {
                    Console.WriteLine(i);
                        break;
                }
                else
                {
                    a+=(a*(c/100)*i);
                    i++;
                    Console.ReadKey();
                }
            }
        }
    }
}
