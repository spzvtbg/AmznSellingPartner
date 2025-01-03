namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/feeds/2021-06-30/documents")]
	public class CreateFeedDocumentPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Specifies the content type for the createFeedDocument operation
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateFeedDocumentSpecification Body { get; set; }
	}
}
