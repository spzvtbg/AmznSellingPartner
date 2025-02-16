namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/awd/2024-05-09/inboundShipments/{shipmentId}")]
    public class AmznGetInboundShipmentRequest : BaseHttpRequest
    {
        /// <summary>
        /// ID for the shipment. A shipment contains the cases being inbounded.
        /// </summary>
        [InPath("shipmentId")]
        [IsRequired]
        [MinLength(1)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// If equal to `SHOW`, the response includes the shipment SKU quantity details.  Defaults to `HIDE`,
        /// in which case the response does not contain SKU quantities
        /// </summary>
        [InQuery("skuQuantities")]
        public SkuQuantities SkuQuantities { get; set; }
    }
}
