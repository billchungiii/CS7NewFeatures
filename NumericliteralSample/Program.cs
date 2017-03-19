using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericliteralSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //二進位數字表示法
            int i = 0b0010;
            Console.WriteLine(i);

            // 使用底線讓數字更清晰
            int j = 100_000;
            Console.WriteLine(j);
            int k = 1_00;
            Console.WriteLine(k);
            int l = 0b0010_0000;
            Console.WriteLine(l);
            double d = 3.141_592_653;
            Console.WriteLine(d);
            

            Console.ReadLine();
            
        }
    }
}
