namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Name
    {
        /// <summary>
        /// Estimated fee for each unit in the fulfillment order.
        /// </summary>
        [EnumMember(Value = "FBAPerUnitFulfillmentFee")]
        FBAPerUnitFulfillmentFee,

        /// <summary>
        /// Estimated order-level fee.
        /// </summary>
        [EnumMember(Value = "FBAPerOrderFulfillmentFee")]
        FBAPerOrderFulfillmentFee,

        /// <summary>
        /// Estimated shipping fee.
        /// </summary>
        [EnumMember(Value = "FBATransportationFee")]
        FBATransportationFee,

        /// <summary>
        /// Estimated COD (Cash On Delivery) fee. This fee applies only to fulfillment order previews for
        /// COD.
        /// </summary>
        [EnumMember(Value = "FBAFulfillmentCODFee")]
        FBAFulfillmentCODFee,
    }
}
