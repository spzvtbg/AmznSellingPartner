namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/shipping/v2/shipments/{shipmentId}/cancel")]
    public class AmznCancelShipmentRequest : BaseHttpRequest
    {
        /// <summary>
        /// The shipment identifier originally returned by the purchaseShipment operation.
        /// </summary>
        [InPath("shipmentId")]
        [IsRequired]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
