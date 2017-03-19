using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceOfVariableSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            ref int p = ref number;
            Console.WriteLine(p);
            p = 999;
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
