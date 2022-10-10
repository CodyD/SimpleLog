using System;
using System.Threading;
using TW.DeveloperTest.Contracts;
using TW.SimpleLogger.Contracts;
using TW.SimpleLogger.Contracts.Enums;
using TW.SimpleLogger.Library;
using TW.SimpleLogger.Library.Adapters;

namespace TW.DeveloperTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            IWorker worker = Ioc.Resolve<IWorker>();
         //IWriteAdapter writeAdapter = Ioc.Resolve<IWriteAdapter>();
         IWriteAdapter writeAdapter = new ConsoleWriteAdapter(); //sure, why  not?
            ISimpleLogger myLogger = new LogBuilder()
               .WithWriter(writeAdapter)
               .Build();

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Modifiers.HasFlag(ConsoleModifiers.Control)
                        && key.Key == ConsoleKey.X)
                    {
                        run = false;
                    }
                }

                try
                {
                    var result = worker.GetResult();
                    myLogger.Log(Severity.Info, Granularity.Simple, "Worker success, running next.");
                }
                catch (Exception e)
                {
                    //TODO replace with logging library
                    Console.WriteLine($"error - {e.Message}");
                    myLogger.Log(Severity.Error, Granularity.Verbose | Granularity.UserInfo | Granularity.SystemInfo, "Worker failed.");
            }
                
                Thread.Sleep(500);
            } while (run);
        }
    }
}
