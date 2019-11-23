using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_lab
{
    public class Polygon : Figure
    {

        public List<Point> points { get; set; }

        public Polygon(List<Point> points, int color)
        {
            this.points = points;
        }

        public Polygon()
        {
        }

        public override double Square()
        {
            double Square = 0;
            for (int i = 0; i < points.Count - 1; i++)
            {
                Square += (points[i].x + points[i + 1].x) * (points[i].y - points[i + 1].y);
            }
            return 0.5 * Math.Abs(Square);
        }

        public override double Perimetr()
        {
            var line = new List<double> { };
            for (int i = 0; i < points.Count - 1; i++)
            {
                line.Add(Math.Sqrt(
                    Math.Pow(points[i + 1].x - points[i].x, 2)
                  + Math.Pow(points[i + 1].x - points[i].y, 2)));
            }
            double s = 0;
            foreach (var item in line)
            {
                s += item;
            }
            return s;
        }

        public override void Write()
        {
            var s = "Polygon :";

            for (int i = 0; i < points.Count; i++)
            {
                s += string.Format("x{0}={1},y{0}={2}", i, points[i].x, points[i].y);
            }
            s += string.Format("color:{0}", Color);
            Console.WriteLine(s);
        }


    }
}
