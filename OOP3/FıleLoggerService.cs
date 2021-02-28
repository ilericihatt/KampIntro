using System;

namespace OOP3
{
    class FıleLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
