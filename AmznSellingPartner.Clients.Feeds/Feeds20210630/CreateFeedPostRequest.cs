namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/feeds/2021-06-30/feeds")]
	public class CreateFeedPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Information required to create the feed.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateFeedSpecification Body { get; set; }
	}
}
