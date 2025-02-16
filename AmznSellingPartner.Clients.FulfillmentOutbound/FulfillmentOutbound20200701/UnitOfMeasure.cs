namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnitOfMeasure
    {
        /// <summary>
        /// Specifies an integer count of units.
        /// </summary>
        [EnumMember(Value = "Eaches")]
        Eaches,
    }
}
