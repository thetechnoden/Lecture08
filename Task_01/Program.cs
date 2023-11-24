using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            configManager.SetSetting("LogLevel", "Info");
            configManager.SetSetting("ConnectionString", "mydb_connection_string");

            Console.WriteLine("Initial Configurations:");
            configManager.DisplaySettings();
            Console.WriteLine();

            configManager.SetSetting("LogLevel", "Debug");
            configManager.SetSetting("MaxConnections", "100");

            Console.WriteLine("Modified Configurations:");
            configManager.DisplaySettings();
        }
    }
}