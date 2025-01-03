namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Detailed information about the feed
	/// </summary>
	public class Feed : BaseClass
	{
		/// <summary>
		/// The identifier for the feed
		/// This identifier is unique only in combination with a seller ID
		/// </summary>
		[IsRequired]
		[JsonProperty("feedId")]
		public string FeedId { get; set; }

		/// <summary>
		/// The feed type
		/// </summary>
		[IsRequired]
		[JsonProperty("feedType")]
		public string FeedType { get; set; }

		/// <summary>
		/// A list of identifiers for the marketplaces that the feed is applied to
		/// </summary>
		[JsonProperty("marketplaceIds")]
		public List<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The date and time when the feed was created, in ISO 8601 date time format
		/// </summary>
		[IsRequired]
		[JsonProperty("createdTime")]
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// The processing status of the feed
		/// </summary>
		[IsRequired]
		[JsonProperty("processingStatus")]
		public ProcessingStatus ProcessingStatus { get; set; }

		/// <summary>
		/// The date and time when feed processing started, in ISO 8601 date time format
		/// </summary>
		[JsonProperty("processingStartTime")]
		public DateTime ProcessingStartTime { get; set; }

		/// <summary>
		/// The date and time when feed processing completed, in ISO 8601 date time format
		/// </summary>
		[JsonProperty("processingEndTime")]
		public DateTime ProcessingEndTime { get; set; }

		/// <summary>
		/// The identifier for the feed document
		/// This identifier is unique only in combination with a seller ID
		/// </summary>
		[JsonProperty("resultFeedDocumentId")]
		public string ResultFeedDocumentId { get; set; }
	}
}
