namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpPost("/aplus/2020-11-01/contentAsinValidations")]
	public class AmznValidateContentDocumentAsinRelationsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the marketplace where the A+ Content is published.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The set of ASINs.
		/// </summary>
		[InQuery("asinSet")]
		[UniqueItems]
		public CsvValue<string> AsinSet { get; set; } 

		/// <summary>
		/// The content document request details.
		/// </summary>
		[InBody("postContentDocumentRequest")]
		[IsRequired]
		public PostContentDocumentRequest PostContentDocumentRequest { get; set; } 
	}
}
