namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Summary details of an Amazon catalog item for the indicated Amazon marketplace.
	/// </summary>
	public class ItemSummaryByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Identifies an Amazon catalog item is intended for an adult audience or is sexual in nature.
		/// </summary>
		[JsonProperty("adultProduct")]
		public bool AdultProduct { get; set; }

		/// <summary>
		/// Identifies an Amazon catalog item is autographed by a player or celebrity.
		/// </summary>
		[JsonProperty("autographed")]
		public bool Autographed { get; set; }

		/// <summary>
		/// Name of the brand associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("brand")]
		public string Brand { get; set; }

		/// <summary>
		/// Classification (browse node) associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("browseClassification")]
		public ItemBrowseClassification BrowseClassification { get; set; }

		/// <summary>
		/// Name of the color associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		/// Individual contributors to the creation of an item, such as the authors or actors.
		/// </summary>
		[JsonProperty("contributors")]
		public List<ItemContributor> Contributors { get; set; }

		/// <summary>
		/// Classification type associated with the Amazon catalog item.
		/// </summary>
		[JsonProperty("itemClassification")]
		public ItemClassification ItemClassification { get; set; }

		/// <summary>
		/// Name, or title, associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("itemName")]
		public string ItemName { get; set; }

		/// <summary>
		/// Name of the manufacturer associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("manufacturer")]
		public string Manufacturer { get; set; }

		/// <summary>
		/// Identifies an Amazon catalog item is memorabilia valued for its connection with historical events, culture, or
		/// entertainment.
		/// </summary>
		[JsonProperty("memorabilia")]
		public bool Memorabilia { get; set; }

		/// <summary>
		/// Model number associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("modelNumber")]
		public string ModelNumber { get; set; }

		/// <summary>
		/// Quantity of an Amazon catalog item in one package.
		/// </summary>
		[JsonProperty("packageQuantity")]
		public int PackageQuantity { get; set; }

		/// <summary>
		/// Part number associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("partNumber")]
		public string PartNumber { get; set; }

		/// <summary>
		/// First date on which an Amazon catalog item is shippable to customers.
		/// </summary>
		[JsonProperty("releaseDate")]
		public DateTime ReleaseDate { get; set; }

		/// <summary>
		/// Name of the size associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("size")]
		public string Size { get; set; }

		/// <summary>
		/// Name of the style associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("style")]
		public string Style { get; set; }

		/// <summary>
		/// Identifies an Amazon catalog item is eligible for trade-in.
		/// </summary>
		[JsonProperty("tradeInEligible")]
		public bool TradeInEligible { get; set; }

		/// <summary>
		/// Identifier of the website display group associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("websiteDisplayGroup")]
		public string WebsiteDisplayGroup { get; set; }

		/// <summary>
		/// Display name of the website display group associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("websiteDisplayGroupName")]
		public string WebsiteDisplayGroupName { get; set; }
	}
}
