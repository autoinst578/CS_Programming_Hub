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
            int A = 15;
            int B = 15;
            int C = 20;
            if(A == B && C > B)
            {
                Console.WriteLine("A and B are equal, and C is higher than B");
                Console.ReadLine();
            }

        }
    }
}
