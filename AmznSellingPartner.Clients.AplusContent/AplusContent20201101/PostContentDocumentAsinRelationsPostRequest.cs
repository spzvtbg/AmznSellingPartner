namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/aplus/2020-11-01/contentDocuments/{contentReferenceKey}/asins")]
	public class PostContentDocumentAsinRelationsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique reference key for the A+ Content document. A content reference key cannot form a permalink
		/// and may change in the future. A content reference key is not guaranteed to match any A+ content iden
		/// tifier.
		/// </summary>
		[InPath("contentReferenceKey")]
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("contentReferenceKey")]
		public string ContentReferenceKey { get; set; }

		/// <summary>
		/// The identifier for the marketplace where the A+ Content is published.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The content document ASIN relations request details.
		/// </summary>
		[InBody("postContentDocumentAsinRelationsRequest")]
		[IsRequired]
		[JsonProperty("postContentDocumentAsinRelationsRequest")]
		public PostContentDocumentAsinRelationsRequest PostContentDocumentAsinRelationsRequest { get; set; }
	}
}
