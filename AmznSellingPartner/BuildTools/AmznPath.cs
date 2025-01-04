namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class AmznPath : AmznUnhandled
    {
        private static readonly Dictionary<string, Func<object, object>> actionGetters
              = typeof(AmznPath).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                .Where(x => x.PropertyType == typeof(AmznAction))
                                .ToDictionary(x => x.Name, x => (Func<object, object>)x.GetValue);

        public AmznAction Delete { get; set; }

        public AmznAction Get { get; set; }

        public AmznAction Patch { get; set; }

        public AmznAction Post { get; set; }

        public AmznAction Put { get; set; }

        public AmznParameter[] Parameters { get; set; }

        [JsonProperty("x-amzn-api-sandbox-only")]
        public bool? SandboxOnly { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JToken Sandbox { get; set; }

        internal void OnDeserialized(string route, CsContext context, AmznParameters parameters)
        {
            foreach (var (method, getter) in actionGetters)
            {
                if (getter(this) is AmznAction action)
                {
                    action.OnDeserialized(method, route, context, parameters);
                }
            }
        }
    }
}