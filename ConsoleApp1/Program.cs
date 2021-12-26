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
                c = c + DoMath(x, y);
                for(int i = 5; i < 8; i++)
                {
                    c = c + DoMath(x, y);
                }
            }
        }

        static int DoMath(int a, int b) //function that does some kind of operation
        {
            int variable = 52;
            int variable1 = a + b + variable;
            variable1 = variable1 * 2;
            return variable;
        }
    }
}
