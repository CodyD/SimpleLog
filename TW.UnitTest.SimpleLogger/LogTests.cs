using Moq;
using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using TW.SimpleLogger.Library;
using TW.SmpleLogger.Contracts;
using TW.SmpleLogger.Contracts.Enums;
using TW.UnitTest.SimpleLogger.Mock;
using Xunit;

namespace TW.UnitTest.SimpleLogger
{
   public class LogTests
   {

      [Fact]
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
         Assert.True(success);
      }

      [Fact]
      public async Task Log_Expects_Timestamp()
      {
         //need to set up a time proxy for this
         Assert.True(false);
      }
   }
}