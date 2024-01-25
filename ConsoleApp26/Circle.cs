using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26 {
    internal class Circle: Shape {
        public double Radius;

        public Circle(double radius) {
            Radius = radius;
        }

        public override double CalculateArea() {
            return Math.PI * Radius * Radius;
        }
    }
}
