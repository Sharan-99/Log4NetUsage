using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml;

namespace Log4NetUsage
{
    public class LoggerManager
    {
        private static readonly LoggerManager _instance = new LoggerManager();
        protected ILog monitoringLogger;
        protected static ILog debugLogger;

        public LoggerManager()
        {
            monitoringLogger = LogManager.GetLogger("MonitoringLogger");
            debugLogger = LogManager.GetLogger("DebugLogger");
        } 

        /*public LoggerManager(ILog log)
        {
            this.monitoringLogger = log;
        } */

        public void Info(string message)
        {
            _instance.monitoringLogger.Info(message);
        }
    }
}