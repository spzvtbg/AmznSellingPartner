namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        /// <summary>
        /// Ascending order.
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,

        /// <summary>
        /// Descending order.
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,
    }
}
