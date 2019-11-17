using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Singleton
{
    class Logger : Singleton<Logger>
    {
        readonly string LogFilePath = "log.txt";
          
        Logger()
        {
            
        }
 
        public void WriteLogErrorMsg(string msg)
        {
            using (StreamWriter sw = new StreamWriter(LogFilePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(msg);

            }
        }

        internal void WriteLogErrorMsg (Exception exc)
        {
            using (StreamWriter sw = new StreamWriter(LogFilePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(exc);

            }
        }
    }
}
