using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
       // public delegate void mydel();
        public delegate int mydeleg(int a,int b);
         
        static void Main(string[] args)
        {
         /*   mydel d1 = delegate ()
            {
                Console.WriteLine("Deepak");
            };
            d1();
            */

            //Anonnymous Method

            mydeleg d2 = (a,b) => (a+b);
            Console.WriteLine(d2(100, 200));
            Console.Read();

        }
    }
}
