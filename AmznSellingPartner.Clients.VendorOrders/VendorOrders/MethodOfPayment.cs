namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MethodOfPayment
    {
        /// <summary>
        /// Buyer pays for shipping.
        /// </summary>
        [EnumMember(Value = "PaidByBuyer")]
        PaidByBuyer,

        /// <summary>
        /// Buyer pays for shipping on delivery.
        /// </summary>
        [EnumMember(Value = "CollectOnDelivery")]
        CollectOnDelivery,

        /// <summary>
        /// Shipping costs paid as agreed upon between buyer and seller.
        /// </summary>
        [EnumMember(Value = "DefinedByBuyerAndSeller")]
        DefinedByBuyerAndSeller,

        /// <summary>
        /// Seller pays for transportation including loading and shipping.
        /// </summary>
        [EnumMember(Value = "FOBPortOfCall")]
        FOBPortOfCall,

        /// <summary>
        /// Seller prepays for shipping.
        /// </summary>
        [EnumMember(Value = "PrepaidBySeller")]
        PrepaidBySeller,

        /// <summary>
        /// Seller pays for shipping.
        /// </summary>
        [EnumMember(Value = "PaidBySeller")]
        PaidBySeller,
    }
}
