namespace AmznSellingPartner.Clients.Notifications.Notifications
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The supported order change type of ORDER_CHANGE notification.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderChangeTypeEnum
    {
        [EnumMember(Value = "OrderStatusChange")]
        OrderStatusChange,

        [EnumMember(Value = "BuyerRequestedChange")]
        BuyerRequestedChange,
    }
}
