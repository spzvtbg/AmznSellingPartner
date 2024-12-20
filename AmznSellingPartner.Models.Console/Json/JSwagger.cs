namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json.Linq;

    using System;

    public class JSwagger
    {
        public static event Action<string, string, JToken> NotImplemented;

        public JPaths Paths { get; set; }

        public JDefinitions Definitions { get; set; }

        internal static void NotifyUnhandledDataDetected(string jtype, string jpath, JToken jtoken)
            => NotImplemented?.Invoke(jtype, jpath, jtoken);
    }
}
