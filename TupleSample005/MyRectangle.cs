using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleSample005
{
    public class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public static class MyExtension
    {
        public static void Deconstruct(this MyRectangle rect, out int width, out int height)
        {
            width = rect.Width;
            height = rect.Height;
        }
    }
}
