using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.SmpleLogger.Contracts.Enums
{
   [Flags]
   public enum Granularity
   {
      Simple = 0,
      Verbose = 1,
      UserInfo = Verbose << 1,
      SystemInfo = UserInfo << 1
   }
}
