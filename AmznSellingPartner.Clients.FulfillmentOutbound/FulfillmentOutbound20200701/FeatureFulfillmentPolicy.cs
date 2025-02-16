namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureFulfillmentPolicy
    {
        /// <summary>
        /// If the offer can't be shipped with the selected feature, reject the order.
        /// </summary>
        [EnumMember(Value = "Required")]
        Required,

        /// <summary>
        /// The feature is not required for shipping.
        /// </summary>
        [EnumMember(Value = "NotRequired")]
        NotRequired,
    }
}
