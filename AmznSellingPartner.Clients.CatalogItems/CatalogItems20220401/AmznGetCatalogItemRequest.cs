namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/catalog/2022-04-01/items/{asin}")]
    public class AmznGetCatalogItemRequest : BaseHttpRequest
    {
        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        [InPath("asin")]
        [IsRequired]
        public string Asin { get; set; }

        /// <summary>
        /// A comma-delimited list of Amazon marketplace identifiers. Data sets in the response contain
        /// data only for the specified marketplaces.
        /// </summary>
        [InQuery("marketplaceIds")]
        [IsRequired]
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
    }
}
