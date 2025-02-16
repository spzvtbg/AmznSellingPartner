namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The current delivery status of the package.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrentStatus
    {
        /// <summary>
        /// In transit to the destination address.
        /// </summary>
        [EnumMember(Value = "IN_TRANSIT")]
        IN_TRANSIT,

        /// <summary>
        /// Delivered to the destination address.
        /// </summary>
        [EnumMember(Value = "DELIVERED")]
        DELIVERED,

        /// <summary>
        /// In the process of being returned to Amazon's fulfillment network.
        /// </summary>
        [EnumMember(Value = "RETURNING")]
        RETURNING,

        /// <summary>
        /// Returned to Amazon's fulfillment network.
        /// </summary>
        [EnumMember(Value = "RETURNED")]
        RETURNED,

        /// <summary>
        /// Undeliverable because package was lost or destroyed.
        /// </summary>
        [EnumMember(Value = "UNDELIVERABLE")]
        UNDELIVERABLE,

        /// <summary>
        /// Delayed.
        /// </summary>
        [EnumMember(Value = "DELAYED")]
        DELAYED,

        /// <summary>
        /// Available for pickup.
        /// </summary>
        [EnumMember(Value = "AVAILABLE_FOR_PICKUP")]
        AVAILABLE_FOR_PICKUP,

        /// <summary>
        /// Requires customer action.
        /// </summary>
        [EnumMember(Value = "CUSTOMER_ACTION")]
        CUSTOMER_ACTION,

        /// <summary>
        /// Unknown Status Code was returned.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Out for Delivery.
        /// </summary>
        [EnumMember(Value = "OUT_FOR_DELIVERY")]
        OUT_FOR_DELIVERY,

        /// <summary>
        /// Delivery Attempted.
        /// </summary>
        [EnumMember(Value = "DELIVERY_ATTEMPTED")]
        DELIVERY_ATTEMPTED,

        /// <summary>
        /// Pickup Successful.
        /// </summary>
        [EnumMember(Value = "PICKUP_SUCCESSFUL")]
        PICKUP_SUCCESSFUL,

        /// <summary>
        /// Pickup Cancelled.
        /// </summary>
        [EnumMember(Value = "PICKUP_CANCELLED")]
        PICKUP_CANCELLED,

        /// <summary>
        /// Pickup Attempted.
        /// </summary>
        [EnumMember(Value = "PICKUP_ATTEMPTED")]
        PICKUP_ATTEMPTED,

        /// <summary>
        /// Pickup Scheduled.
        /// </summary>
        [EnumMember(Value = "PICKUP_SCHEDULED")]
        PICKUP_SCHEDULED,

        /// <summary>
        /// Return Request Accepted.
        /// </summary>
        [EnumMember(Value = "RETURN_REQUEST_ACCEPTED")]
        RETURN_REQUEST_ACCEPTED,

        /// <summary>
        /// Refund Issued.
        /// </summary>
        [EnumMember(Value = "REFUND_ISSUED")]
        REFUND_ISSUED,

        /// <summary>
        /// Return Received In FC.
        /// </summary>
        [EnumMember(Value = "RETURN_RECEIVED_IN_FC")]
        RETURN_RECEIVED_IN_FC,
    }
}
