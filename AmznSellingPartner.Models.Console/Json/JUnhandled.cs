namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public class JUnhandled
    {
        [JsonExtensionData]
        private IDictionary<string, JToken> unhandled;

        [OnDeserialized]
        private void OnDeserialized(StreamingContext _)
        {
            if (this.unhandled?.Count > 0)
            {
                foreach (var (jpath, jtoken) in this.unhandled)
                {
                    JExtensions.NotifyUnhandledDataDetected(this.GetType().Name, jpath, jtoken);
                }
            }
        }
    }
}
