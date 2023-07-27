using MindBoxGeometryLib.Abstraction.Classes;
using MindBoxGeometryLib.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxGeometryLib.Implementations.Shapes {
    public class Triangle : Shape, ITriangle {
        private double _firstSide, a;
        public double FirstSide { get; set; }

        private double _secondSide, b;
        public double SecondSide { get; set; }

        private double _thirdSide, c;
        public double ThirdSide { get; set; }
        public double AngleA => Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
        public double AngleB => Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
        public double AngleC => Math.Acos((a * a + b * b - c * c) / (2 * b * a)) * 180 / Math.PI;
        public Triangle(double firstSide, double secondSide, double thirdSide) {
            this.a = this._firstSide = firstSide;
            this.b = this._secondSide = secondSide;
            this.c = this._thirdSide = thirdSide;
            Validate();
        }

        public override double CalculateArea() {
            var P = this.Perimeter / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }

        public override double CalculatePerimeter() {
            return _firstSide + _secondSide + _thirdSide;
        }

        public bool CheckIfRight() {
            if (AngleA == 90 || AngleB == 90 || AngleC == 90)
                return true;
            else return false;
        } 
        private void Validate() {
            if(a+b <= c || a+c <= b || c + b <= a) 
                throw new ArgumentException("Такого треугольника не может существовать!");
        }
    }
}
