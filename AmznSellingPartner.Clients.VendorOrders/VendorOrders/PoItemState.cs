namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoItemState
    {
        /// <summary>
        /// Status for order items cancelled by vendors.
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,
    }
}
