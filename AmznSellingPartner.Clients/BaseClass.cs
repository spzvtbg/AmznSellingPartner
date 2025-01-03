namespace AmznSellingPartner.Clients
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;

    public class BaseClass
    {
        [JsonExtensionData]
        protected Dictionary<string, JToken> UnhandledData { get; set; }
    }
}
