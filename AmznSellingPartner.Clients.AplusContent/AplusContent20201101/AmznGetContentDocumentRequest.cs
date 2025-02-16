namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/aplus/2020-11-01/contentDocuments/{contentReferenceKey}")]
    public class AmznGetContentDocumentRequest : BaseHttpRequest
    {
        /// <summary>
        /// The unique reference key for the A+ Content document. A content reference key cannot form a
        /// permalink and may change in the future. A content reference key is not guaranteed to match
        /// any A+ Content identifier.
        /// </summary>
        [InPath("contentReferenceKey")]
        [IsRequired]
        [MinLength(1)]
        public string ContentReferenceKey { get; set; }

        /// <summary>
        /// The identifier for the marketplace where the A+ Content is published.
        /// </summary>
        [InQuery("marketplaceId")]
        [IsRequired]
        [MinLength(1)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The set of A+ Content data types to include in the response.
        /// </summary>
        [InQuery("includedDataSet")]
        [IsRequired]
        [MinItems(1)]
        [UniqueItems]
        public CsvValue<IncludedDataSet> IncludedDataSet { get; set; }
    }
}
