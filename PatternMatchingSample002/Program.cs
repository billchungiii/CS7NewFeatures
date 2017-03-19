using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Execute(i);
            Console.ReadLine();
        }
        private static void Execute(object value)
        {
            if (value is int x)
            { Console.WriteLine(x); }
            else
            { Console.WriteLine("not int"); }
        }
    }
}
