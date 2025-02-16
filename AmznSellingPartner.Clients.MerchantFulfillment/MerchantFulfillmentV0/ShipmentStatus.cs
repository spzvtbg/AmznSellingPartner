namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The shipment status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShipmentStatus
    {
        /// <summary>
        /// The seller purchased a label by calling the `createShipment` operation.
        /// </summary>
        [EnumMember(Value = "Purchased")]
        Purchased,

        /// <summary>
        /// The seller requested a label refund by calling the `cancelShipment` operation, and the refund
        /// request is being processed by the carrier. Note: A seller can create a new shipment for an
        /// order while `Status = RefundPending` for a canceled shipment. After you request a label refund
        /// (by calling `cancelShipment`), the status of the order remains `Shipped`.
        /// </summary>
        [EnumMember(Value = "RefundPending")]
        RefundPending,

        /// <summary>
        /// The label refund request is rejected by the carrier. A refund request is rejected because the
        /// cancellation window has expired or the carrier has already accepted the shipment for delivery.
        /// Cancellation policies vary by carrier. For more information about carrier cancellation policies,
        /// refer to the Seller Central Help for your marketplace.
        /// </summary>
        [EnumMember(Value = "RefundRejected")]
        RefundRejected,

        /// <summary>
        /// The refund has been approved and credited to the seller's account.
        /// </summary>
        [EnumMember(Value = "RefundApplied")]
        RefundApplied,
    }
}
