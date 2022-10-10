using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.SmpleLogger.Contracts;

namespace TW.UnitTest.SimpleLogger.Mock
{
   public class MockWriter : IWriteAdapter
   {
      public string LastWrite
      {
         get;
         set;
      }
      public void Write(string content)
      {
         LastWrite = content;
      }
   }
}
