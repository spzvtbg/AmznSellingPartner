namespace AmznSellingPartner.Models.Console
{
    using AmznSellingPartner.Models.Console.Json;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            var parameters = new Dictionary<string, Dictionary<string, HashSet<JToken>>>();

            JSwagger.NotImplemented += (jtype, jpath, jtoken) =>
            {
                if (!parameters.ContainsKey(jtype))
                {
                    parameters[jtype] = [];
                }

                if (!parameters[jtype].ContainsKey(jpath))
                {
                    parameters[jtype][jpath] = [];
                }

                parameters[jtype][jpath].Add(jtoken);
            };

            foreach (var file in Directory.GetFiles("./models", "*.json", SearchOption.AllDirectories))
            {
                var json = File.ReadAllText(file)?.Replace("$", string.Empty);
                var jswagger = JsonConvert.DeserializeObject<JSwagger>(json);
            }

            var unhandled = JsonConvert.SerializeObject(parameters, Formatting.Indented);
            File.WriteAllText("../../../unhandled.json", unhandled);
        }
    }
}
