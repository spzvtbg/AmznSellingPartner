namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/shipping/v2/shipments/additionalInputs/schema")]
    public class AmznGetAdditionalInputsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request token returned in the response to the getRates operation.
        /// </summary>
        [InQuery("requestToken")]
        [IsRequired]
        public string RequestToken { get; set; }

        /// <summary>
        /// The rate identifier for the shipping offering (rate) returned in the response to the getRates
        /// operation.
        /// </summary>
        [InQuery("rateId")]
        [IsRequired]
        public string RateId { get; set; }

        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
