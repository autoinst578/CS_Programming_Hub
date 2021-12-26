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
            int c = -5;
            int x = 2;
            int y = 8;
            while(c <= 250)
            {
                DoMath(out x, out y);
                c = c + x + y;
            }
        }

        static void DoMath(out int a, out int b) //function that does some kind of operation
        {
            a = 15;
            b = 3;
        }
    }
}
