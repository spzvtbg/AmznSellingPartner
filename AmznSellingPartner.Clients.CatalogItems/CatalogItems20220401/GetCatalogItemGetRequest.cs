namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/catalog/2022-04-01/items/{asin}")]
	public class GetCatalogItemGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item
		/// </summary>
		[InPath("asin")]
		[IsRequired]
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers
		/// Data sets in the response contain data only for the specified marketplaces
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// A comma-delimited list of data sets to include in the response
		/// Default: `summaries`
		/// </summary>
		[InQuery("includedData")]
		[JsonProperty("includedData")]
		public CsvValue<IncludedData> IncludedData { get; set; }

		/// <summary>
		/// Locale for retrieving localized summaries
		/// Defaults to the primary locale of the marketplace
		/// </summary>
		[InQuery("locale")]
		[JsonProperty("locale")]
		public string Locale { get; set; }
	}
}
