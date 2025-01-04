namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Response schema.
	/// </summary>
	public class CreateFeedResponse : BaseClass
	{
		/// <summary>
		/// The identifier for the feed. This identifier is unique only in combination with a seller ID.
		/// </summary>
		[JsonProperty("feedId")]
		[IsRequired]
		public string FeedId { get; set; } 
	}
}
