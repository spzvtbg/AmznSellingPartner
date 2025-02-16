namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/shipping/v2/collectionForms/{collectionFormId}")]
    public class AmznGetCollectionFormRequest : BaseHttpRequest
    {
        /// <summary>
        /// collection form Id to reprint a collection.
        /// </summary>
        [InPath("collectionFormId")]
        [IsRequired]
        public string CollectionFormId { get; set; }

        /// <summary>
        /// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
        /// </summary>
        [InHeader("x-amzn-shipping-business-id")]
        public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
    }
}
