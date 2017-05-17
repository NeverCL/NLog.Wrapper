using System.IO;
using Common.Logging.Configuration;
using Common.Logging.NLog;

namespace NLog.Wrapper
{
    /// <summary>
    /// NLog 管理类
    /// </summary>
    public class NLogManager
    {
        public static void Init()
        {
            // Common.Logging 已内置文件存在判断等前置逻辑
            Init("NLog.config");
        }

        public static void Init(string configFile)
        {
            global::Common.Logging.LogManager.Adapter = new NLogLoggerFactoryAdapter(new NameValueCollection { { "configFile", configFile } });
        }
    }
}
