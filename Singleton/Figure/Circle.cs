using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace First_lab
{
    [Serializable]
    public class Circle : Figure
    {
        public int R { get; set; }
        public Point point { get; set; }

        public Circle() { }

        public Circle(int r) { R = r; }

        public Circle(int r, Point point)
        {
            R = r;
            this.point = point;
        }        

        public override double Perimetr()
        {
            return 2 * this.R * Math.PI;
        }

        public override double Square()
        {
            return Math.Pow(R, 2) * Math.PI;
        }

        public override void Write()
        {
            Console.WriteLine("Circle: R={0},x={1} y={2}",R,point.x,point.y);
        }

    }
}
