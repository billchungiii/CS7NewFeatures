using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = GetRange();
            Console.WriteLine($"{range.min} -- {range.max}");

            (int lower, int upper) limit = GetRange();
            Console.WriteLine($"{limit.lower} -- {limit.upper}");

            Console.ReadLine();
        }

        private static (int min, int max) GetRange()
        {
            int min = 0;
            int max = 100;
            return (min, max);
        }
    }
}
