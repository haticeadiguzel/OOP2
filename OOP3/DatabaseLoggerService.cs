using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı");
        }

    }

    //Hemen sonrasında yeni class oluşturup move type... diyerek yeni class olarak kısa yol yaptı
}
