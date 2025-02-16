namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        /// <summary>
        /// Sort in ascending order by purchase order creation date.
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,

        /// <summary>
        /// Sort in descending order by purchase order creation date.
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,
    }
}
