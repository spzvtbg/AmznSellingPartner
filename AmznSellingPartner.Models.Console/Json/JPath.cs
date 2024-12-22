namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class JPath : JUnhandled
    {
        public JMethod Get { get; set; }

        public JMethod Delete { get; set; }

        public JMethod Patch { get; set; }

        public JMethod Post { get; set; }

        public JMethod Put { get; set; }

        public JParameter[] Parameters { get; set; }

        [JsonProperty("x-amzn-api-sandbox-only")]
        public bool SandboxOnly { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JSandbox Sandbox { get; set; }

        internal IEnumerable<string> GetTags()
        {
            var properties = typeof(JPath).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var tags = new HashSet<string>();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(JMethod))
                {
                    var value = property.GetValue(this);

                    if (value is JMethod method && method.Tags?.Length > 0)
                    {
                        foreach (var tag in method.Tags)
                        {
                            tags.Add(tag);
                        }
                    }
                }
            }

            return tags;
        }
    }
}