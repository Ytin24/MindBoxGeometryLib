using MindBoxGeometryLib.Abstraction.Classes;
using MindBoxGeometryLib.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxGeometryLib.Implementations.Shapes {
    public class Circle : Shape, ICircle {
        public Circle(double radius) {
        this.Radius = radius;
        }
        private double _radius;
        public double Radius {
            get {
                return _radius;
            }
            set {
                _radius = value;
            }
        }
        public double Diameter {
            get {
                return _radius * 2;
            }
            set {
                _radius = value / 2;
            }
        }
        public override double CalculateArea() {
            return Math.PI * Math.Pow(this._radius, 2);
        }

        public override double CalculatePerimeter() {
            return 2 * Math.PI * _radius;
        }
    }
}
