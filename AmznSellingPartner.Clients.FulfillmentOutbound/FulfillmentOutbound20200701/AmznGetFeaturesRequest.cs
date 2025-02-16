namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/fba/outbound/2020-07-01/features")]
    public class AmznGetFeaturesRequest : BaseHttpRequest
    {
        /// <summary>
        /// The marketplace for which to return the list of features.
        /// </summary>
        [InQuery("marketplaceId")]
        [IsRequired]
        public string MarketplaceId { get; set; }
    }
}
