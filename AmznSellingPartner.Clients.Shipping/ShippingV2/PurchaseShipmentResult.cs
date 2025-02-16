namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The payload for the purchaseShipment operation.
    /// </summary>
    public class PurchaseShipmentResult : BaseClass
    {
        [JsonProperty("shipmentId")]
        [IsRequired]
        public ShipmentId ShipmentId { get; set; }

        [JsonProperty("packageDocumentDetails")]
        [IsRequired]
        public PackageDocumentDetailList PackageDocumentDetails { get; set; }

        [JsonProperty("promise")]
        [IsRequired]
        public Promise Promise { get; set; }
    }
}
