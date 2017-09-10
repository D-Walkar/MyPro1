using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void mydel(int a, int b);
        class ClsInfo
        {
            public void GetVal(int a,int b)
            {
                Console.WriteLine(a+b);
            }
        }
        static void Main(string[] args)
        {
            ClsInfo obj = new ClsInfo();
            mydel d1 = new mydel(obj.GetVal);
            d1(10, 20);
            Console.Read();
        }
    }
}
