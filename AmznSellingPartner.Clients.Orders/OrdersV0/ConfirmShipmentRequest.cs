namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The request schema for an shipment confirmation.
    /// </summary>
    public class ConfirmShipmentRequest : BaseClass
    {
        [JsonProperty("packageDetail")]
        [IsRequired]
        public PackageDetail PackageDetail { get; set; }

        /// <summary>
        /// The COD collection method (only supported in the JP marketplace).
        /// </summary>
        [JsonProperty("codCollectionMethod")]
        public CodCollectionMethod CodCollectionMethod { get; set; }

        [JsonProperty("marketplaceId")]
        [IsRequired]
        public MarketplaceId MarketplaceId { get; set; }
    }
}
