namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Unit of the weight being measured.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnitOfWeight
    {
        /// <summary>
        /// Pounds.
        /// </summary>
        [EnumMember(Value = "LB")]
        LB,

        /// <summary>
        /// Kilograms.
        /// </summary>
        [EnumMember(Value = "KG")]
        KG,
    }
}
