using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService loggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),new List<ILoggerService>{ loggerService, new SmsLoggerService()});
            
            
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //İnterfacelerde aynı ref. numarasını tutabiliyor.



        }
    }
}