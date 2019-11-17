using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using First_lab;
using System.Xml.Serialization;
using System.IO;

namespace Singleton
{
    class FigureFactory : Singleton<FigureFactory>
    {

        Figure figure;

        Dictionary<int, Figure> CallBackMap = new Dictionary<int, Figure> {
            {0,
                new Triangle(){
                Color = 1,
                Point1 = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
                Point2 = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
                Point3 = new Figure.Point(new Random(100).Next(), new Random(100).Next())
            }
            },
            {1, new Circle(){
                Color = new Random(100).Next(),
                point = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
                R = new Random(20).Next() }},
            {2, CreatePolygon()
            },
        };

        private FigureFactory ()
        {

        }

        public Figure CreateFigure (int Id)
        {
            Figure figure;
            var find = CallBackMap.TryGetValue(Id, out figure);
            return figure;
        }

        public bool RegisterFigure (int id, Figure figure)
        {
            try
            {
                CallBackMap.Add(id, figure);
                return true;
            }
            catch
            {
                return false;
            }

        }
        void UnregisterFigure () { }

        public  void WriteToXml (int id)
        {
            var XmlFile = new XmlSerializer(typeof(Figure));

            try
            {
                var figure = CallBackMap[id];

                using (FileStream fs = new FileStream("Circle.xml", FileMode.OpenOrCreate))
                {
                    XmlFile.Serialize(fs, figure);

                    Console.WriteLine("Объект сериализован");
                }
            }
            catch(Exception exc) { Logger.Instance.WriteLogErrorMsg(exc); }
        }

        public void WriteToXml (Figure figure)
        {
            var XmlFile = new XmlSerializer(typeof(Figure));

            using (FileStream fs = new FileStream("Circle.xml", FileMode.OpenOrCreate))
            {
                XmlFile.Serialize(fs, figure);

                Console.WriteLine("Объект сериализован");
            }

        }


        //private Figure CreateTriangle()
        //{
        //    return new Triangle()
        //    {
        //        Color = 1,
        //        Point1 = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
        //        Point2 = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
        //        Point3 = new Figure.Point(new Random(100).Next(), new Random(100).Next())
        //    };
        //}


        //private Figure CreateCircle()
        //{
        //    return new Circle()
        //    {
        //        Color = new Random(100).Next(),
        //        point = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
        //        R = new Random(20).Next()
        //    };
        //}

        private static Figure CreatePolygon ()
        {
            var Points = new List<Figure.Point> { };

            var count = new Random(100).Next(0, 200);

            for (int i = 0; i < (count > 2 ? count : 3); i++)
            {
                Points.Add(new Figure.Point(new Random(10 * i + 1).Next(), new Random(10 / (i + 1)).Next()));
            }
            return new Polygon()
            {
                Color = new Random(359).Next(),
                points = Points
            };
        }



    }
}
