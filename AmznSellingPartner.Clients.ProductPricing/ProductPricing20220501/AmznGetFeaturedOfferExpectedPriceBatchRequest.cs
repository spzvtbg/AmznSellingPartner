namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/batches/products/pricing/2022-05-01/offer/featuredOfferExpectedPrice")]
    public class AmznGetFeaturedOfferExpectedPriceBatchRequest : BaseHttpRequest
    {
        /// <summary>
        /// The batch of `getFeaturedOfferExpectedPrice` requests.
        /// </summary>
        [InBody("getFeaturedOfferExpectedPriceBatchRequestBody")]
        [IsRequired]
        public GetFeaturedOfferExpectedPriceBatchRequest GetFeaturedOfferExpectedPriceBatchRequestBody { get; set; }
    }
}
