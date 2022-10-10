using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TW.SimpleLogger.Contracts;

namespace TW.SimpleLogger.Library
{
   /// <summary>
   /// Builds a log utility.
   /// </summary>
   public class LogBuilder
   {
      private IWriteAdapter _writer;

      /// <summary>
      /// Provides the argumented IO writer to the logger when built.
      /// </summary>
      /// <param name="outStream"></param>
      /// <returns></returns>
      public LogBuilder WithWriter(IWriteAdapter writer)
      {
         _writer = writer;
         return this;
      }

      /// <summary>
      /// Builds a log utility.
      /// </summary>
      /// <returns>A new instance of the <see cref="SimpleLogger"/> class</returns>
      public ISimpleLogger Build()
      {
         var logger = new SimpleLogger();
         logger.Writer = _writer;
         return logger;
      }
   }
}
