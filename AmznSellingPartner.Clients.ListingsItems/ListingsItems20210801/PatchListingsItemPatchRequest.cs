namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpPatch("/listings/2021-08-01/items/{sellerId}/{sku}")]
	public class PatchListingsItemPatchRequest : BaseHttpRequest
	{
		/// <summary>
		/// A selling partner identifier, such as a merchant account or vendor code.
		/// </summary>
		[InPath("sellerId")]
		[IsRequired]
		public string SellerId { get; set; }

		/// <summary>
		/// A selling partner provided identifier for an Amazon listing.
		/// </summary>
		[InPath("sku")]
		[IsRequired]
		public string Sku { get; set; }

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers for the request.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// A comma-delimited list of data sets to include in the response. Default: `issues`.
		/// </summary>
		[InQuery("includedData")]
		public CsvValue<IncludedData> IncludedData { get; set; }

		/// <summary>
		/// The mode of operation for the request.
		/// </summary>
		[InQuery("mode")]
		public Mode Mode { get; set; }

		/// <summary>
		/// A locale for localization of issues. When not provided, the default language code of the first marketplace
		/// is used. Examples: `en_US`, `fr_CA`, `fr_FR`. Localized messages default to `en_US` when a localization
		/// is not available in the specified locale.
		/// </summary>
		[InQuery("issueLocale")]
		public string IssueLocale { get; set; }

		/// <summary>
		/// The request body schema for the `patchListingsItem` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public ListingsItemPatchRequest Body { get; set; }
	}
}
