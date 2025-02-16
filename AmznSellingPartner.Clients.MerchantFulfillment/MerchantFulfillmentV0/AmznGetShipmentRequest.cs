namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/mfn/v0/shipments/{shipmentId}")]
    public class AmznGetShipmentRequest : BaseHttpRequest
    {
        /// <summary>
        /// The Amazon-defined shipment identifier for the shipment.
        /// </summary>
        [InPath("shipmentId")]
        [IsRequired]
        [Pattern("[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}")]
        public string ShipmentId { get; set; }
    }
}
