namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information required to upload a feed document's contents.
	/// </summary>
	public class CreateFeedDocumentResponse : BaseClass
	{
		/// <summary>
		/// The identifier of the feed document.
		/// </summary>
		[IsRequired]
		[JsonProperty("feedDocumentId")]
		public string FeedDocumentId { get; set; }

		/// <summary>
		/// The presigned URL for uploading the feed contents. This URL expires after 5 minutes.
		/// </summary>
		[IsRequired]
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
