using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceOfVariableSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "鼠", "牛", "虎", "兔" };
            int index = GetTigerIndex(data);
            data[index] = "老虎";
            Display(data);
            Console.ReadLine();
        }

        private static int GetTigerIndex(string[] data)
        {
            return Array.IndexOf(data, "虎");
        }
        private static void Display(string[] data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }


}
