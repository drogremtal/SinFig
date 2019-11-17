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

            var f = FigureFactory.Instance.CreateFigure(1);
            FigureFactory.Instance.WriteToXml(f);
            



            
        }
    }
}
