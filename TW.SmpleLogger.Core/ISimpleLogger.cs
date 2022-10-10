using TW.SmpleLogger.Contracts.Enums;

namespace TW.SmpleLogger.Contracts
{
   public interface ISimpleLogger
   {
      void Log(Severity sev, Granularity gran, string message);
   }
}