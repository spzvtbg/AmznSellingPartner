namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/shipping/v2/oneClickShipment")]
    public class AmznOneClickShipmentRequest : BaseHttpRequest
    {
        [InBody("body")]
        [IsRequired]
        public OneClickShipmentRequest Body { get; set; }

        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
