using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="123";
           
            // 以前你要這樣寫
            int i;
            int.TryParse(s,out i);
            Console.WriteLine(i);
            // 現在你可以直接這樣寫
            int.TryParse(s, out int j);
            Console.WriteLine(j);

            // ref 不能比照 out 使用
            //Test(ref int y = 10);

            Console.ReadLine();
        }


        static void Test(ref int x)
        {
            x = x + 1;
        }


    }
}
