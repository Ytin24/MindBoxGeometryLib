using MindBoxGeometryLib.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxGeometryLib.Abstraction.Classes {
    public abstract class Shape : IShape {
        public abstract double CalculatePerimeter();
        public double Perimeter => CalculatePerimeter();
        public abstract double CalculateArea();
        public double Area => CalculateArea();
    }
}
