namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/aplus/2020-11-01/contentDocuments")]
	public class CreateContentDocumentPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the marketplace where the A+ Content is published
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The content document request details
		/// </summary>
		[InBody("postContentDocumentRequest")]
		[IsRequired]
		[JsonProperty("postContentDocumentRequest")]
		public PostContentDocumentRequest PostContentDocumentRequest { get; set; }
	}
}
