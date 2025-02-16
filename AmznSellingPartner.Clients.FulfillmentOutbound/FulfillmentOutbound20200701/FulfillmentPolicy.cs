namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The `FulfillmentPolicy` value specified when you submitted the `createFulfillmentOrder` op
    /// eration.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FulfillmentPolicy
    {
        /// <summary>
        /// If an item in a fulfillment order is determined to be unfulfillable before any shipment in
        /// the order has acquired the status of Pending (the process of picking units from inventory has
        /// begun), then the entire order is considered unfulfillable. However, if an item in a fulfillment
        /// order is determined to be unfulfillable after a shipment in the order has acquired the status
        /// of Pending, Amazon cancels as much of the fulfillment order as possible. Refer to the `FulfillmentShipment`
        /// object for shipment status definitions.
        /// </summary>
        [EnumMember(Value = "FillOrKill")]
        FillOrKill,

        /// <summary>
        /// All fulfillable items in the fulfillment order are shipped. The fulfillment order remains in
        /// a processing state until all items are either shipped by Amazon or cancelled by the seller
        /// .
        /// </summary>
        [EnumMember(Value = "FillAll")]
        FillAll,

        /// <summary>
        /// All fulfillable items in the fulfillment order are shipped. All unfulfillable items in the
        /// order are cancelled.
        /// </summary>
        [EnumMember(Value = "FillAllAvailable")]
        FillAllAvailable,
    }
}
