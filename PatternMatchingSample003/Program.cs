using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> list = new List<IShape>
            {
                new MyRectAngle(),
                new MyCircle(),                
            };
            foreach (var item in list)
            {
                InitialShape(item, 10, 10);
                Console.WriteLine(item.GetArea());
            }
            Console.ReadLine();

        }

        private static  void InitialShape(IShape shape, double x, double y)
        {
            switch (shape )
            {
                case MyRectAngle s :
                    s.Height = x;
                    s.Width = y;
                    break;
                case MyCircle s:
                    s.Radius = x;
                    break;
                case null:
                    break;                
            }
        }
    }
}
