using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace First_lab
{
    [Serializable]
    public abstract class Figure
    {
        public int Color { get; set; }

        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public abstract double Perimetr();

        public abstract double Square();

        public abstract void Write();

        


    }


}
