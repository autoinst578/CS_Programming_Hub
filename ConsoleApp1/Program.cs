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
            int A = 10;
            int B = 10;
            if (A > B)
            {
                Console.WriteLine("A is higher than B");
                Console.ReadLine();
            }
            else if ( A < B)
            {
                Console.WriteLine("B is higher than A");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A is equal to B");
                Console.ReadLine();
            }

        }
    }
}
