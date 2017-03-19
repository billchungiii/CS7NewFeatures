using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceOfVariableSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "鼠", "牛", "虎", "兔" };
            ref string s = ref GetTiger(data);
            s = "大老虎";
            Display(data);
            Console.ReadLine();
        }

        private static ref string GetTiger(string[] data)
        {
            return ref data[Array.IndexOf(data, "虎")];
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
