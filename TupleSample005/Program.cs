using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleSample005
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle() { Width = 5, Height = 60 };
            (int x, int y) = rect;

            Console.WriteLine($"{x} -- {y}");

            Console.ReadLine();
        }
    }
}
