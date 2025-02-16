namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Unit of linear measure.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnitOfMeasurement
    {
        /// <summary>
        /// Inches.
        /// </summary>
        [EnumMember(Value = "IN")]
        IN,

        /// <summary>
        /// Centimeters.
        /// </summary>
        [EnumMember(Value = "CM")]
        CM,
    }
}
