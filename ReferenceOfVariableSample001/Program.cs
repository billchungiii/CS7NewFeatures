using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceOfVariableSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            unsafe
            {
                int* p = &number;
                Console.WriteLine(*p);
                *p = 999;
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
