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
            int elements = 5;
            double[] numbers = new double[elements];
            numbers[0] = 10;
            numbers[1] = 25;
            numbers[2] = 27;
            for (int i =0; i < elements; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
