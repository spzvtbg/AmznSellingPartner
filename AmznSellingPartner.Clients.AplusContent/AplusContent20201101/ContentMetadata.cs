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
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("name")]
		public string Name { get; set; }

		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("status")]
		public ContentStatus Status { get; set; }

		[IsRequired]
		[JsonProperty("badgeSet")]
		public ContentBadgeSet BadgeSet { get; set; }

		/// <summary>
		/// The approximate age of the A+ Content document and metadata.
		/// </summary>
		[IsRequired]
		[JsonProperty("updateTime")]
		public DateTime UpdateTime { get; set; }
	}
}
