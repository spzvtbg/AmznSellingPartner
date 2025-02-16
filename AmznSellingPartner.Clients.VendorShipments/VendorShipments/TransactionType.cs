namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionType
    {
        /// <summary>
        /// Initial shipment Request.
        /// </summary>
        [EnumMember(Value = "New")]
        New,

        /// <summary>
        /// Cancel existing shipment Request message. should be used only to cancel Shipment request
        /// </summary>
        [EnumMember(Value = "Cancel")]
        Cancel,

        /// <summary>
        /// Confirm the original Transport Request confirmation message.
        /// </summary>
        [EnumMember(Value = "Confirm")]
        Confirm,

        /// <summary>
        /// Label request the original Transport Request confirmation message.
        /// </summary>
        [EnumMember(Value = "PackageLabelRequest")]
        PackageLabelRequest,
    }
}
