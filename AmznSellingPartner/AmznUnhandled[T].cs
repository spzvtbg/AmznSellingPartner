namespace AmznSellingPartner
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;
    using System.Runtime.Serialization;

    internal class AmznUnhandled<T> : Dictionary<string, T>
    {
        [JsonExtensionData]
        private Dictionary<string, JToken> unhandledData = [];

        [OnDeserialized]
        private void OnDeserialized(StreamingContext _)
        {
            if (this.unhandledData?.Count > 0)
            {
                var type = this.GetType().Name;

                foreach (var (field, value) in this.unhandledData)
                {
                    AmznModel.NotifyUnhandledData(type, field, value);
                }
            }
        }
    }
}
