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
            int elements = 3;
            string[] words = new string[elements];
            words[0] = "Have";
            words[1] = "Some";
            words[2] = "Coffee";
            for (int i =0; i < elements; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
