using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using First_lab;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)

        {

            Logger.Instance.WriteLogErrorMsg("бла бла");

            var factory = FigureFactory.Instance;

            var Circle = factory.CreateFigure(1);
            var Polygon = factory.CreateFigure(2);

            FigureFactory.Instance.WriteToXml(Circle);
            FigureFactory.Instance.WriteToXml(Polygon);




            var FIGURE = factory.ReadToXml(Circle);

            
        }
    }
}
