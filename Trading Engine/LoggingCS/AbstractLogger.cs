using LoggingCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    abstract class AbstractLogger : ILogger
    {

        protected abstract void Log(LogLevels logLevels, string module, string message);
        public void Debug(string module, string message) => Log(LogLevels.Debug, module, message);
        public void Debug(string module, Exception exception) => Log(LogLevels.Debug, module, $"{exception}");
        public void Error(string module, string message) => Log(LogLevels.Debug, module, message);
        public void Error(string module, Exception exception) => Log(LogLevels.Debug, module, $"{exception}");
        public void Information(string module, string message) => Log(LogLevels.Debug, module, message);
        public void Information(string module, Exception exception) => Log(LogLevels.Debug, module, $"{exception}");
        public void Warning(string module, string message) => Log(LogLevels.Debug, module, message);
        public void Warning(string module, Exception exception) => Log(LogLevels.Debug, module, $"{exception}");

    }
}
