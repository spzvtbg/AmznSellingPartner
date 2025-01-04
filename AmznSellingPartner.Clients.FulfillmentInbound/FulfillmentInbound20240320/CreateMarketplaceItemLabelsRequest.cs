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
		[JsonProperty("height")]
		[Minimum(25)]
		[Maximum(100)]
		public double Height { get; set; } 

		[JsonProperty("labelType")]
		[IsRequired]
		public LabelPrintType LabelType { get; set; } 

		/// <summary>
		/// The locale code constructed from ISO 639 language code and ISO 3166-1 alpha-2 standard of country codes
		/// separated by an underscore character.
		/// </summary>
		[JsonProperty("localeCode")]
		[Pattern("^[a-z]{2}_[A-Z]{2}")]
		public string LocaleCode { get; set; } = "en_US";

		/// <summary>
		/// The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs
		/// .amazon.com/sp-api/docs/marketplace-ids).
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// Represents the quantity of an MSKU to print item labels for.
		/// </summary>
		[JsonProperty("mskuQuantities")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(100)]
		public List<MskuQuantity> MskuQuantities { get; set; } 

		[JsonProperty("pageType")]
		public ItemLabelPageType PageType { get; set; } 

		/// <summary>
		/// The width of the item label.
		/// </summary>
		[JsonProperty("width")]
		[Minimum(25)]
		[Maximum(100)]
		public double Width { get; set; } 
	}
}
