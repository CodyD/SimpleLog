using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.SmpleLogger.Contracts
{
   public interface IWriteAdapter
   {
      void Write(string content);
   }
}
