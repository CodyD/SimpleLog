using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.SimpleLogger.Contracts;

namespace TW.SimpleLogger.Library.Adapters
{
   public class ConsoleWriteAdapter : IWriteAdapter
   {
      public void Write(string content)
      {
         Console.WriteLine(content);
      }
   }
}
