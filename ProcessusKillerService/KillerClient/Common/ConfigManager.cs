using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Android.App;

namespace KillerClient.Common
{
    public static class ConfigManager
    {
        public static string ConfigFilePath = Path.Combine(Application.Context.FilesDir.Path, "Config.xml");

        public static bool ConfigFileExists => File.Exists(ConfigFilePath);

        public static XDocument CreateConfigFile()
        {
            if (ConfigFileExists)
                return XDocument.Load(ConfigFilePath);

            var dec = new XDeclaration("1.0", "utf-8", null);
            var doc = new XDocument(dec);
            doc.Add(new XElement("Config", new XElement("ServerAdress"), new XElement("ServerPort"), new XElement("ServerPin")));

            doc.Save(ConfigFilePath);

            return doc;
        }

        public static XDocument GetConfigFile()
        {
            return XDocument.Load(ConfigFilePath);
        }

        public static void SaveConfiguration(string serverAdress, string serverPort, string serverPin)
        {
            var doc = !ConfigFileExists ? CreateConfigFile() : GetConfigFile();

            if (doc == null) return;

            doc.Descendants("ServerAdress").FirstOrDefault().Value = serverAdress;
            doc.Descendants("ServerPort").FirstOrDefault().Value = serverPort;
            doc.Descendants("ServerPin").FirstOrDefault().Value = serverPin;

            doc.Save(ConfigFilePath);
        }

        public static Dictionary<string, string> LoadConfiguration()
        {
            if (!ConfigFileExists)
                CreateConfigFile();

            var doc = GetConfigFile();
            var dico = new Dictionary<string, string>
            {
                {"ServerAdress", doc.Descendants("ServerAdress").FirstOrDefault()?.Value},
                {"ServerPort", doc.Descendants("ServerPort").FirstOrDefault()?.Value},
                {"ServerPin", doc.Descendants("ServerPin").FirstOrDefault()?.Value}
            };
            return dico;
        }
    }
}