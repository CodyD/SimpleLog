﻿using System.Text;
using TW.SmpleLogger.Contracts;
using TW.SmpleLogger.Contracts.Enums;

namespace TW.SimpleLogger.Library
{
   public class SimpleLogger : ISimpleLogger
   {
      public IWriteAdapter Writer
      {
         get;
         set;
      }

      public void Log(Severity sev, Granularity gran, string message)
      {
         if (null == message)
         {
            throw new ArgumentNullException(nameof(message));
         }
         string line = CreateLine(sev, gran, message);
         Writer.Write(line);
      }

      private string CreateLine(Severity sev, Granularity gran, string msg) {
         //currently not going to implement granularity
         //we really should use some kind of time proxy here instead of relying on the system datetime
         return string.Format("{0} [{1}] - {2}", DateTime.Now.ToLongTimeString(), sev.ToString(), msg);
      }
   }
}