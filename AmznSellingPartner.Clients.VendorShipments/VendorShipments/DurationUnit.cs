namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DurationUnit
    {
        /// <summary>
        /// Days
        /// </summary>
        [EnumMember(Value = "Days")]
        Days,

        /// <summary>
        /// Months
        /// </summary>
        [EnumMember(Value = "Months")]
        Months,
    }
}
