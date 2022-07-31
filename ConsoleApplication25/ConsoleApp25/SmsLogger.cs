using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    public class SmsLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms olarak log yazıldı.");
        }

    }
}
