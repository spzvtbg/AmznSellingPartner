namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientReferenceType
    {
        /// <summary>
        /// The unique identifier assigned to a 3P seller by the shipping integrator.
        /// </summary>
        [EnumMember(Value = "IntegratorShipperId")]
        IntegratorShipperId,

        /// <summary>
        /// The unique identifier assigned to a 3P shipping integrator by Amazon.
        /// </summary>
        [EnumMember(Value = "IntegratorMerchantId")]
        IntegratorMerchantId,
    }
}
