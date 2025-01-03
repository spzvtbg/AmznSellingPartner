namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `createMarketplaceItemLabels` request.
	/// </summary>
	public class CreateMarketplaceItemLabelsRequest : BaseClass
	{
		/// <summary>
		/// The height of the item label.
		/// </summary>
		[Minimum(25)]
		[Maximum(100)]
		[JsonProperty("height")]
		public double Height { get; set; }

		[IsRequired]
		[JsonProperty("labelType")]
		public LabelPrintType LabelType { get; set; }

		/// <summary>
		/// The locale code constructed from ISO 639 language code and ISO 3166-1 alpha-2 standard of country codes separa
		/// ed by an underscore character.
		/// </summary>
		[Pattern("^[a-z]{2}_[A-Z]{2}")]
		[JsonProperty("localeCode")]
		public string LocaleCode { get; set; }

		/// <summary>
		/// The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.co
		/// /sp-api/docs/marketplace-ids).
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Represents the quantity of an MSKU to print item labels for.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(100)]
		[JsonProperty("mskuQuantities")]
		public List<MskuQuantity> MskuQuantities { get; set; }

		[JsonProperty("pageType")]
		public ItemLabelPageType PageType { get; set; }

		/// <summary>
		/// The width of the item label.
		/// </summary>
		[Minimum(25)]
		[Maximum(100)]
		[JsonProperty("width")]
		public double Width { get; set; }
	}
}
