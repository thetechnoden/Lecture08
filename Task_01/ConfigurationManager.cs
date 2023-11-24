using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager? instance;
        private Dictionary<string, string> settings;

        private ConfigurationManager()
        {
            settings = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public void SetSetting(string key, string value)
        {
            settings[key] = value;
        }

        public string? GetSetting(string key)
        {
            return settings.ContainsKey(key) ? settings[key] : null;
        }

        public void DisplaySettings()
        {
            foreach (var setting in settings)
            {
                Console.WriteLine($"{setting.Key}: {setting.Value}");
            }
        }
    }
}
