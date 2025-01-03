namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/feeds/2021-06-30/feeds")]
	public class CreateFeedPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Information required to create the feed.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateFeedSpecification Body { get; set; }
	}
}
