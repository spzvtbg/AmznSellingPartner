namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        /// <summary>
        /// Sort in descending order.
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,

        /// <summary>
        /// Sort in ascending order.
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,
    }
}
