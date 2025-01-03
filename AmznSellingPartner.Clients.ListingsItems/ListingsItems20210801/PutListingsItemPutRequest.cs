namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpPut("/listings/2021-08-01/items/{sellerId}/{sku}")]
	public class PutListingsItemPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// A selling partner identifier, such as a merchant account or vendor code.
		/// </summary>
		[InPath("sellerId")]
		[IsRequired]
		[JsonProperty("sellerId")]
		public string SellerId { get; set; }

		/// <summary>
		/// A selling partner provided identifier for an Amazon listing.
		/// </summary>
		[InPath("sku")]
		[IsRequired]
		[JsonProperty("sku")]
		public string Sku { get; set; }

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers for the request.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// A comma-delimited list of data sets to include in the response. Default: `issues`.
		/// </summary>
		[InQuery("includedData")]
		[JsonProperty("includedData")]
		public CsvValue<IncludedData> IncludedData { get; set; }

		/// <summary>
		/// The mode of operation for the request.
		/// </summary>
		[InQuery("mode")]
		[JsonProperty("mode")]
		public Mode Mode { get; set; }

		/// <summary>
		/// A locale for localization of issues. When not provided, the default language code of the first marketplace is
		/// sed. Examples: `en_US`, `fr_CA`, `fr_FR`. Localized messages default to `en_US` when a localization is not ava
		/// lable in the specified locale.
		/// </summary>
		[InQuery("issueLocale")]
		[JsonProperty("issueLocale")]
		public string IssueLocale { get; set; }

		/// <summary>
		/// The request body schema for the `putListingsItem` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public ListingsItemPutRequest Body { get; set; }
	}
}
