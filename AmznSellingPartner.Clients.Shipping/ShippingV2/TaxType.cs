namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates the type of tax.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxType
    {
        /// <summary>
        /// Goods and Services Tax.
        /// </summary>
        [EnumMember(Value = "GST")]
        GST,
    }
}
