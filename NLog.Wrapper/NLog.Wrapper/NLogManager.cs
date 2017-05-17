using Common.Logging.Configuration;
using Common.Logging.NLog;

namespace NLog.Wrapper
{
    public class NLogManager
    {
        public static void Init()
        {
            Init("NLog.config");
        }

        public static void Init(string configFile)
        {
            global::Common.Logging.LogManager.Adapter = new NLogLoggerFactoryAdapter(new NameValueCollection { { "configFile", configFile } });
        }
    }
}
