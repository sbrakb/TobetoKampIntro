using OOP3;
using System.Collections.Generic;

IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();



BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() });


List<IKrediManager> krediler = new() { tasitKrediManager, ihtiyacKrediManager, konutKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);

ILoggerService databaseLogger = new DatabaseLoggerService();
ILoggerService fileLogger = new FileLoggerService();

List<ILoggerService> loggerServices = new() { databaseLogger, fileLogger };

basvuruManager.BasvuruYap(konutKrediManager, loggerServices);