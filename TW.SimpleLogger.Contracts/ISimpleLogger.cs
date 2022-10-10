using TW.SimpleLogger.Contracts.Enums;

namespace TW.SimpleLogger.Contracts
{
   public interface ISimpleLogger
   {
      void Log(Severity sev, Granularity gran, string message);
   }
}