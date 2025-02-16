namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/inbound/fba/2024-03-20/items/compliance")]
    public class AmznUpdateItemComplianceDetailsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://deve
        /// loper-docs.amazon.com/sp-api/docs/marketplace-ids).
        /// </summary>
        [InQuery("marketplaceId")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(20)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The body of the request to `updateItemComplianceDetails`.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public UpdateItemComplianceDetailsRequest Body { get; set; }
    }
}
