using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTuple<int, string> x1 = ValueTuple.Create<int, string>(8, "ABC");
            Console.WriteLine($"(1) {x1.Item1} : {x1.Item2}");

            var x2 = (8, "ABC");
            Console.WriteLine($"(2) {x2.Item1} : {x2.Item2}");

            var x3 = (length: 8, letters: "ABC");
            Console.WriteLine($"(3) {x3.length} : {x3.letters}");

            (int length, string letters) x4 = (8, "ABC");
            Console.WriteLine($"(4) {x4.length} : {x4.letters}");

            (int length, string letters) x5 = (first: 8, second: "ABC");
            Console.WriteLine($"(5) {x5.length} : {x5.letters}");

            Console.ReadLine();
        }

    }
}
