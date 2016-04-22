using System;
using System.Collections.Generic;
using System.IO;
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

            var doc = new XDocument();
            doc.Add(new XDeclaration("1.0", "utf-8", null));
            doc.Add(new XElement("Config"), new XElement("ServerAdress"), new XElement("ServerPort"), new XElement("ServerPin"));
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

            doc.Element("ServerAdress").Value = serverAdress;
            doc.Element("ServerPort").Value = serverPort;
            doc.Element("ServerPin").Value = serverPin;

            doc.Save(ConfigFilePath);
        }

        public static Dictionary<string, string> LoadConfiguration()
        {
            if (!ConfigFileExists)
                CreateConfigFile();

            var doc = GetConfigFile();
            var dico = new Dictionary<string, string>();
            dico.Add("ServerAdress", doc.Element("ServerAdress").Value);
            dico.Add("ServerPort", doc.Element("ServerPort").Value);
            dico.Add("ServerPin", doc.Element("ServerPin").Value);
            return dico;
        }
    }
}