namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/definitions/2020-09-01/productTypes")]
	public class SearchDefinitionsProductTypesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A comma-delimited list of keywords to search product types. **Note:** Cannot be used with `itemName`
		/// .
		/// </summary>
		[InQuery("keywords")]
		public CsvValue<string> Keywords { get; set; }

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers for the request.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The title of the ASIN to get the product type recommendation. **Note:** Cannot be used with `keyword
		/// s`.
		/// </summary>
		[InQuery("itemName")]
		public string ItemName { get; set; }

		/// <summary>
		/// The locale for the display names in the response. Defaults to the primary locale of the marketplace.
		/// </summary>
		[InQuery("locale")]
		public string Locale { get; set; }

		/// <summary>
		/// The locale used for the `keywords` and `itemName` parameters. Defaults to the primary locale of the
		/// marketplace.
		/// </summary>
		[InQuery("searchLocale")]
		public string SearchLocale { get; set; }
	}
}
