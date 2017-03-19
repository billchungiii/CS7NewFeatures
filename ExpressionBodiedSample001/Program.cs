using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new MyCircle();
            Display();
            circle.Radius = -1;
            Display();
            Console.ReadLine();

            void Display()
            {
                Console.WriteLine($"{circle.Name} 的半徑是 {circle.Radius } ");
                Console.WriteLine($"{circle.Name} 的面積是 {circle.GetArea() } ");
            }

        }
    }
}
