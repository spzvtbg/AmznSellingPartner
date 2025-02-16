namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        /// <summary>
        /// An inbound plan that is being worked on.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        /// <summary>
        /// An inbound plan with all shipment cancelled and can no longer be modified.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED,

        /// <summary>
        /// A completed inbound plan. Only minor modifications can be made at this time.
        /// </summary>
        [EnumMember(Value = "SHIPPED")]
        SHIPPED,
    }
}
