namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/fba/inventory/v1/summaries")]
    public class AmznGetInventorySummariesRequest : BaseHttpRequest
    {
        /// <summary>
        /// true to return inventory summaries with additional summarized inventory details and quantities.
        /// Otherwise, returns inventory summaries only (default value).
        /// </summary>
        [InQuery("details")]
        public bool Details { get; set; } = false;

        /// <summary>
        /// The granularity type for the inventory aggregation level.
        /// </summary>
        [InQuery("granularityType")]
        [IsRequired]
        public GranularityType GranularityType { get; set; }

        /// <summary>
        /// The granularity ID for the inventory aggregation level.
        /// </summary>
        [InQuery("granularityId")]
        [IsRequired]
        public string GranularityId { get; set; }

        /// <summary>
        /// A start date and time in ISO8601 format. If specified, all inventory summaries that have changed
        /// since then are returned. You must specify a date and time that is no earlier than 18 months
        /// prior to the date and time when you call the API. Note: Changes in inboundWorkingQuantity,
        /// inboundShippedQuantity and inboundReceivingQuantity are not detected.
        /// </summary>
        [InQuery("startDateTime")]
        public DateTimeValue StartDateTime { get; set; }

        /// <summary>
        /// A list of seller SKUs for which to return inventory summaries. You may specify up to 50 SK
        /// Us.
        /// </summary>
        [InQuery("sellerSkus")]
        [MaxItems(50)]
        public CsvValue<string> SellerSkus { get; set; }

        /// <summary>
        /// A single seller SKU used for querying the specified seller SKU inventory summaries.
        /// </summary>
        [InQuery("sellerSku")]
        public string SellerSku { get; set; }

        /// <summary>
        /// String token returned in the response of your previous request. The string token will expire
        /// 30 seconds after being created.
        /// </summary>
        [InQuery("nextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// The marketplace ID for the marketplace for which to return inventory summaries.
        /// </summary>
        [InQuery("marketplaceIds")]
        [IsRequired]
        [MaxItems(1)]
        public CsvValue<string> MarketplaceIds { get; set; }
    }
}
