using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle() { Width = 10, Height = 30 };
            (int x, int y) = rect;

            // (new MyRectangle() { Width = 5, Height = 60 }).Deconstruct(out int x, out int  y);
            Console.WriteLine($"{x} -- {y}");
            Console.ReadLine();
        }
    }

    public class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Deconstruct(out int width, out int height)
        {
            width = this.Width;
            height = this.Height;
        }
    }
}
