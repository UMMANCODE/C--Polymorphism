using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26 {
    internal class Rectangle: Shape {
        public double Height;
        public double Width;

        public Rectangle(double height, double width) {
            Height = height;
            Width = width;
        }

        public override double CalculateArea() {
            return Height * Width;
        }
    }
}
