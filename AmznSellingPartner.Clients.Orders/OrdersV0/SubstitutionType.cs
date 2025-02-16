namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubstitutionType
    {
        /// <summary>
        /// Customer has provided the substitution preferences.
        /// </summary>
        [EnumMember(Value = "CUSTOMER_PREFERENCE")]
        CUSTOMER_PREFERENCE,

        /// <summary>
        /// Amazon has provided the substitution preferences.
        /// </summary>
        [EnumMember(Value = "AMAZON_RECOMMENDED")]
        AMAZON_RECOMMENDED,

        /// <summary>
        /// Do not provide a substitute if item is not found.
        /// </summary>
        [EnumMember(Value = "DO_NOT_SUBSTITUTE")]
        DO_NOT_SUBSTITUTE,
    }
}
