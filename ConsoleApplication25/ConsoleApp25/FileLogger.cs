using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    public class FileLogger: ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosya olarak log yazıldı.");
        }
    }
}
