using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample001
{
    /// <summary>
    /// 以前沒有 Pattern Matching 的時候
    /// </summary>
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
            if (value is int)
            { Console.WriteLine((int)value); }
            else
            { Console.WriteLine("not int"); }
        }
    }
}
