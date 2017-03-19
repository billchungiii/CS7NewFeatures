using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            Execute(a);
            int b = 999;
            Execute(b);
            int c = 1001;
            Execute(c);
            string s = "WXYZ";
            Execute(s);

            Console.ReadLine();
        }

        private static void Execute(object value)
        {
            switch (value)
            {
                case int x when x > 0 && x < 100:
                    Console.WriteLine($"x 是小整數 : {x}");
                    break;
                case int x when x > 99 && x < 1000:
                    Console.WriteLine($"x 是大整數 : {x}");
                    break;
                case int x:
                    Console.WriteLine($"x 超出範圍");
                    break;
                case string x:
                    Console.WriteLine($"x 是字串 : {x}");
                    break;
                default:
                    Console.WriteLine("不在 case 內");
                    break;
            }
        }
    }
}
