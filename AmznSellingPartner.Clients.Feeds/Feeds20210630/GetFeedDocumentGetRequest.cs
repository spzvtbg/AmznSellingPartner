namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/feeds/2021-06-30/documents/{feedDocumentId}")]
	public class GetFeedDocumentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier of the feed document.
		/// </summary>
		[InPath("feedDocumentId")]
		[IsRequired]
		public string FeedDocumentId { get; set; }
	}
}
