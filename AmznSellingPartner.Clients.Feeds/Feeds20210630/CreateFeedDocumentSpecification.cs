namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Specifies the content type for the createFeedDocument operation.
	/// </summary>
	public class CreateFeedDocumentSpecification : BaseClass
	{
		/// <summary>
		/// The content type of the feed.
		/// </summary>
		[IsRequired]
		[JsonProperty("contentType")]
		public string ContentType { get; set; }
	}
}
