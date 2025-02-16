namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/catalog/2022-04-01/items")]
    public class AmznSearchCatalogItemsRequest : BaseHttpRequest
    {
        /// <summary>
        /// A comma-delimited list of product identifiers to search the Amazon catalog for. **Note:** Cannot
        /// be used with `keywords`.
        /// </summary>
        [InQuery("identifiers")]
        [MaxItems(20)]
        public CsvValue<string> Identifiers { get; set; }

        /// <summary>
        /// Type of product identifiers to search the Amazon catalog for. **Note:** Required when `identifiers`
        /// are provided.
        /// </summary>
        [InQuery("identifiersType")]
        public IdentifiersType IdentifiersType { get; set; }

        /// <summary>
        /// A comma-delimited list of Amazon marketplace identifiers for the request.
        /// </summary>
        [InQuery("marketplaceIds")]
        [IsRequired]
        [MaxItems(1)]
        public CsvValue<string> MarketplaceIds { get; set; }

        /// <summary>
        /// A comma-delimited list of data sets to include in the response. Default: `summaries`.
        /// </summary>
        [InQuery("includedData")]
        public CsvValue<IncludedData> IncludedData { get; set; }

        /// <summary>
        /// Locale for retrieving localized summaries. Defaults to the primary locale of the marketpla
        /// ce.
        /// </summary>
        [InQuery("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// A selling partner identifier, such as a seller account or vendor code. **Note:** Required when
        /// `identifiersType` is `SKU`.
        /// </summary>
        [InQuery("sellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// A comma-delimited list of words to search the Amazon catalog for. **Note:** Cannot be used
        /// with `identifiers`.
        /// </summary>
        [InQuery("keywords")]
        [MaxItems(20)]
        public CsvValue<string> Keywords { get; set; }

        /// <summary>
        /// A comma-delimited list of brand names to limit the search for `keywords`-based queries. **Note:**
        /// Cannot be used with `identifiers`.
        /// </summary>
        [InQuery("brandNames")]
        public CsvValue<string> BrandNames { get; set; }

        /// <summary>
        /// A comma-delimited list of classification identifiers to limit the search for `keywords`-based
        /// queries. **Note:** Cannot be used with `identifiers`.
        /// </summary>
        [InQuery("classificationIds")]
        public CsvValue<string> ClassificationIds { get; set; }

        /// <summary>
        /// Number of results to be returned per page.
        /// </summary>
        [InQuery("pageSize")]
        [Maximum(20)]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// A token to fetch a certain page when there are multiple pages worth of results.
        /// </summary>
        [InQuery("pageToken")]
        public string PageToken { get; set; }

        /// <summary>
        /// The language of the keywords provided for `keywords`-based queries. Defaults to the primary
        /// locale of the marketplace. **Note:** Cannot be used with `identifiers`.
        /// </summary>
        [InQuery("keywordsLocale")]
        public string KeywordsLocale { get; set; }
    }
}
