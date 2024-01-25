using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26 {
    internal class ShapeManager {
        Shape[] shapes = Array.Empty<Shape>();

        public uint GetCircleCount() {
            uint count = 0;
            foreach (Shape shape in shapes) {
                if (shape is Circle) {
                    count++;
                }
            }
            return count;
        }

        public Circle[] GetCircles() {
            Circle[] circles = Array.Empty<Circle>();
            foreach (Shape shape in shapes) {
                if (shape is Circle circle) {
                    Array.Resize(ref circles, circles.Length + 1);
                    circles[circles.Length - 1] = circle;
                }
            }
            return circles;
        }

        public double GetTotalCircleAreas() {
            double total = 0;
            foreach (Shape shape in shapes) {
                if (shape is Circle) {
                    total += shape.CalculateArea();
                }
            }
            return total;
        }

        public uint GetSquareCount() {
            uint count = 0;
            foreach (Shape shape in shapes) {
                if (shape is Rectangle rectangle && rectangle.Width == rectangle.Height) {
                    count++;
                }
            }
            return count;
        }

        public void AddShape(Shape shape) {
            if (shape == null) return;
            uint rectangleCount = 0, circleCount = 0;
            foreach (Shape s in shapes) {
                if (s is Rectangle) rectangleCount++;
                if (s is Circle) circleCount++;
            }
            if (circleCount > 10 || rectangleCount > 10) return;
            Array.Resize(ref shapes, shapes.Length + 1);
            shapes[shapes.Length - 1] = shape;
        }
    }
}
