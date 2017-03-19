using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "1", "2", "3", "4", "5" };
            Display(list1);
            List<string> list2 = new List<string>() { "A", "B", "C", "D", "E" };
            Display(list2);
            Console.ReadLine();


            void Display(List<string> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

      
    }
}
