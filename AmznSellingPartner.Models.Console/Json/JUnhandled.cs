namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public class JUnhandled
    {
        [JsonExtensionData]
        internal IDictionary<string, JToken> Unhandled { get; set; }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext _)
        {
            if (this.Unhandled?.Count > 0)
            {
                foreach (var (jpath, jtoken) in this.Unhandled)
                {
                    JSwagger.NotifyUnhandledDataDetected(this.GetType().Name, jpath, jtoken);
                }
            }
        }
    }
}
