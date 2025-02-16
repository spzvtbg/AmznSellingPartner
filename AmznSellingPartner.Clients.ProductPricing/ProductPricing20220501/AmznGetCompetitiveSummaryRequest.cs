namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/batches/products/pricing/2022-05-01/items/competitiveSummary")]
    public class AmznGetCompetitiveSummaryRequest : BaseHttpRequest
    {
        /// <summary>
        /// The batch of `getCompetitiveSummary` requests.
        /// </summary>
        [InBody("requests")]
        [IsRequired]
        public CompetitiveSummaryBatchRequest Requests { get; set; }
    }
}
