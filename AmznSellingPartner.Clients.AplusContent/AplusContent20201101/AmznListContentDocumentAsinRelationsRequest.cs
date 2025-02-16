namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/aplus/2020-11-01/contentDocuments/{contentReferenceKey}/asins")]
    public class AmznListContentDocumentAsinRelationsRequest : BaseHttpRequest
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
        /// The set of A+ Content data types to include in the response. If you do not include this parameter,
        /// the operation returns the related ASINs without metadata.
        /// </summary>
        [InQuery("includedDataSet")]
        [MinItems(0)]
        [UniqueItems]
        public CsvValue<IncludedDataSet> IncludedDataSet { get; set; }

        /// <summary>
        /// The set of ASINs.
        /// </summary>
        [InQuery("asinSet")]
        [UniqueItems]
        public CsvValue<string> AsinSet { get; set; }

        /// <summary>
        /// A page token from the nextPageToken response element returned by your previous call to this
        /// operation. nextPageToken is returned when the results of a call exceed the page size. To get
        /// the next page of results, call the operation and include pageToken as the only parameter. Specifying
        /// pageToken with any other parameter will cause the request to fail. When no nextPageToken value
        /// is returned there are no more pages to return. A pageToken value is not usable across different
        /// operations.
        /// </summary>
        [InQuery("pageToken")]
        [MinLength(1)]
        public string PageToken { get; set; }
    }
}
