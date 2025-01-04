namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The metadata of an A+ Content document.
	/// </summary>
	public class ContentMetadata : BaseClass
	{
		/// <summary>
		/// The A+ Content document name.
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string Name { get; set; } 

		[JsonProperty("marketplaceId")]
		[IsRequired]
		public MarketplaceId MarketplaceId { get; set; } 

		[JsonProperty("status")]
		[IsRequired]
		public ContentStatus Status { get; set; } 

		[JsonProperty("badgeSet")]
		[IsRequired]
		public ContentBadgeSet BadgeSet { get; set; } 

		/// <summary>
		/// The approximate age of the A+ Content document and metadata.
		/// </summary>
		[JsonProperty("updateTime")]
		[IsRequired]
		public DateTime UpdateTime { get; set; } 
	}
}
