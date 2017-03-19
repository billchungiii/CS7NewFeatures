using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedSample001
{
    public class MyCircle
    {
        private double _radius;
        private string _name;
        public double Radius
        {
            get => _radius;
            set => this._radius = value;
        }

        public string Name
        {
            get => _name;
            set => this._name = value ?? "就是這個圓";
        }

        public MyCircle() => _radius =2;

        public double GetArea() => (_radius > 0) ? Math.PI * (Math.Pow(_radius, 2)) : 0; 
    }
}
