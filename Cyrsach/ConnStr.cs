//создание поля ConnStr
using System.Configuration;

namespace Cyrsach
{
    internal class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Cyrsach.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}