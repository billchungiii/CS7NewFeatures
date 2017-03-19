using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "1", "2", "3", "4", "5" };
            var list = list1;
            Display();
            List<string> list2 = new List<string>() { "A", "B", "C", "D", "E" };
            list = list2;
            Display();
            Console.ReadLine();


            void Display()
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
