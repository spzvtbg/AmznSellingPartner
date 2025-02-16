namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeType
    {
        /// <summary>
        /// A tax imposed on a package.
        /// </summary>
        [EnumMember(Value = "TAX")]
        TAX,

        /// <summary>
        /// A discount deducted from the cost of a package.
        /// </summary>
        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT,
    }
}
