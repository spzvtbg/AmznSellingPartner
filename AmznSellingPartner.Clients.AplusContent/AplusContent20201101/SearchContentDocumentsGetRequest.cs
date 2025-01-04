namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/aplus/2020-11-01/contentDocuments")]
	public class SearchContentDocumentsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the marketplace where the A+ Content is published.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// A page token from the nextPageToken response element returned by your previous call to this operation.
		/// nextPageToken is returned when the results of a call exceed the page size. To get the next page of results,
		/// call the operation and include pageToken as the only parameter. Specifying pageToken with any other parameter
		/// will cause the request to fail. When no nextPageToken value is returned there are no more pages to return.
		/// A pageToken value is not usable across different operations.
		/// </summary>
		[InQuery("pageToken")]
		[MinLength(1)]
		public string PageToken { get; set; }
	}
}
