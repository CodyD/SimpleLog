using System;
using System.Text;
using System.Threading.Tasks;
using TW.SimpleLogger.Contracts;
using TW.SimpleLogger.Contracts.Enums;

namespace TW.SimpleLogger.Library
{
   /// <summary>
   /// Simple concrete implementation of a logging utility.
   /// </summary>
   public class SimpleLogger : ISimpleLogger
   {
      /// <summary>
      /// The output interface.
      /// </summary>
      protected readonly IWriteAdapter _writer;

      public SimpleLogger(IWriteAdapter write)
      {
         if (null == write)
         {
            throw new ArgumentNullException(nameof(write));
         }
         _writer = write;
      }

      /// <inheritdoc />
      public void Log(Severity sev, Granularity gran, string message)
      {
         if (null == message)
         {
            throw new ArgumentNullException(nameof(message));
         }
         string line = CreateLine(sev, gran, message);
         _writer.Write(line);
      }


      /// <summary>
      /// Not yet implemented.
      /// </summary>
      /// <param name="sev"></param>
      /// <param name="gran"></param>
      /// <param name="message"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public async Task LogAsync(Severity sev, Granularity gran, string message)
      {
         //TODO this would be great
         throw new NotImplementedException();
      }

      private string CreateLine(Severity sev, Granularity gran, string msg) {
         //currently not going to implement granularity
         //we really should use some kind of time proxy here instead of relying on the system datetime
         return string.Format("{0} [{1}] - {2}", DateTime.Now.ToLongTimeString(), sev.ToString(), msg);
      }
   }
}