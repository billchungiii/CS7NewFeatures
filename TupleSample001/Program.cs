using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleSample001
{
    /// <summary>
    /// 以前使用 Tuple<> 泛型遇到的小麻煩
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetSomthing();
            Console.WriteLine($" {data.Item1} : {data.Item2}");
            Console.ReadLine();
        }

        private static Tuple<int, string> GetSomthing()
        {
            int i = 100;
            string s = "ABC";
            return Tuple.Create(i, s);
        }
    }
}
