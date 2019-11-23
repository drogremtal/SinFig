using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_lab
{
    public class Triangle : Figure
    {
        private const int Id = 1;
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public Triangle()
        {

        }

        public override double Square() => 0.5 * Math.Abs(((Point2.x - Point1.x) * (Point3.y - Point1.y)) - (Point3.x - Point1.x) * (Point2.y - Point1.y));

        public override void Write()
        {
            Console.WriteLine("Triangle: " +
                "x1={0}, y1={1}," +
                "x2={2}, y2={3}," +
                "x3={4}, y3={5}," +
                "color={6}", Point1.x, Point1.y, Point2.x, Point2.y, Point3.x, Point3.y);
        }

        public override double Perimetr()
        {
            throw new NotImplementedException();
        }

    }
}
