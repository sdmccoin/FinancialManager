using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace FinancialManagerLibrary.Services
{
    public sealed class ConfigurationService
    {
        private static readonly ConfigurationService instance = new ConfigurationService();

        static ConfigurationService() { }
        private ConfigurationService() { }

        public static ConfigurationService GetInstance { get { return instance; } }

        public NameValueCollection GetAllConfigItems()
        {
            return ConfigurationManager.AppSettings;
        }
    }
}
