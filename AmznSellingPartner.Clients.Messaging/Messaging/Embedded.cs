namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    public class Embedded : BaseClass
    {
        [JsonProperty("actions")]
        [IsRequired]
        public List<GetMessagingActionResponse> Actions { get; set; }

        [JsonProperty("schema")]
        public GetSchemaResponse Schema { get; set; }
    }
}
