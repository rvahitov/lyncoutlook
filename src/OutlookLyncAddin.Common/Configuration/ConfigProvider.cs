using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace OutlookLyncAddin.Common.Configuration
{
    public static class ConfigProvider
    {
        private const string AddinRefistryKeyPath = @"SOFTWARE\I-Teco\OutlookLyncAddin";
        private const string ConfigDirRegistryValue = "ConfigDir";
        private const string ConfigFileName = "addin.config.xml";

        private static readonly Lazy<OutlookLyncAddinConfig> ConfigInstance =
            new Lazy<OutlookLyncAddinConfig>(LoadConfig);

        public static OutlookLyncAddinConfig Config
        {
            get { return ConfigInstance.Value; }
        }

        private static string GetConfigFilePath()
        {
            var registryKey =
                Registry.LocalMachine.OpenSubKey(AddinRefistryKeyPath);
            Debug.Assert(registryKey != null, "registryKey != null");
            var configDirPath = Convert.ToString(registryKey.GetValue(ConfigDirRegistryValue, ""));
            if (string.IsNullOrEmpty(configDirPath)) return null;
            Debug.Assert(configDirPath != null, "configDirPath != null");
            var configPath = Path.Combine(configDirPath, ConfigFileName);
            return configPath;
        }

        private static OutlookLyncAddinConfig LoadConfig()
        {
            var configPath = GetConfigFilePath();
            if (string.IsNullOrEmpty(configPath)) return null;
            return OutlookLyncAddinConfig.FromXml(configPath);
        }
    }
}