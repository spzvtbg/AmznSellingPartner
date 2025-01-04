namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Information required to create the feed.
	/// </summary>
	public class CreateFeedSpecification : BaseClass
	{
		/// <summary>
		/// The feed type.
		/// </summary>
		[JsonProperty("feedType")]
		[IsRequired]
		public string FeedType { get; set; }

		/// <summary>
		/// A list of identifiers for marketplaces that you want the feed to be applied to.
		/// </summary>
		[JsonProperty("marketplaceIds")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(25)]
		public List<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The document identifier returned by the createFeedDocument operation. Upload the feed document contents
		/// before calling the createFeed operation.
		/// </summary>
		[JsonProperty("inputFeedDocumentId")]
		[IsRequired]
		public string InputFeedDocumentId { get; set; }

		[JsonProperty("feedOptions")]
		public FeedOptions FeedOptions { get; set; }
	}
}
