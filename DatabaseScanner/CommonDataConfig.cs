using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DatabaseScanner
{
    /// <summary>
    /// 数据库连接字符串配置类
    /// </summary>
    public class CommonDataConfig
    {
        public static string ConnectionDefaultStr=ConfigurationSettings.AppSettings["ConnStr"];

        public CommonDataConfig()
        {
            try
            {
                ConnectionDefaultStr=ConfigurationSettings.AppSettings["ConnStr"];

            }
            catch
            {
                ConnectionDefaultStr = null;

            }
        }
    }
}
