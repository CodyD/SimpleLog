using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.SimpleLogger.Contracts;

namespace TW.SimpleLogger.Library.Adapters
{
   /// <summary>
   /// Writes content to the console.
   /// </summary>
   public class ConsoleWriteAdapter : IWriteAdapter
   {
      /// <summary>
      /// Writes content to the console.
      /// </summary>
      /// <param name="content">The message to write.</param>
      public void Write(string content)
      {
         Console.WriteLine(content);
      }
   }
}
