using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.SimpleLogger.Contracts;

namespace TW.SimpleLogger.Library.Adapters
{
   public class MemoryFileWriteAdapter : IWriteAdapter
   {
      public MemoryMappedFile File
      {
         get;
         set;
      }

      public void Write(string content)
      {
         using (var io = File.CreateViewAccessor())
         {
            if(io.CanWrite) {
               byte[] buffer = ASCIIEncoding.ASCII.GetBytes(content);
               io.WriteArray(0, buffer, 0, buffer.Length);
            }
         }
      }
   }
}
