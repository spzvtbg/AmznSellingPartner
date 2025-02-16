namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortBy
    {
        /// <summary>
        /// Last updated time of the inbound plan.
        /// </summary>
        [EnumMember(Value = "LAST_UPDATED_TIME")]
        LAST_UPDATED_TIME,

        /// <summary>
        /// Inbound plan creation time.
        /// </summary>
        [EnumMember(Value = "CREATION_TIME")]
        CREATION_TIME,
    }
}
