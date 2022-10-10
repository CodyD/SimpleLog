using TW.SimpleLogger.Contracts.Enums;

namespace TW.SimpleLogger.Contracts
{
   /// <summary>
   /// Data contract for logging.
   /// </summary>
   public interface ISimpleLogger
   {
      /// <summary>
      /// Logs a message for the provided parameters.
      /// </summary>
      /// <param name="sev">The severity to log.</param>
      /// <param name="gran">The granularity to include.</param>
      /// <param name="message">The message to include.</param>
      void Log(Severity sev, Granularity gran, string message);
   }
}