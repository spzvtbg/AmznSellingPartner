namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpDelete("/feeds/2021-06-30/feeds/{feedId}")]
	public class CancelFeedDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the feed. This identifier is unique only in combination with a seller ID.
		/// </summary>
		[InPath("feedId")]
		[IsRequired]
		[JsonProperty("feedId")]
		public string FeedId { get; set; }
	}
}
