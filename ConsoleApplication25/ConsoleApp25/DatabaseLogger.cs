using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database olarak log yazıldı.");
        }
    }
}
