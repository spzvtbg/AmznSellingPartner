namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/shipping/v2/carrierAccounts/{carrierId}")]
    public class AmznLinkCarrierAccountRequest : BaseHttpRequest
    {
        /// <summary>
        /// The unique identifier associated with the carrier account.
        /// </summary>
        [InPath("carrierId")]
        [IsRequired]
        public string CarrierId { get; set; }

        [InBody("body")]
        [IsRequired]
        public LinkCarrierAccountRequest Body { get; set; }

        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
