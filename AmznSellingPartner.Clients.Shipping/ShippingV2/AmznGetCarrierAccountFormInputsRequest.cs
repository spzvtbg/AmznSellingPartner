namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;

    [HttpGet("/shipping/v2/carrierAccountFormInputs")]
    public class AmznGetCarrierAccountFormInputsRequest : BaseHttpRequest
    {
        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
