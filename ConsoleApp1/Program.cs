using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;
            int c = DoMath(x, y);
            Console.WriteLine(c);

        }

        static int DoMath(int a,int b)
        {
            return a + b;
        }
    }
}
