
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ThrowExpressionSample
{
    public class MyCircle
    {
        private double _radius;
        private string _name;
        public double Radius
        {
            get => _radius;
            set => _radius = value > 0 ? value : throw new ArgumentException();
        }

        public string Name
        {
            get => _name;
            set => this._name = value ?? throw new ArgumentException();
        }       
    }
}