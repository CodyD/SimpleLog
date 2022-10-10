using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using TW.SimpleLogger.Contracts.Enums;
using TW.SimpleLogger.Library;
using TW.SimpleLogger.Contracts;
using TW.SimpleLogger.Contracts.Enums;
using TW.UnitTest.SimpleLogger.Mock;

namespace TW.UnitTest.SimpleLogger
{
   [TestClass]
   public class LogTests
   {
      //TODO so  many tests, so little time...


      [TestMethod]
      public async Task Log_Severity_Expects_Severity_In_Output()
      {
         bool success = true;
         foreach (Severity severity in Enum.GetValues(typeof(Severity)))
         {
            var myWriter = new MockWriter();
            var logger = new LogBuilder().WithWriter(myWriter).Build();
            logger.Log(severity, Granularity.Simple, string.Empty);
            success = success && myWriter.LastWrite.Contains(severity.ToString());
         }
         Assert.IsTrue(success);
      }

      [TestMethod]
      public async Task Log_Expects_Timestamp()
      {
         //need to set up a time proxy for this
         Assert.IsTrue(false);
      }
   }
}