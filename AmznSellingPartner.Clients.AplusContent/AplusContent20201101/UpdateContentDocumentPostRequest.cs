namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/aplus/2020-11-01/contentDocuments/{contentReferenceKey}")]
	public class UpdateContentDocumentPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique reference key for the A+ Content document. A content reference key cannot form a permalink
		/// and may change in the future. A content reference key is not guaranteed to match any A+ Content iden
		/// tifier.
		/// </summary>
		[InPath("contentReferenceKey")]
		[IsRequired]
		[MinLength(1)]
		public string ContentReferenceKey { get; set; } 

		/// <summary>
		/// The identifier for the marketplace where the A+ Content is published.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The content document request details.
		/// </summary>
		[InBody("postContentDocumentRequest")]
		[IsRequired]
		public PostContentDocumentRequest PostContentDocumentRequest { get; set; } 
	}
}
