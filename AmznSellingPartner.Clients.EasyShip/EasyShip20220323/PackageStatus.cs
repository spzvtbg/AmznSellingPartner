namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The status of the package.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageStatus
    {
        /// <summary>
        /// The package is ready for pickup.
        /// </summary>
        [EnumMember(Value = "ReadyForPickup")]
        ReadyForPickup,

        /// <summary>
        /// The package has been picked up.
        /// </summary>
        [EnumMember(Value = "PickedUp")]
        PickedUp,

        /// <summary>
        /// The package is at its origin fulfillment center.
        /// </summary>
        [EnumMember(Value = "AtOriginFC")]
        AtOriginFC,

        /// <summary>
        /// The package is at its destination fulfillment center.
        /// </summary>
        [EnumMember(Value = "AtDestinationFC")]
        AtDestinationFC,

        /// <summary>
        /// The package has been delivered.
        /// </summary>
        [EnumMember(Value = "Delivered")]
        Delivered,

        /// <summary>
        /// The package has been rejected.
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected,

        /// <summary>
        /// The package is not deliverable.
        /// </summary>
        [EnumMember(Value = "Undeliverable")]
        Undeliverable,

        /// <summary>
        /// The package has been returned to the seller.
        /// </summary>
        [EnumMember(Value = "ReturnedToSeller")]
        ReturnedToSeller,

        /// <summary>
        /// The package has been lost in transit.
        /// </summary>
        [EnumMember(Value = "LostInTransit")]
        LostInTransit,

        /// <summary>
        /// The package's label has been canceled.
        /// </summary>
        [EnumMember(Value = "LabelCanceled")]
        LabelCanceled,

        /// <summary>
        /// The package has been damaged in transit.
        /// </summary>
        [EnumMember(Value = "DamagedInTransit")]
        DamagedInTransit,

        /// <summary>
        /// The package is out for delivery.
        /// </summary>
        [EnumMember(Value = "OutForDelivery")]
        OutForDelivery,
    }
}
