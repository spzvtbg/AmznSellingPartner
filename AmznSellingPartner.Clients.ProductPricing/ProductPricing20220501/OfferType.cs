namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OfferType
    {
        /// <summary>
        /// An offer that is available to all Amazon customers.
        /// </summary>
        [EnumMember(Value = "CONSUMER")]
        CONSUMER,
    }
}
