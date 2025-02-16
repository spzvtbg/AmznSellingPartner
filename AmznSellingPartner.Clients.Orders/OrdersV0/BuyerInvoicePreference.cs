namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuyerInvoicePreference
    {
        /// <summary>
        /// Issues an individual invoice to the buyer.
        /// </summary>
        [EnumMember(Value = "INDIVIDUAL")]
        INDIVIDUAL,

        /// <summary>
        /// Issues a business invoice to the buyer. Tax information is available in `BuyerTaxInformati
        /// on`.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        BUSINESS,
    }
}
