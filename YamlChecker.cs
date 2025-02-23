using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.Windows.Forms;

namespace RMBackground
{
    internal static class YamlChecker
    {
        private const string yamlFilePath = "APIKey.yaml";
        private const string key = "API_Key";

        public static Type GetNextForm()
        {
            if (!File.Exists(yamlFilePath))
            {
                Console.WriteLine("Le fichier YAML n'existe pas.");
                return typeof(NoAPIkey);
            }

            string yamlContent = File.ReadAllText(yamlFilePath);
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var data = deserializer.Deserialize<Dictionary<string, object>>(yamlContent);

            if (data.ContainsKey(key) && !string.IsNullOrEmpty(data[key]?.ToString()))
            {
                return typeof(MainForm);
            }

            return typeof(NoAPIkey);
        }
    }
}
