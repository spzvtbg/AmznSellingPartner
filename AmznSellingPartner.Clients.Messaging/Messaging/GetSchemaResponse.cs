namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using Newtonsoft.Json;

    /// <summary>
    /// The `GET` request schema response.
    /// </summary>
    public class GetSchemaResponse : BaseClass
    {
        /// <summary>
        /// The links response that is associated with the object.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("payload")]
        public Schema Payload { get; set; }

        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
