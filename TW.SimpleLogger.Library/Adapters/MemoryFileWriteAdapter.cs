using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.SimpleLogger.Contracts;

namespace TW.SimpleLogger.Library.Adapters
{
   /// <summary>
   /// Writes content into a memory mapped file.
   /// Relatively fast, in terms of file IO.
   /// </summary>
   public class MemoryFileWriteAdapter : IWriteAdapter, IDisposable
   {
      /// <summary>
      /// The file to write to.
      /// </summary>
      protected readonly MemoryMappedFile _file;
      /// <summary>
      /// 
      /// </summary>
      /// <param name="filePath"></param>
      public MemoryFileWriteAdapter(string mapName, int memorySizeBytes)
      {
         _file = MemoryMappedFile.CreateNew(mapName, memorySizeBytes);
      }

      /// <summary>
      /// Releases the resources.
      /// </summary>
      public void Dispose()
      {
         //TODO implement disposal pattern here
         _file?.Dispose();
      }

      /// <summary>
      /// Writes the content to file.
      /// </summary>
      /// <param name="content">The content to write.</param>
      public void Write(string content)
      {
         using (var io = _file.CreateViewAccessor())
         {
            if(io.CanWrite) {
               byte[] buffer = ASCIIEncoding.ASCII.GetBytes(content);
               io.WriteArray(0, buffer, 0, buffer.Length);
            }
         }
      }

      /// <summary>
      /// Writes the content in an asynchronous manner. Not implemented.
      /// </summary>
      /// <param name="content">The content to write.</param>
      /// <returns>The asynchronous task.</returns>
      /// <exception cref="NotImplementedException"></exception>
      public async Task WriteAsync(string content)
      {
         throw new NotImplementedException();
      }
   }
}
