namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/shipping/v2/shipments")]
    public class AmznPurchaseShipmentRequest : BaseHttpRequest
    {
        [InBody("body")]
        [IsRequired]
        public PurchaseShipmentRequest Body { get; set; }

        /// <summary>
        /// A unique value which the server uses to recognize subsequent retries of the same request.
        /// </summary>
        [InHeader("x-amzn-IdempotencyKey")]
        public string XAmznIdempotencyKey { get; set; }

        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
